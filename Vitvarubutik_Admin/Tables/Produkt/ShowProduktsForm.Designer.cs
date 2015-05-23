namespace Vitvarubutik_Admin.Tables.Produkt
{
    partial class ShowProduktsForm
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RedigeraButton = new System.Windows.Forms.Button();
            this.NewProductButton = new System.Windows.Forms.Button();
            this.listProducts = new System.Windows.Forms.ListBox();
            this.dropList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(12, 88);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(135, 32);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Ta bort";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RedigeraButton
            // 
            this.RedigeraButton.Location = new System.Drawing.Point(13, 50);
            this.RedigeraButton.Name = "RedigeraButton";
            this.RedigeraButton.Size = new System.Drawing.Size(135, 32);
            this.RedigeraButton.TabIndex = 6;
            this.RedigeraButton.Text = "Redigera";
            this.RedigeraButton.UseVisualStyleBackColor = true;
            this.RedigeraButton.Click += new System.EventHandler(this.RedigeraButton_Click);
            // 
            // NewProductButton
            // 
            this.NewProductButton.Location = new System.Drawing.Point(13, 12);
            this.NewProductButton.Name = "NewProductButton";
            this.NewProductButton.Size = new System.Drawing.Size(135, 32);
            this.NewProductButton.TabIndex = 5;
            this.NewProductButton.Text = "Lägg till";
            this.NewProductButton.UseVisualStyleBackColor = true;
            this.NewProductButton.Click += new System.EventHandler(this.NewProductButton_Click);
            // 
            // listProducts
            // 
            this.listProducts.FormattingEnabled = true;
            this.listProducts.HorizontalScrollbar = this.Enabled;
            this.listProducts.Location = new System.Drawing.Point(154, 12);
            this.listProducts.Name = "listProducts";
            this.listProducts.Size = new System.Drawing.Size(596, 251);
            this.listProducts.TabIndex = 4;
            // 
            // dropList
            // 
            this.dropList.AccessibleName = "DropDownMenu";
            this.dropList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropList.FormattingEnabled = true;
            this.dropList.Location = new System.Drawing.Point(13, 126);
            this.dropList.Name = "dropList";
            this.dropList.Size = new System.Drawing.Size(134, 21);
            this.dropList.TabIndex = 8;
            // 
            // ShowProduktsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 270);
            this.Controls.Add(this.dropList);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.RedigeraButton);
            this.Controls.Add(this.NewProductButton);
            this.Controls.Add(this.listProducts);
            this.Name = "ShowProduktsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button RedigeraButton;
        private System.Windows.Forms.Button NewProductButton;
        private System.Windows.Forms.ListBox listProducts;
        private System.Windows.Forms.ComboBox dropList;
    }
}