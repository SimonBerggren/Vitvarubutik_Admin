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

namespace Vitvarubutik_Admin.Tables.Produkt
{
    public partial class AddProductForm : FixedForm
    {
        ShowProduktsForm parent;
        bool altering;
        int id;

        public AddProductForm(ShowProduktsForm parent)
        {
            this.parent = parent;
            InitializeComponent();
            ShowDialog(parent);
        }

        public AddProductForm(ShowProduktsForm parent, int id, string Tillverkare, string Modell, string Typ, string Energiklass, int Pris, string Beskrivning, string Bild_Länk, int Antal)
        {
            this.parent = parent;
            this.id = id;
            InitializeComponent();

            TypeTextBox.Text = Typ;
            TillverkareTextBox.Text = Tillverkare;
            ModelTextBox.Text = Modell;
            EnergiTextBox.Text = Energiklass;
            BeskrivningTextBox.Text = Beskrivning;
            PrisTextBox.Text = Pris.ToString();
            ImageTextBox.Text = Bild_Länk;
            AntalTextBox.Text = Antal.ToString();

            AddButton.Text = "Spara";
            altering = true;
            LoadImage();

            ShowDialog(parent);
        }
        private void ImageTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            LoadImage();

            int pris, antal;
            if (!int.TryParse(PrisTextBox.Text, out pris) && !int.TryParse(AntalTextBox.Text, out antal))
                return;

            if (!altering)
            {
                string query = "INSERT INTO Produkt (Typ, Tillverkare, Modell, Energiklass, Beskrivning, Pris, Bild_Länk, Lagerantal) " +
                    "VALUES ('" + this.TypeTextBox.Text + "', '" + this.TillverkareTextBox.Text + "', '" + this.ModelTextBox.Text + "', " +
                    "'" + EnergiTextBox.Text + "', '" + BeskrivningTextBox.Text + "', " + pris + ", '" + this.ImageTextBox.Text + "', " + AntalTextBox.Text + ");";

                Main.RunQuery(query);
            }
            else
            {
                string query = "UPDATE Produkt " +
                    "SET Typ='" + TypeTextBox.Text + "', Tillverkare='" + TillverkareTextBox.Text + "', Modell='" + ModelTextBox.Text + "', Energiklass='" +
                    EnergiTextBox.Text + "', Beskrivning='" + BeskrivningTextBox.Text + "', Pris=" + PrisTextBox.Text + ", Bild_Länk='" + ImageTextBox.Text + "', " +
                    "Lagerantal=" + AntalTextBox.Text + " " +
                    "WHERE Artikelnummer=" + id + ";";
                Main.RunQuery(query);
            }

            parent.UpdateItemList();
            Close();
        }

        private void LoadImage()
        {
            try
            {
                PictureBox.Load(ImageTextBox.Text);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                PictureBox.Load("http://www.hospitalsafetyscore.org/media/image/hss-alert-icon.png");
            }
        }
    }
}
