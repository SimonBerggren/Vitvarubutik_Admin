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
    public partial class AddKampanjForm : FixedForm
    {
        ShowKampanjForm parent;
        bool altering;
        int id;

        public AddKampanjForm(ShowKampanjForm parent)
        {
            this.parent = parent;
            InitializeComponent();
            ShowDialog(parent);
        }

        public AddKampanjForm(ShowKampanjForm parent, int ID, string Namn, DateTime StartDatum, DateTime SlutDatum)
        {
            this.parent = parent;
            this.id = ID;
            altering = true;

            InitializeComponent();

            Box_Name.Text = Namn;
            Date_FROM.Value = StartDatum;
            Date_TO.Value = SlutDatum;

            ShowDialog(parent);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader;

            if (altering)
            {
                reader = Main.RunQuery("UPDATE Kampanj "
                   + "SET Namn = '" + Box_Name.Text + "', StartDatum = " + Date_FROM.Value.ToString("yyyyMMdd") + ", SlutDatum = " + Date_TO.Value.ToString("yyyyMMdd")
                   + " WHERE ID = " + id);
            }
            else
            {
                reader = Main.RunQuery("INSERT INTO Kampanj (Namn, StartDatum, SlutDatum)"
                   + " VALUES ('" + Box_Name.Text + "', " + Date_FROM.Value.ToString("yyyyMMdd") + ", " + Date_TO.Value.ToString("yyyyMMdd") + ");");
            }

            reader.Close();
            Main.CloseConnection();

            parent.UpdateItems();
            Close();
        }
    }
}
