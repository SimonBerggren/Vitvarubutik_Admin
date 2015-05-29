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
using MySql.Data.MySqlClient;
using Vitvarubutik_Admin.Tables.Kund;
using Vitvarubutik_Admin.Tables.Produkt;
using Vitvarubutik_Admin.Tables.Leverantör;
using Vitvarubutik_Admin.Tables.Kampanj;

namespace Vitvarubutik_Admin
{
    public partial class Main : FixedForm
    {
        // Database connection properties
        public static string Host { get; set; }
        public static string Database { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }

        private bool Established_Connection { get; set; }

        public Main()
        {
            InitializeComponent();
            Show();

            Host = "195.178.235.60";
            Database = "ae6945";
            Username = "ae6945";
            Password = "TomatSallad";

            new NewConnectionForm(this);
        }

        // Main Connection

        static MySqlConnection conn;

        public static MySqlDataReader RunQuery(string query)
        {
            conn = null;
            MySqlDataReader reader = null;
            try
            {
                // Connection
                conn = new MySqlConnection("server=" + Host + ";uid=" + Username + ";pwd=" + Password + ";database=" + Database + ";");
                conn.Open();

                // Query
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                reader = cmd.ExecuteReader();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(query);
                conn.Close();
                new MSGForm(e.Message, null);
                return null;
            }

            Console.Read();

            return reader;
        }

        public static void CloseConnection()
        {
            if (conn != null)
                conn.Close();
        }

        public void Establish_Connection()
        {
            Established_Connection = false;

            MySqlConnection conn = null;
            try
            {
                Established_Connection = true;
                conn = new MySqlConnection("server=" + Host + ";uid=" + Username + ";pwd=" + Password + ";database=" + Database + ";");
                conn.Open();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                status_label.Text = "Disconnected";
                status_label.ForeColor = Color.Red;
                Established_Connection = false;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

            if (Established_Connection)
            {
                status_label.Text = "Connected";
                status_label.ForeColor = Color.Green;
            }

            ipaddress_label.Text = Host;
            dbname_label.Text = Database;
            username_label.Text = Username;
            password_label.Text = "Protected";

            Console.Read();
        }

        // Buttons

        private void NewConnectionButton_Click(object sender, EventArgs e)
        {
            new NewConnectionForm(this);
        }

        private void KunderButton_Click(object sender, EventArgs e)
        {
            if (!Established_Connection)
                new MSGForm("Ingen databas finns tillgänglig. Vänligen uppdatera informationen.", this);
            else
                new ShowKundForm();
        }

        private void LeverantörButton_Click(object sender, EventArgs e)
        {
            if (!Established_Connection)
                new MSGForm("Ingen databas finns tillgänglig. Vänligen uppdatera informationen.", this);
            else
                new ShowLeverantörForm();
        }

        private void ProduktButton_Click(object sender, EventArgs e)
        {
            if (!Established_Connection)
                new MSGForm("Ingen databas finns tillgänglig. Vänligen uppdatera informationen.", this);
            else
                new ShowProduktsForm();
        }

        private void KampanjButton_Click(object sender, EventArgs e)
        {
            if (!Established_Connection)
                new MSGForm("Ingen databas finns tillgänglig. Vänligen uppdatera informationen.", this);

            new ShowKampanjForm();
        }
    }
}
