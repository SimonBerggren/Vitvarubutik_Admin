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

namespace Vitvarubutik_Admin.Tables.Produkt
{
    public partial class ConnectProductForm : Form
    {
        public ConnectProductForm(int ProduktID)
        {
            produktID = ProduktID;

            InitializeComponent();
            GetProducts();
            ShowDialog(null);
        }
        List<int> allIndexes = new List<int>();
        List<int> kampanjIndexes = new List<int>();

        int produktID;
        string filter = "";
        string ID_filter;
        string category = "";

        private void GetProducts()
        {
            allIndexes.Clear();
            AllProductList.Items.Clear();
            ProductList.Items.Clear();
            kampanjIndexes.Clear();
            ID_filter = "";

            if (filter.Contains("WHERE"))
                filter = " AND " + filter.TrimStart(' ', 'W', 'H', 'E', 'R', 'E');

            string query =
                " SELECT Produkt.Tillverkare, Produkt.Modell, Produkt.Typ, Produkt.Artikelnummer FROM KoppladTill "
              + " INNER JOIN Produkt ON KoppladTill.KoppladProdukt = Produkt.Artikelnummer "
              + " WHERE KoppladTill.VisadProdukt = " + produktID + filter;

            MySqlDataReader reader = Main.RunQuery(query);
            if (reader == null) return;

            // Adds and displays all products in selected kampanj
            // Prevents all items in selected kampanj to be showed again in list of all products

            while (reader.Read())
            {
                kampanjIndexes.Add(reader.GetInt32(3));
                string line = reader.GetString(0) + ", " + reader.GetString(1) + ", " + reader.GetString(2);
                ProductList.Items.Add(line);
            }

            ID_filter = " WHERE Produkt.Artikelnummer != " + produktID;

            if (kampanjIndexes.Count > 0)
            {
                ID_filter += " AND ";
                for (int i = 0; i < kampanjIndexes.Count; i++)
                {
                    if (i < kampanjIndexes.Count - 1)
                        ID_filter += " Produkt.Artikelnummer != " + kampanjIndexes[i] + " AND ";
                    else
                        ID_filter += " Produkt.Artikelnummer != " + kampanjIndexes[i];
                }
            }

            // Adds all products that are not in kampanj to list
            string newquery = "SELECT Produkt.Artikelnummer, Produkt.Tillverkare, Produkt.Modell, Produkt.Typ FROM Produkt " + ID_filter + filter;
            reader = Main.RunQuery(newquery);
            if (reader == null) return;

            while (reader.Read())
            {
                allIndexes.Add(reader.GetInt32(0));
                string line = reader.GetString(1) + ", " + reader.GetString(2) + ", " + reader.GetString(3);
                AllProductList.Items.Add(line);
            }

            reader.Close();
            Main.CloseConnection();

            Console.WriteLine(query);
            Console.WriteLine(newquery);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AllProductList.SelectedIndex < 0) return;

            int id = allIndexes[AllProductList.SelectedIndex];

            MySqlDataReader reader;

            reader = Main.RunQuery("INSERT INTO KoppladTill VALUES (" + produktID + ", " + id + ")");
            if (reader == null) return;

            reader.Close();
            Main.CloseConnection();

            GetProducts();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ProductList.SelectedIndex < 0) return;

            int id = kampanjIndexes[ProductList.SelectedIndex];

            MySqlDataReader reader;

            reader = Main.RunQuery("DELETE FROM KoppladTill WHERE VisadProdukt = " + produktID + " AND KoppladProdukt = " + id);
            if (reader == null) return;

            reader.Close();
            Main.CloseConnection();

            GetProducts();
        }

        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            if (filter == "")
                return;

            MySqlDataReader reader = null;

            for (int i = 0; i < AllProductList.Items.Count; i++)
            {
                reader = Main.RunQuery("INSERT INTO KoppladTill VALUES (" + produktID + ", " + allIndexes[i] + ")");
            }

            if (reader != null)
                reader.Close();

            Main.CloseConnection();

            GetProducts();
        }

        private void RemoveGroupButton_Click(object sender, EventArgs e)
        {
            if (filter == "")
                return;

            MySqlDataReader reader;

            reader = Main.RunQuery("DELETE KoppladTill FROM KoppladTill JOIN Produkt ON KoppladTill.KoppladProdukt = Produkt.Artikelnummer WHERE KoppladTill.VisadProdukt = " + produktID + filter);
            if (reader == null) return;

            reader.Close();
            Main.CloseConnection();

            GetProducts();
        }

        private void SelectCategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectCategoryList.SelectedIndex <= 0)
            {
                SelectFilterList.Visible = false;

                filter = "";
                category = "";

                GetProducts();
                return;
            }

            category = SelectCategoryList.Items[SelectCategoryList.SelectedIndex].ToString();

            UpdateCategoryList();
        }

        /// <summary>
        /// Controlls CategoryList, only add categories that already exists in the database
        /// </summary>

        public void UpdateCategoryList()
        {
            SelectFilterList.Visible = true;

            MySqlDataReader reader = Main.RunQuery(" SELECT " + category + " FROM Produkt WHERE Artikelnummer != " + produktID + " GROUP BY " + category);
            if (reader == null) return;

            SelectFilterList.Items.Clear();
            while (reader.Read())
            {
                SelectFilterList.Items.Add(reader.GetString(0));
            }

            reader.Close();
            Main.CloseConnection();
        }

        /// <summary>
        /// Checks for MouseClick Event.
        /// When triggered, wait until event has finnished.
        /// Then Update CategoryList.
        /// </summary>

        private void SelectFilterList_Click(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(ShowFilter), null);
        }

        /// <summary>
        /// Updates CategoryList.
        /// If no items are checked, disable RemoveCategoryButton.
        /// Updates products, in case user just unchecked the last category.
        /// If user checked a category or there are more checked items left, we want to filter the products accordingly.
        /// Loop through every checked item and add its name to our filter.
        /// Update products and enable RemoveCategoryButton.
        /// </summary>

        private void ShowFilter()
        {
            if (SelectFilterList.CheckedItems.Count <= 0)
            {
                filter = "";
                GetProducts();
                return;
            }

            filter = " AND (Produkt." + category + " = ";

            for (int i = 0; i < SelectFilterList.CheckedItems.Count; i++)
            {
                if (i < SelectFilterList.CheckedItems.Count - 1)
                    filter += " '" + SelectFilterList.CheckedItems[i].ToString() + "' OR Produkt." + category + " = ";
                else
                    filter += " '" + SelectFilterList.CheckedItems[i].ToString() + "' ) ";
            }

            GetProducts();
        }
    }
}
