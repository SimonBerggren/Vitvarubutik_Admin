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
    public partial class MSGForm : FixedForm
    {
        Form parent;

        public MSGForm(string Message, Form parent)
        {
            this.parent = parent;

            InitializeComponent();

            MSG_Label.AutoSize = false;
            MSG_Label.TextAlign = ContentAlignment.MiddleCenter;
            MSG_Label.Dock = DockStyle.Fill;

            this.MSG_Label.Text = Message;

            this.Height += Button.Height;
            Button.Dock = DockStyle.Bottom;

            ShowDialog(parent);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
