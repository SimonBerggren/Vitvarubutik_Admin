using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vitvarubutik_Admin.Utilities;

namespace Vitvarubutik_Admin.Tables.Produkt
{
    public partial class ShowProduktsForm : FixedForm
    {
        private List<int> indexes = new List<int>();
        string categories = "";
        bool dislayingFewProducts = false;

        public ShowProduktsForm()
        {
            InitializeComponent();
            CheckQuantity();
            UpdateCategoryList();
            Show();
        }

        private void NewProductButton_Click(object sender, EventArgs e)
        {
            new AddProductForm(this);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listProducts.SelectedIndex < 0)
                return;

            int id = indexes[listProducts.SelectedIndex];
            MySqlDataReader reader;

            reader = Main.RunQuery("DELETE FROM IngårI WHERE Artikelnummer = " + id);

            reader = Main.RunQuery("DELETE FROM Produkt WHERE Artikelnummer = " + id);

            if (reader == null) return;

            reader.Close();
            Main.CloseConnection();

            UpdateItemList();
        }

        private void RedigeraButton_Click(object sender, EventArgs e)
        {
            if (listProducts.SelectedIndex < 0)
                return;

            int id = indexes[listProducts.SelectedIndex];

            MySqlDataReader reader = Main.RunQuery("SELECT * FROM Produkt WHERE Artikelnummer = " + id);
            if (reader == null) return;

            reader.Read();
            new AddProductForm(this, reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4),
                                     reader.GetString(5), reader.GetInt32(6), reader.GetString(7), reader.GetInt32(8), reader.GetString(9), reader.GetInt32(10));

            reader.Close();
            Main.CloseConnection();
        }

        private void ViewBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ViewBox.SelectedItem.ToString() == "Alla produkter")
                dislayingFewProducts = false;
            else if (ViewBox.SelectedItem.ToString() == "Få produkter")
                dislayingFewProducts = true;

            UpdateItemList();
        }

        public void UpdateItemList()
        {
            if (dislayingFewProducts)
                UpdateQuantity();
            else
                UpdateProducts();
        }

        public void UpdateProducts()
        {
            MySqlDataReader reader = Main.RunQuery("SELECT Artikelnummer, Tillverkare, Modell, Typ, Energiklass, Beskrivning, Pris, Lagerantal, Leverantör, Inköpspris FROM Produkt" + categories);
            if (reader == null) return;

            listProducts.Items.Clear();
            indexes.Clear();

            while (reader.Read())
            {
                indexes.Add(reader.GetInt32(0));
                string line = "Tillverkare: " + reader.GetString(1) + " Modell: " + reader.GetString(2) + " Typ: " + reader.GetString(3) + " Energiklass: " + reader.GetString(4) + " Pris: " + reader.GetString(5)
                    + " Antal i lager: " + reader.GetString(7) + " Leverantör: " + reader.GetString(8) + " Inköpspris: " + reader.GetInt32(9);
                listProducts.Items.Add(line);
            }

            reader.Close();
            Main.CloseConnection();
        }

        private void CheckQuantity()
        {
            MySqlDataReader reader = Main.RunQuery("SELECT COUNT(*), Artikelnummer, Tillverkare, Modell, Typ, Lagerantal FROM Produkt WHERE Lagerantal <= 3 GROUP BY Artikelnummer ORDER BY Lagerantal");
            if (reader == null) return;

            var warningMsg = MessageBox.Show("Vissa produkter håller på att gå ut! Klicka på Ja för att visa dem.", "", MessageBoxButtons.YesNo);

            if (warningMsg == DialogResult.Yes)
                ViewBox.SelectedIndex = ViewBox.FindString("Få produkter");
            else
                ViewBox.SelectedIndex = ViewBox.FindString("Alla produkter");
        }

        private void UpdateQuantity()
        {
            MySqlDataReader reader = Main.RunQuery("SELECT COUNT(*), Artikelnummer, Tillverkare, Modell, Typ, Lagerantal FROM Produkt WHERE Lagerantal <= 3 GROUP BY Artikelnummer ORDER BY Lagerantal");
            if (reader == null) return;

            listProducts.Items.Clear();
            indexes.Clear();

            while (reader.Read())
            {
                for (int i = 0; i < reader.GetInt32(0); i++)
                {
                    indexes.Add(reader.GetInt32(1));
                    listProducts.Items.Add("Tillverkare: " + reader.GetString(2) + " Modell: " + reader.GetString(3) + " Typ: " + reader.GetString(4) + " Lagerantal: " + reader.GetInt32(5));
                }
            }

            reader.Close();
            Main.CloseConnection();
        }

        public void UpdateCategoryList()
        {
            MySqlDataReader reader = Main.RunQuery("SELECT Typ FROM Produkt GROUP BY Typ");
            if (reader == null) return;

            CategoryList.Items.Clear();
            while (reader.Read())
            {
                CategoryList.Items.Add(reader.GetString(0));
            }

            reader.Close();
            Main.CloseConnection();
        }

        private void RemoveCategory_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("VARNING! Alla produkter tillhörande vald(a) kategori(er) kommer tas bort!", "", MessageBoxButtons.OKCancel);

            if (confirm == System.Windows.Forms.DialogResult.Cancel || categories == "") return;

            MySqlDataReader reader;

            reader = Main.RunQuery("DELETE IngårI FROM IngårI JOIN Produkt ON IngårI.Artikelnummer = Produkt.Artikelnummer" + categories);

            reader = Main.RunQuery("DELETE FROM Produkt" + categories);

            if (reader == null) return;

            CategoryList.CheckedItems.OfType<string>().ToList().ForEach(CategoryList.Items.Remove);

            reader.Close();
            Main.CloseConnection();

            UpdateItemList();

        }

        private void CategoryList_CheckedItem(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(ShowCategories), null);
        }

        private void ShowCategories()
        {
            if (CategoryList.CheckedItems.Count <= 0)
            {
                categories = "";
                RemoveCategoryButton.Enabled = false;
                UpdateItemList();
                return;
            }

            categories = " WHERE Produkt.Typ = ";

            for (int i = 0; i < CategoryList.CheckedItems.Count; i++)
            {
                if (i < CategoryList.CheckedItems.Count - 1)
                    categories += " '" + CategoryList.CheckedItems[i].ToString() + "' OR Produkt.Typ = ";
                else
                    categories += " '" + CategoryList.CheckedItems[i].ToString() + "'";
            }

            UpdateItemList();
            RemoveCategoryButton.Enabled = true;
        }
    }
}
