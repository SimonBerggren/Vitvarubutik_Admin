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
            this.CategoryList = new System.Windows.Forms.CheckedListBox();
            this.RemoveCategoryButton = new System.Windows.Forms.Button();
            this.ViewBox = new System.Windows.Forms.ComboBox();
            this.ConnectProductButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(12, 170);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(135, 32);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Ta bort produkt";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RedigeraButton
            // 
            this.RedigeraButton.Location = new System.Drawing.Point(12, 94);
            this.RedigeraButton.Name = "RedigeraButton";
            this.RedigeraButton.Size = new System.Drawing.Size(135, 32);
            this.RedigeraButton.TabIndex = 6;
            this.RedigeraButton.Text = "Redigera";
            this.RedigeraButton.UseVisualStyleBackColor = true;
            this.RedigeraButton.Click += new System.EventHandler(this.RedigeraButton_Click);
            // 
            // NewProductButton
            // 
            this.NewProductButton.Location = new System.Drawing.Point(13, 56);
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
            this.listProducts.Size = new System.Drawing.Size(596, 329);
            this.listProducts.TabIndex = 4;
            // 
            // CategoryList
            // 
            this.CategoryList.CheckOnClick = true;
            this.CategoryList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CategoryList.Location = new System.Drawing.Point(13, 246);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(135, 94);
            this.CategoryList.Sorted = true;
            this.CategoryList.TabIndex = 8;
            this.CategoryList.ThreeDCheckBoxes = true;
            this.CategoryList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CategoryList_Click);
            // 
            // RemoveCategoryButton
            // 
            this.RemoveCategoryButton.Enabled = false;
            this.RemoveCategoryButton.Location = new System.Drawing.Point(12, 208);
            this.RemoveCategoryButton.Name = "RemoveCategoryButton";
            this.RemoveCategoryButton.Size = new System.Drawing.Size(135, 32);
            this.RemoveCategoryButton.TabIndex = 9;
            this.RemoveCategoryButton.Text = "Ta bort kategori";
            this.RemoveCategoryButton.UseVisualStyleBackColor = true;
            this.RemoveCategoryButton.Click += new System.EventHandler(this.RemoveCategory_Click);
            // 
            // ViewBox
            // 
            this.ViewBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ViewBox.FormattingEnabled = true;
            this.ViewBox.Items.AddRange(new object[] {
            "Alla produkter",
            "Få produkter"});
            this.ViewBox.Location = new System.Drawing.Point(13, 12);
            this.ViewBox.Name = "ViewBox";
            this.ViewBox.Size = new System.Drawing.Size(134, 21);
            this.ViewBox.TabIndex = 10;
            this.ViewBox.SelectedIndexChanged += new System.EventHandler(this.ViewBox_SelectedIndexChanged);
            // 
            // ConnectProductButton
            // 
            this.ConnectProductButton.Location = new System.Drawing.Point(13, 132);
            this.ConnectProductButton.Name = "ConnectProductButton";
            this.ConnectProductButton.Size = new System.Drawing.Size(135, 32);
            this.ConnectProductButton.TabIndex = 11;
            this.ConnectProductButton.Text = "Koppla Produkter";
            this.ConnectProductButton.UseVisualStyleBackColor = true;
            this.ConnectProductButton.Click += new System.EventHandler(this.ConnectProductButton_Click);
            // 
            // ShowProduktsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 351);
            this.Controls.Add(this.ConnectProductButton);
            this.Controls.Add(this.ViewBox);
            this.Controls.Add(this.RemoveCategoryButton);
            this.Controls.Add(this.CategoryList);
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
        private System.Windows.Forms.CheckedListBox CategoryList;
        private System.Windows.Forms.Button RemoveCategoryButton;
        private System.Windows.Forms.ComboBox ViewBox;
        private System.Windows.Forms.Button ConnectProductButton;
    }
}