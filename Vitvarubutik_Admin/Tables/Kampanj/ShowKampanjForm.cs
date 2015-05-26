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
    public partial class ShowKampanjForm : FixedForm
    {
        List<int> indexes = new List<int>();

        public ShowKampanjForm()
        {
            InitializeComponent();
            UpdateItems();
            Show();
        }

        private void EnableButton(object sender, EventArgs e)
        {
            if (listKampanj.SelectedIndex < 0)
                AddProduktButton.Enabled = false;
            else
                AddProduktButton.Enabled = true;
        }

        private void AddKampanjButton_Click(object sender, EventArgs e)
        {
            new AddKampanjForm(this);
        }

        private void EditKampanjButton_Click(object sender, EventArgs e)
        {
            if (listKampanj.SelectedIndex < 0)
                return;

            int id = indexes[listKampanj.SelectedIndex];

            MySqlDataReader reader = Main.RunQuery("SELECT * FROM Kampanj WHERE KampanjID = " + id);
            if (reader == null) return;

            reader.Read();
            new AddKampanjForm(this, reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetDateTime(4));

            reader.Close();
            Main.CloseConnection();
        }

        private void RemoveKampanjButton_Click(object sender, EventArgs e)
        {
            if (listKampanj.SelectedIndex < 0)
                return;

            int id = indexes[listKampanj.SelectedIndex];

            MySqlDataReader reader = Main.RunQuery("DELETE FROM Kampanj WHERE KampanjID = " + id);
            if (reader == null) return;

            indexes.Remove(id);

            reader.Close();
            Main.CloseConnection();

            UpdateItems();
        }

        public void UpdateItems()
        {
            listKampanj.Items.Clear();
            indexes.Clear();

            MySqlDataReader reader = Main.RunQuery("SELECT KampanjID, Namn, DATE_FORMAT(StartDatum, '%Y-%m-%d'), DATE_FORMAT(SlutDatum, '%Y-%m-%d') FROM Kampanj");
            if (reader == null) return;

            while (reader.Read())
            {
                indexes.Add(reader.GetInt32(0));
                string line = "Namn: " + reader.GetString(1) + " StartDatum: " + reader.GetString(2) + " SlutDatum: " + reader.GetString(3);
                listKampanj.Items.Add(line);
            }

            reader.Close();
            Main.CloseConnection();
        }

        private void AddProduktButton_Click(object sender, EventArgs e)
        {
            if(listKampanj.SelectedIndex < 0) return;

            new ProductToKampanjForm(indexes[listKampanj.SelectedIndex]);
        }
    }
}
