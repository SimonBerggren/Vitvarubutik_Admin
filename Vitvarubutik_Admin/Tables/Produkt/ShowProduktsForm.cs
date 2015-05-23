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

        public ShowProduktsForm()
        {
            InitializeComponent();
            Show();
            UpdateItemList();
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

            MySqlDataReader reader = Main.RunQuery("DELETE FROM Produkt WHERE Artikelnummer = " + id);

            reader.Close();
            Main.CloseConnection();

            indexes.Remove(id);
            UpdateItemList();
        }

        private void RedigeraButton_Click(object sender, EventArgs e)
        {
            if (listProducts.SelectedIndex < 0)
                return;

            int id = indexes[listProducts.SelectedIndex];

            MySqlDataReader reader = Main.RunQuery("SELECT * FROM Produkt WHERE Artikelnummer = " + id);

            reader.Read();
            new AddProductForm(this, reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(5), reader.GetString(6), reader.GetString(7), reader.GetInt32(8));
            
            reader.Close();
            Main.CloseConnection();
        }

        public void UpdateItemList()
        {
            listProducts.Items.Clear();
            indexes.Clear();

            MySqlDataReader reader = Main.RunQuery("SELECT Tillverkare, Modell, Typ, Energiklass, Pris, Beskrivning, lagerantal, Artikelnummer FROM Produkt");

            while (reader.Read())
            {
                string line = "Tillverkare: " + reader.GetString(0) + " Modell: " + reader.GetString(1) + " Typ: " + reader.GetString(2) + " Energiklass: " + reader.GetString(3) + " Pris: " + reader.GetString(4)
                    + " Beskrivning: " + reader.GetString(5) + " Antal i lager: " + reader.GetString(6);
                listProducts.Items.Add(line);
                indexes.Add(reader.GetInt32(7));
            }

            reader.Close();
            Main.CloseConnection();
        }
    }
}
