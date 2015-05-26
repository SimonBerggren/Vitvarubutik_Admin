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

namespace Vitvarubutik_Admin.Tables.Leverantör
{
    public partial class ShowLeverantörForm : FixedForm
    {
        List<string> indexes = new List<string>();

        public ShowLeverantörForm()
        {
            InitializeComponent();
            UpdateItemList();
            Show();
        }

        private void AddLeverantörButton_Click(object sender, EventArgs e)
        {
            new AddLeverantörForm(this);
        }

        private void EditLeverantörButton_Click(object sender, EventArgs e)
        {
            if (listLeverantör.SelectedIndex < 0)
                return;

            string id = indexes[listLeverantör.SelectedIndex];

            MySqlDataReader reader = Main.RunQuery("SELECT * FROM Leverantör WHERE Namn = '" + id + "'");

            reader.Read();
            new AddLeverantörForm(this, reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));

            reader.Close();
            Main.CloseConnection();
        }

        private void RemoveLeverantörButton_Click(object sender, EventArgs e)
        {
            if (listLeverantör.SelectedIndex < 0)
                return;

            string id = indexes[listLeverantör.SelectedIndex];

            MySqlDataReader reader = Main.RunQuery("DELETE FROM Leverantör WHERE Namn = '" + id + "'");
            if (reader == null) return;

            reader.Close();
            Main.CloseConnection();

            indexes.Remove(id);
            UpdateItemList();
        }

        public void UpdateItemList()
        {
            listLeverantör.Items.Clear();
            indexes.Clear();

            MySqlDataReader reader = Main.RunQuery("SELECT * FROM Leverantör");

            if (reader == null) return;

            while (reader.Read())
            {
                indexes.Add(reader.GetString(0));
                string line = "Namn: " + reader.GetString(0) + " Telefonnummer: " + reader.GetString(1) + " Email: " + reader.GetString(2) + " Faktureringsadress: " + reader.GetString(3);
                listLeverantör.Items.Add(line);
            }

            reader.Close();
            Main.CloseConnection();
        }
    }
}
