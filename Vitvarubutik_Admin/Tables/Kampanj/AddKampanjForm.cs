﻿using MySql.Data.MySqlClient;
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

        public AddKampanjForm(ShowKampanjForm parent, int ID, string Namn, string Beskrivning, DateTime StartDatum, DateTime SlutDatum, string Rabatt)
        {
            this.parent = parent;
            this.id = ID;
            altering = true;

            InitializeComponent();

            Box_Name.Text = Namn;
            BeskrivningTextBox.Text = Beskrivning;
            Date_FROM.Value = StartDatum;
            Date_TO.Value = SlutDatum;
            PercentTextBox.Text = Rabatt;

            Button.Text = "Spara";
            ShowDialog(parent);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader;

            if (altering)
            {
                reader = Main.RunQuery("UPDATE Kampanj "
                   + "SET Namn = '" + Box_Name.Text + "', Beskrivning = '" + BeskrivningTextBox.Text + "', StartDatum = " + Date_FROM.Value.ToString("yyyyMMdd") + ", SlutDatum = " + Date_TO.Value.ToString("yyyyMMdd")
                   + ", Rabatt = " + PercentTextBox.Text + " WHERE KampanjID = " + id);
            }
            else
            {
                reader = Main.RunQuery("INSERT INTO Kampanj (Namn, Beskrivning, StartDatum, SlutDatum, Rabatt)"
                   + " VALUES ('" + Box_Name.Text + "', '" + BeskrivningTextBox.Text + "', " + Date_FROM.Value.ToString("yyyyMMdd") + ", " + Date_TO.Value.ToString("yyyyMMdd") + ", " + PercentTextBox.Text + ");");
            }

            reader.Close();
            Main.CloseConnection();

            parent.UpdateItems();
            Close();
        }
    }
}
