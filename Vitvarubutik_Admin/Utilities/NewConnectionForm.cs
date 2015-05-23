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

namespace Vitvarubutik_Admin.Utilities
{
    public partial class NewConnectionForm : FixedForm
    {
        Main main;

        public NewConnectionForm(Main main)
        {
            this.main = main;

            InitializeComponent();

            HostTextBox.Text = Main.Host;
            DatabaseTextBox.Text = Main.Database;
            UsernameTextBox.Text = Main.Username;
            PasswordTextbox.Text = Main.Password;

            ShowDialog(main);
        }

        private void TryConnection()
        {
            Main.Host = HostTextBox.Text;
            Main.Database = DatabaseTextBox.Text;
            Main.Username = UsernameTextBox.Text;
            Main.Password = PasswordTextbox.Text;

            main.Establish_Connection();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            TryConnection();

            Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
