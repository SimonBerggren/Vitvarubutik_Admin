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
        List<int> indexes = new List<int>();
        int id;

        public ProductToKampanjForm(int id)
        {
            this.id = id;

            InitializeComponent();
            GetProducts();
            ShowDialog(null);
        }

        private void GetProducts()
        {
            ProductList.Items.Clear();
            indexes.Clear();

            MySqlDataReader reader = Main.RunQuery("SELECT Produkt.Tillverkare, Produkt.Modell, Produkt.Typ FROM IngårI "
                                                 + "INNER JOIN Kampanj Kampanj ON IngårI.KampanjID = Kampanj.KampanjID "
                                                 + "INNER JOIN Produkt Produkt ON IngårI.Artikelnummer = Produkt.Artikelnummer "
                                                 + "WHERE Kampanj.KampanjID = " + id);
            if (reader == null) return;

            while (reader.Read())
            {
                string line = reader.GetString(0) + ", " + reader.GetString(1) + ", " + reader.GetString(2);
                ProductList.Items.Add(line);
            }

            reader.Close();
            Main.CloseConnection();
        }
    }
}
