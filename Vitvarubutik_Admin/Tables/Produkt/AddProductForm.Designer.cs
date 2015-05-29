namespace Vitvarubutik_Admin.Tables.Produkt
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Kategori = new System.Windows.Forms.ComboBox();
            this.InköpsTextBox = new System.Windows.Forms.TextBox();
            this.LeverantörTextBox = new System.Windows.Forms.TextBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.ImageTextBox = new System.Windows.Forms.TextBox();
            this.AntalTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.PrisTextBox = new System.Windows.Forms.TextBox();
            this.BeskrivningTextBox = new System.Windows.Forms.RichTextBox();
            this.EnergiTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.TillverkareTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Kategori
            // 
            this.Kategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Kategori.FormattingEnabled = true;
            this.Kategori.Location = new System.Drawing.Point(12, 68);
            this.Kategori.Name = "Kategori";
            this.Kategori.Size = new System.Drawing.Size(100, 21);
            this.Kategori.TabIndex = 3;
            this.Kategori.SelectedIndexChanged += new System.EventHandler(this.Kategori_SelectedIndexChanged);
            this.Kategori.Leave += new System.EventHandler(this.Kategori_Leave);
            // 
            // InköpsTextBox
            // 
            this.InköpsTextBox.Location = new System.Drawing.Point(634, 38);
            this.InköpsTextBox.Name = "InköpsTextBox";
            this.InköpsTextBox.Size = new System.Drawing.Size(100, 20);
            this.InköpsTextBox.TabIndex = 9;
            this.InköpsTextBox.Text = "Inköpspris";
            // 
            // LeverantörTextBox
            // 
            this.LeverantörTextBox.Location = new System.Drawing.Point(634, 12);
            this.LeverantörTextBox.Name = "LeverantörTextBox";
            this.LeverantörTextBox.Size = new System.Drawing.Size(100, 20);
            this.LeverantörTextBox.TabIndex = 8;
            this.LeverantörTextBox.Text = "Leverantör";
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(469, 16);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(159, 98);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 10;
            this.PictureBox.TabStop = false;
            // 
            // ImageTextBox
            // 
            this.ImageTextBox.Location = new System.Drawing.Point(470, 120);
            this.ImageTextBox.Name = "ImageTextBox";
            this.ImageTextBox.Size = new System.Drawing.Size(159, 20);
            this.ImageTextBox.TabIndex = 7;
            this.ImageTextBox.Text = "Bild Länk";
            this.ImageTextBox.TextChanged += new System.EventHandler(this.ImageTextBox_TextChanged);
            // 
            // AntalTextBox
            // 
            this.AntalTextBox.Location = new System.Drawing.Point(634, 64);
            this.AntalTextBox.Name = "AntalTextBox";
            this.AntalTextBox.Size = new System.Drawing.Size(100, 20);
            this.AntalTextBox.TabIndex = 10;
            this.AntalTextBox.Text = "Antal";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(634, 90);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 50);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Lägg till";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PrisTextBox
            // 
            this.PrisTextBox.Location = new System.Drawing.Point(12, 120);
            this.PrisTextBox.Name = "PrisTextBox";
            this.PrisTextBox.Size = new System.Drawing.Size(100, 20);
            this.PrisTextBox.TabIndex = 5;
            this.PrisTextBox.Text = "Pris";
            // 
            // BeskrivningTextBox
            // 
            this.BeskrivningTextBox.Location = new System.Drawing.Point(118, 16);
            this.BeskrivningTextBox.Name = "BeskrivningTextBox";
            this.BeskrivningTextBox.Size = new System.Drawing.Size(345, 124);
            this.BeskrivningTextBox.TabIndex = 6;
            this.BeskrivningTextBox.Text = "Beskrivning";
            // 
            // EnergiTextBox
            // 
            this.EnergiTextBox.Location = new System.Drawing.Point(12, 94);
            this.EnergiTextBox.MaxLength = 5;
            this.EnergiTextBox.Name = "EnergiTextBox";
            this.EnergiTextBox.Size = new System.Drawing.Size(100, 20);
            this.EnergiTextBox.TabIndex = 4;
            this.EnergiTextBox.Text = "Energiklass";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(12, 42);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(100, 20);
            this.ModelTextBox.TabIndex = 2;
            this.ModelTextBox.Text = "Model";
            // 
            // TillverkareTextBox
            // 
            this.TillverkareTextBox.Location = new System.Drawing.Point(12, 16);
            this.TillverkareTextBox.Name = "TillverkareTextBox";
            this.TillverkareTextBox.Size = new System.Drawing.Size(100, 20);
            this.TillverkareTextBox.TabIndex = 1;
            this.TillverkareTextBox.Text = "Tillverkare";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 151);
            this.Controls.Add(this.Kategori);
            this.Controls.Add(this.InköpsTextBox);
            this.Controls.Add(this.LeverantörTextBox);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.ImageTextBox);
            this.Controls.Add(this.AntalTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PrisTextBox);
            this.Controls.Add(this.BeskrivningTextBox);
            this.Controls.Add(this.EnergiTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.TillverkareTextBox);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ImageTextBox;
        private System.Windows.Forms.TextBox AntalTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox PrisTextBox;
        private System.Windows.Forms.RichTextBox BeskrivningTextBox;
        private System.Windows.Forms.TextBox EnergiTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox TillverkareTextBox;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TextBox LeverantörTextBox;
        private System.Windows.Forms.TextBox InköpsTextBox;
        private System.Windows.Forms.ComboBox Kategori;
    }
}