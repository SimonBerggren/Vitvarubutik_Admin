namespace Vitvarubutik_Admin.Tables.Produkt
{
    partial class ConnectProductForm
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
            this.SelectFilterList = new System.Windows.Forms.CheckedListBox();
            this.SelectCategoryList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RemoveGroupButton = new System.Windows.Forms.Button();
            this.AddGroupButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AllProductList = new System.Windows.Forms.ListBox();
            this.ProductList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SelectFilterList
            // 
            this.SelectFilterList.CheckOnClick = true;
            this.SelectFilterList.FormattingEnabled = true;
            this.SelectFilterList.Location = new System.Drawing.Point(215, 293);
            this.SelectFilterList.Name = "SelectFilterList";
            this.SelectFilterList.Size = new System.Drawing.Size(121, 94);
            this.SelectFilterList.TabIndex = 10;
            this.SelectFilterList.Visible = false;
            this.SelectFilterList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SelectFilterList_Click);
            // 
            // SelectCategoryList
            // 
            this.SelectCategoryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectCategoryList.FormattingEnabled = true;
            this.SelectCategoryList.Items.AddRange(new object[] {
            "Filtrera efter....",
            "Tillverkare",
            "Typ",
            "Energiklass",
            "Pris"});
            this.SelectCategoryList.Location = new System.Drawing.Point(215, 266);
            this.SelectCategoryList.Name = "SelectCategoryList";
            this.SelectCategoryList.Size = new System.Drawing.Size(121, 21);
            this.SelectCategoryList.TabIndex = 9;
            this.SelectCategoryList.SelectedIndexChanged += new System.EventHandler(this.SelectCategoryList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Lägg till och ta bort kategorier";
            // 
            // AddGroupButton
            // 
            this.AddGroupButton.Location = new System.Drawing.Point(293, 393);
            this.AddGroupButton.Name = "AddGroupButton";
            this.AddGroupButton.Size = new System.Drawing.Size(43, 23);
            this.AddGroupButton.TabIndex = 6;
            this.AddGroupButton.Text = ">>>>";
            this.AddGroupButton.UseVisualStyleBackColor = true;
            this.AddGroupButton.Click += new System.EventHandler(this.AddGroupButton_Click);
            // 
            // RemoveGroupButton
            // 
            this.RemoveGroupButton.Location = new System.Drawing.Point(215, 393);
            this.RemoveGroupButton.Name = "RemoveGroupButton";
            this.RemoveGroupButton.Size = new System.Drawing.Size(43, 23);
            this.RemoveGroupButton.TabIndex = 7;
            this.RemoveGroupButton.Text = "<<<<";
            this.RemoveGroupButton.UseVisualStyleBackColor = true;
            this.RemoveGroupButton.Click += new System.EventHandler(this.RemoveGroupButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(252, 144);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(43, 23);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "<<";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(252, 115);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(43, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = ">>";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Alla produkter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kopplade produkter";
            // 
            // AllProductList
            // 
            this.AllProductList.FormattingEnabled = true;
            this.AllProductList.Location = new System.Drawing.Point(12, 35);
            this.AllProductList.Name = "AllProductList";
            this.AllProductList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.AllProductList.Size = new System.Drawing.Size(218, 212);
            this.AllProductList.TabIndex = 1;
            // 
            // ProductList
            // 
            this.ProductList.FormattingEnabled = true;
            this.ProductList.Location = new System.Drawing.Point(316, 35);
            this.ProductList.Name = "ProductList";
            this.ProductList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ProductList.Size = new System.Drawing.Size(218, 212);
            this.ProductList.TabIndex = 0;
            // 
            // ConnectProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 433);
            this.Controls.Add(this.SelectFilterList);
            this.Controls.Add(this.SelectCategoryList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RemoveGroupButton);
            this.Controls.Add(this.AddGroupButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllProductList);
            this.Controls.Add(this.ProductList);
            this.Name = "ConnectProductForm";
            this.Text = "ConnectProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox SelectFilterList;
        private System.Windows.Forms.ComboBox SelectCategoryList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RemoveGroupButton;
        private System.Windows.Forms.Button AddGroupButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox AllProductList;
        private System.Windows.Forms.ListBox ProductList;

    }
}