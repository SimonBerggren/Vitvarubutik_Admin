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

namespace Vitvarubutik_Admin.Tables.Kund
{
    public partial class ShowKundForm : FixedForm
    {
        List<int> indexes = new List<int>();

        public ShowKundForm()
        {
            InitializeComponent();
            UpdateItemList();
            Show();
        }

        private void AddKundButton_Click(object sender, EventArgs e)
        {
            new AddKundForm(this);
        }

        private void EditKundButton_Click(object sender, EventArgs e)
        {
            if (listCustomers.SelectedIndex < 0)
                return;

            int id = indexes[listCustomers.SelectedIndex];

            MySqlDataReader reader = Main.RunQuery("SELECT * FROM Kund WHERE Kundnummer = " + id);

            new AddKundForm(this, reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));

            reader.Close();
            Main.CloseConnection();

            UpdateItemList();
        }

        private void RemoveKundButton_Click(object sender, EventArgs e)
        {
            if (listCustomers.SelectedIndex < 0)
                return;

            int id = indexes[listCustomers.SelectedIndex];

            MySqlDataReader reader = Main.RunQuery("DELETE FROM Kund WHERE Kundnummer = " + id);

            indexes.Remove(id);

            reader.Close();
            Main.CloseConnection();

            UpdateItemList();
        }

        public void UpdateItemList()
        {
            listCustomers.Items.Clear();
            indexes.Clear();

            MySqlDataReader reader = Main.RunQuery("SELECT Kundnummer, Namn, Telefonnummer, Email FROM Kund");

            while (reader.Read())
            {
                indexes.Add(reader.GetInt32(0));
                string line = "Namn: " + reader.GetString(1) + " Telefonnummer: " + reader.GetString(2) + " Email: " + reader.GetString(3);
                listCustomers.Items.Add(line);
            }

            reader.Close();
            Main.CloseConnection();
        }
    }
}
