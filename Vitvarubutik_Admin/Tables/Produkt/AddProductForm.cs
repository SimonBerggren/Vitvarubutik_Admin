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
            LoadCategories();
            ShowDialog(parent);
        }

        public AddProductForm(ShowProduktsForm parent, int id, string Tillverkare, string Modell, string Typ, string Energiklass,
                                                       string Beskrivning, int Pris, string Bild_Länk, int Antal, string Leverantör, int Inköpspris)
        {
            altering = true;

            this.parent = parent;
            this.id = id;

            InitializeComponent();
            AddButton.Text = "Spara";

            LoadCategories();
            Kategori.SelectedIndex = Kategori.FindStringExact(Typ);
            
            LoadImage();

            TillverkareTextBox.Text = Tillverkare;
            ModelTextBox.Text = Modell;
            EnergiTextBox.Text = Energiklass;
            BeskrivningTextBox.Text = Beskrivning;
            PrisTextBox.Text = Pris.ToString();
            ImageTextBox.Text = Bild_Länk;
            AntalTextBox.Text = Antal.ToString();
            LeverantörTextBox.Text = Leverantör;
            InköpsTextBox.Text = Inköpspris.ToString();

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
                    "VALUES ('" + TillverkareTextBox.Text + "', '" + ModelTextBox.Text + "', '" + Kategori.Text +
                    "', '" + EnergiTextBox.Text + "', '" + BeskrivningTextBox.Text + "', " + pris + ", '" + ImageTextBox.Text +
                    "', " + AntalTextBox.Text + ", '" + LeverantörTextBox.Text + "', " + InköpsTextBox.Text + ");");
            }
            else
            {
                reader = Main.RunQuery("UPDATE Produkt " +
                    "SET Tillverkare='" + TillverkareTextBox.Text + "', Modell='" + ModelTextBox.Text + "', Typ='" + Kategori.Text + "', Energiklass='" +
                    EnergiTextBox.Text + "', Beskrivning='" + BeskrivningTextBox.Text + "', Pris=" + PrisTextBox.Text + ", Bild_Länk='" + ImageTextBox.Text + "', " +
                    "Lagerantal=" + AntalTextBox.Text + ", Leverantör='" + LeverantörTextBox.Text + "', Inköpspris=" + InköpsTextBox.Text + " " +
                    "WHERE Artikelnummer=" + id + ";");
            }

            if (reader == null) return;

            parent.UpdateProducts();
            parent.UpdateCategoryList();

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

        private void Kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Kategori.SelectedIndex == Kategori.Items.Count - 1)
                Kategori.DropDownStyle = ComboBoxStyle.Simple;
        }

        // If kategoritextbox has focus and you press exit, reset to dropdown

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape && Kategori.Focused)
            {
                Kategori.DropDownStyle = ComboBoxStyle.DropDownList;
                Kategori.SelectedIndex = 0;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void LoadCategories()
        {
            MySqlDataReader reader = Main.RunQuery("SELECT Typ FROM Produkt GROUP BY Typ");
            if (reader == null) return;

            Kategori.Items.Clear();

            if(!altering)
            Kategori.Items.Add("Kategori");

            while (reader.Read())
            {
                Kategori.Items.Add(reader.GetString(0));
            }
            Kategori.Items.Add("Lägg till...");
            Kategori.SelectedIndex = 0;

            reader.Close();
            Main.CloseConnection();
        }

        private void Kategori_Leave(object sender, EventArgs e)
        {
            if (Kategori.SelectedIndex < 0) return;

            if (Kategori.Items[Kategori.SelectedIndex].ToString() == "Lägg till...")
            {
                Kategori.DropDownStyle = ComboBoxStyle.DropDownList;
                Kategori.SelectedIndex = 0;
            }
        }
    }
}
