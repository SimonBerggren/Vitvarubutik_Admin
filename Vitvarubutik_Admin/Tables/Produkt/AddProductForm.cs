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

        public AddProductForm(ShowProduktsForm parent, int id, string Tillverkare, string Modell, string Typ, string Energiklass,
                                                       string Beskrivning, int Pris, string Bild_Länk, int Antal, string Leverantör, int Inköpspris)
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
            LeverantörTextBox.Text = Leverantör;
            InköpsTextBox.Text = Inköpspris.ToString();

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

            MySqlDataReader reader;

            if (!altering)
            {
                reader = Main.RunQuery("INSERT INTO Produkt (Tillverkare, Modell, Typ, Energiklass, Beskrivning, Pris, Bild_Länk, Lagerantal, Leverantör, Inköpspris) " +
                    "VALUES ('" + TillverkareTextBox.Text + "', '" + ModelTextBox.Text + "', '" + TypeTextBox.Text +
                    "', '" + EnergiTextBox.Text + "', '" + BeskrivningTextBox.Text + "', " + pris + ", '" + ImageTextBox.Text +
                    "', " + AntalTextBox.Text + ", '" + LeverantörTextBox.Text + "', " + InköpsTextBox.Text + ");");
            }
            else
            {
                reader = Main.RunQuery("UPDATE Produkt " +
                    "SET Tillverkare='" + TillverkareTextBox.Text + "', Modell='" + ModelTextBox.Text + "', Typ='" + TypeTextBox.Text + "', Energiklass='" +
                    EnergiTextBox.Text + "', Beskrivning='" + BeskrivningTextBox.Text + "', Pris=" + PrisTextBox.Text + ", Bild_Länk='" + ImageTextBox.Text + "', " +
                    "Lagerantal=" + AntalTextBox.Text + ", Leverantör='" + LeverantörTextBox.Text + "', Inköpspris=" + InköpsTextBox.Text + " " +
                    "WHERE Artikelnummer=" + id + ";");
            }

            if (reader == null) return;

            parent.UpdateItemList();

            reader.Close();
            Main.CloseConnection();

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
