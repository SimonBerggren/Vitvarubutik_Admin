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

        private string categories = "";

        public ShowProduktsForm()
        {
            InitializeComponent();

            UpdateCategoryList();
            InitialCheck();

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
        }

        /// <summary>
        /// If user wants to edit an existing product, make sure there is a selected product first.
        /// Ask database for information about  selected product, sending it to a new form.
        /// </summary>

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

        /// <summary>
        /// Controlls what happens when user changes which product to view.
        /// Either every product in stock or only almost sold out ones.
        /// </summary>

        private void ViewBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ViewBox.SelectedIndex == 0)
                UpdateProducts();
            else if (ViewBox.SelectedIndex == 1)
                UpdateFewProducts();
        }

        /// <summary>
        /// Asks database for information about every product
        /// Adds it to product list and displaying
        /// </summary>

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

        /// <summary>
        /// Used for checking if there only exists 3 or fewer products of any kind.
        /// If this is the case, 
        /// If user accepts, select and fill correct list with concerned products.
        /// </summary>
        /// 

        private void InitialCheck()
        {
            MySqlDataReader reader = Main.RunQuery("SELECT COUNT(*), Artikelnummer, Tillverkare, Modell, Typ, Lagerantal FROM Produkt WHERE Lagerantal <= 3 GROUP BY Artikelnummer ORDER BY Lagerantal");
            if (reader == null) return;

            bool thereIsProducts = true;

            if (!reader.Read())
                thereIsProducts = false;


            if (thereIsProducts)
            {
                var warningMsg = MessageBox.Show("Vissa produkter håller på att gå ut! Klicka på Ja för att visa dem.", "", MessageBoxButtons.YesNo);

                if (warningMsg == DialogResult.Yes)
                    ViewBox.SelectedIndex = 1;
                else if (warningMsg == DialogResult.No)
                    ViewBox.SelectedIndex = 0;
            }
            else
                ViewBox.SelectedIndex = 0;

        }

        /// <summary>
        /// Used for updating and filling list with products there only are 3 or less of
        /// </summary>

        private void UpdateFewProducts()
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

        /// <summary>
        /// Controlls CategoryList, only add categories that already exists in the database
        /// </summary>

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

        /// <summary>
        /// Controlls what happens when clicking button for removing a category.
        /// Warns user with a Yes or Cancel form since every product within the category will also be deleted.
        /// If user cancels or no categorys are selected, do nothing.
        /// Products in kampanj are dependent on entries in table IngårI, 
        /// which is why we are first trying to delete every entry in table IngårI which is within our selected categories. 
        /// Then loop through items in CheckBoxList and delete them from there as well.
        /// Update listProduct in case any products where removed.
        /// </summary>

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

            UpdateProducts();
        }

        /// <summary>
        /// Checks for MouseClick Event.
        /// When triggered, wait until event has finnished.
        /// Then Update CategoryList.
        /// </summary>

        private void CategoryList_Click(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(ShowCategories), null);
        }

        /// <summary>
        /// Updates CategoryList.
        /// If no items are checked, disable RemoveCategoryButton.
        /// Updates products, in case user just unchecked the last category.
        /// If user checked a category or there are more checked items left, we want to filter the products accordingly.
        /// Loop through every checked item and add its name to our filter.
        /// Update products and enable RemoveCategoryButton.
        /// </summary>

        private void ShowCategories()
        {
            if (CategoryList.CheckedItems.Count <= 0)
            {
                categories = "";
                RemoveCategoryButton.Enabled = false;
                UpdateProducts();
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

            UpdateProducts();
            RemoveCategoryButton.Enabled = true;
        }

        private void ConnectProductButton_Click(object sender, EventArgs e)
        {
            if(listProducts.SelectedIndex < 0)
                return;

            new ConnectProductForm(indexes[listProducts.SelectedIndex]);
        }
    }
}
