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
    public partial class AddLeverantörForm : FixedForm
    {
        ShowLeverantörForm parent;
        bool altering;
        string id;

        public AddLeverantörForm(ShowLeverantörForm parent)
        {
            this.parent = parent;
            InitializeComponent();
            ShowDialog(parent);
        }

        public AddLeverantörForm(ShowLeverantörForm parent, string Namn, string Telefonnummer, string Email, string Faktureringsadress)
        {
            this.parent = parent;
            this.id = Namn;
            InitializeComponent();

            Box_Name.Text = Namn;
            Box_Phone.Text = Telefonnummer;
            Box_Mail.Text = Email;
            Box_Adress.Text = Faktureringsadress;

            AddButton.Text = "Spara";
            altering = true;

            ShowDialog(parent);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Box_Name.Text == "")
                return;

            MySqlDataReader reader;

            if (altering)
            {
                reader = Main.RunQuery("UPDATE Leverantör "
                        + "SET Namn = '" + Box_Name.Text + "', Telefonnummer = '" + Box_Phone.Text + "', Email = '" + Box_Mail.Text + "', Faktureringsadress = '" + Box_Adress.Text + "'"
                        + " WHERE Namn = '" + id + "'");
            }
            else
            {
                reader = Main.RunQuery("INSERT INTO Leverantör VALUES ('"
                    + Box_Name.Text + "', '" + Box_Phone.Text + "', '" + Box_Mail.Text + "', '" + Box_Adress.Text + "')");
            }

            if (reader == null) return;

            reader.Close();
            Main.CloseConnection();

            parent.UpdateItemList();
            Close();
        }
    }
}
