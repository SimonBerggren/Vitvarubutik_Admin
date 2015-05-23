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
            this.ImageTextBox = new System.Windows.Forms.TextBox();
            this.AntalTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.PrisTextBox = new System.Windows.Forms.TextBox();
            this.BeskrivningTextBox = new System.Windows.Forms.RichTextBox();
            this.EnergiTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.TillverkareTextBox = new System.Windows.Forms.TextBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageTextBox
            // 
            this.ImageTextBox.Location = new System.Drawing.Point(587, 187);
            this.ImageTextBox.Name = "ImageTextBox";
            this.ImageTextBox.Size = new System.Drawing.Size(206, 20);
            this.ImageTextBox.TabIndex = 5;
            this.ImageTextBox.Text = "Bild Länk";
            this.ImageTextBox.TextChanged += new System.EventHandler(this.ImageTextBox_TextChanged);
            // 
            // AntalTextBox
            // 
            this.AntalTextBox.Location = new System.Drawing.Point(12, 138);
            this.AntalTextBox.Name = "AntalTextBox";
            this.AntalTextBox.Size = new System.Drawing.Size(129, 20);
            this.AntalTextBox.TabIndex = 8;
            this.AntalTextBox.Text = "Antal";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(12, 164);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(129, 42);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Lägg till";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PrisTextBox
            // 
            this.PrisTextBox.Location = new System.Drawing.Point(12, 68);
            this.PrisTextBox.Name = "PrisTextBox";
            this.PrisTextBox.Size = new System.Drawing.Size(100, 20);
            this.PrisTextBox.TabIndex = 6;
            this.PrisTextBox.Text = "Pris";
            // 
            // BeskrivningTextBox
            // 
            this.BeskrivningTextBox.Location = new System.Drawing.Point(236, 16);
            this.BeskrivningTextBox.Name = "BeskrivningTextBox";
            this.BeskrivningTextBox.Size = new System.Drawing.Size(345, 190);
            this.BeskrivningTextBox.TabIndex = 7;
            this.BeskrivningTextBox.Text = "Beskrivning";
            // 
            // EnergiTextBox
            // 
            this.EnergiTextBox.Location = new System.Drawing.Point(118, 42);
            this.EnergiTextBox.Name = "EnergiTextBox";
            this.EnergiTextBox.Size = new System.Drawing.Size(100, 20);
            this.EnergiTextBox.TabIndex = 4;
            this.EnergiTextBox.Text = "Energiklass";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(118, 16);
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
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(12, 42);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.TypeTextBox.TabIndex = 3;
            this.TypeTextBox.Text = "Produkt Typ";
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(587, 16);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(206, 165);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 10;
            this.PictureBox.TabStop = false;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 213);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.ImageTextBox);
            this.Controls.Add(this.AntalTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PrisTextBox);
            this.Controls.Add(this.BeskrivningTextBox);
            this.Controls.Add(this.EnergiTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.TillverkareTextBox);
            this.Controls.Add(this.TypeTextBox);
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
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.PictureBox PictureBox;
    }
}