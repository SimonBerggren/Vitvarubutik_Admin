namespace Vitvarubutik_Admin.Tables.Kampanj
{
    partial class ProductToKampanjForm
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
            this.ProductList = new System.Windows.Forms.ListBox();
            this.AllProductList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductList
            // 
            this.ProductList.FormattingEnabled = true;
            this.ProductList.Location = new System.Drawing.Point(12, 55);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(218, 212);
            this.ProductList.TabIndex = 0;
            // 
            // AllProductList
            // 
            this.AllProductList.FormattingEnabled = true;
            this.AllProductList.Location = new System.Drawing.Point(316, 55);
            this.AllProductList.Name = "AllProductList";
            this.AllProductList.Size = new System.Drawing.Size(218, 212);
            this.AllProductList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Produkter i kampanj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alla produkter";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(252, 68);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(43, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "<<";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(252, 97);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(43, 23);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = ">>";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ProductToKampanjForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 279);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllProductList);
            this.Controls.Add(this.ProductList);
            this.Name = "ProductToKampanjForm";
            this.Text = "ProductToKampanjForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProductList;
        private System.Windows.Forms.ListBox AllProductList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
    }
}