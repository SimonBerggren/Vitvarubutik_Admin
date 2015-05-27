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

namespace Vitvarubutik_Admin.Tables.Kampanj
{
    public partial class ProductToKampanjForm : FixedForm
    {
        List<int> allIndexes = new List<int>();
        List<int> kampanjIndexes = new List<int>();

        int id;
        string exception = "";

        public ProductToKampanjForm(int id)
        {
            this.id = id;

            InitializeComponent();
            GetProducts();
            ShowDialog(null);
        }

        private void GetProducts()
        {
            allIndexes.Clear();
            AllProductList.Items.Clear();
            ProductList.Items.Clear();
            kampanjIndexes.Clear();
            exception = "";

            MySqlDataReader reader = Main.RunQuery("SELECT Produkt.Tillverkare, Produkt.Modell, Produkt.Typ, Produkt.Artikelnummer FROM IngårI "
                                                 + "INNER JOIN Kampanj Kampanj ON IngårI.KampanjID = Kampanj.KampanjID "
                                                 + "INNER JOIN Produkt Produkt ON IngårI.Artikelnummer = Produkt.Artikelnummer "
                                                 + "WHERE Kampanj.KampanjID = " + id);
            if (reader == null) return;

            // Adds and displays all products in selected kampanj
            // Prevents all items in selected kampanj to be showed again in list of all products

            while (reader.Read())
            {
                kampanjIndexes.Add(reader.GetInt32(3));
                string line = reader.GetString(0) + ", " + reader.GetString(1) + ", " + reader.GetString(2);
                ProductList.Items.Add(line);
            }

            if (kampanjIndexes.Count > 0)
            {
                exception = " WHERE ";
                for (int i = 0; i < kampanjIndexes.Count; i++)
                {
                    if (i < kampanjIndexes.Count - 1)
                        exception += " Artikelnummer != " + kampanjIndexes[i] + " AND ";
                    else
                        exception += " Artikelnummer != " + kampanjIndexes[i];
                }
            }

            // Adds all products that are not in kampanj to list

            reader = Main.RunQuery("SELECT Artikelnummer, Tillverkare, Modell, Typ FROM Produkt " + exception);

            if (reader == null) return;

            while (reader.Read())
            {
                allIndexes.Add(reader.GetInt32(0));
                string line = "Tillverkare: " + reader.GetString(1) + " Modell: " + reader.GetString(2) + " Typ: " + reader.GetString(3);
                AllProductList.Items.Add(line);
            }

            reader.Close();
            Main.CloseConnection();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (allIndexes[AllProductList.SelectedIndex] < 0) return;

            int id = allIndexes[AllProductList.SelectedIndex];

            MySqlDataReader reader;

            reader = Main.RunQuery("INSERT INTO IngårI VALUES (" + this.id + ", " + id + ")");
            if (reader == null) return;

            reader.Close();
            Main.CloseConnection();

            GetProducts();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (kampanjIndexes[ProductList.SelectedIndex] < 0) return;

            int id = kampanjIndexes[ProductList.SelectedIndex];

            MySqlDataReader reader;

            reader = Main.RunQuery("DELETE FROM IngårI WHERE Artikelnummer = " + id);

            reader.Close();
            Main.CloseConnection();

            GetProducts();
        }
    }
}
