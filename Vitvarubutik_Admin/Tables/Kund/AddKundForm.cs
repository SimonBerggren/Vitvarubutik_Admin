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
    public partial class AddKundForm : FixedForm
    {
        private ShowKundForm parent;
        private bool altering;
        private int kundnr;

        public AddKundForm(ShowKundForm parent)
        {
            this.parent = parent;
            InitializeComponent();
            ShowDialog(parent);
        }

        public AddKundForm(ShowKundForm parent, int Kundnummer, string Namn, string Telefonnummer, string Mail)
        {
            this.parent = parent;
            this.kundnr = Kundnummer;
            InitializeComponent();

            Box_Name.Text = Namn;
            Box_Phone.Text = Telefonnummer;
            Box_Mail.Text = Mail;

            AddCustomerButton.Text = "Spara";
            altering = true;

            ShowDialog(parent);
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            if (Box_Name.Text == "")
                return;

            MySqlDataReader reader;

            if (altering)
            {
                 reader =  Main.RunQuery("UPDATE Kund SET "
                    + "Namn = '" + Box_Name.Text + "', Telefonnummer = '" + Box_Phone.Text + "', Email = '" + Box_Mail.Text + "' "
                    + "WHERE Kundnummer = " + kundnr + ";");
            }
            else
            {
                reader = Main.RunQuery("INSERT INTO Kund (Namn, Telefonnummer, Email)"
                    + "VALUES ('" + Box_Name.Text + "', '" + Box_Phone.Text + "', '" + Box_Mail.Text + "');" );
            }

            reader.Close();
            Main.CloseConnection();

            parent.UpdateItemList();
            Close();
        }
    }
}
