namespace Vitvarubutik_Admin.Tables.Kund
{
    partial class ShowKundForm
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
            this.RemoveKundButton = new System.Windows.Forms.Button();
            this.EditKundButton = new System.Windows.Forms.Button();
            this.AddKundButton = new System.Windows.Forms.Button();
            this.listCustomers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RemoveKundButton
            // 
            this.RemoveKundButton.Location = new System.Drawing.Point(8, 88);
            this.RemoveKundButton.Name = "RemoveKundButton";
            this.RemoveKundButton.Size = new System.Drawing.Size(135, 32);
            this.RemoveKundButton.TabIndex = 14;
            this.RemoveKundButton.Text = "Ta bort";
            this.RemoveKundButton.UseVisualStyleBackColor = true;
            this.RemoveKundButton.Click += new System.EventHandler(this.RemoveKundButton_Click);
            // 
            // EditKundButton
            // 
            this.EditKundButton.Location = new System.Drawing.Point(8, 50);
            this.EditKundButton.Name = "EditKundButton";
            this.EditKundButton.Size = new System.Drawing.Size(135, 32);
            this.EditKundButton.TabIndex = 13;
            this.EditKundButton.Text = "Redigera";
            this.EditKundButton.UseVisualStyleBackColor = true;
            this.EditKundButton.Click += new System.EventHandler(this.EditKundButton_Click);
            // 
            // AddKundButton
            // 
            this.AddKundButton.Location = new System.Drawing.Point(8, 12);
            this.AddKundButton.Name = "AddKundButton";
            this.AddKundButton.Size = new System.Drawing.Size(135, 32);
            this.AddKundButton.TabIndex = 12;
            this.AddKundButton.Text = "Lägg till";
            this.AddKundButton.UseVisualStyleBackColor = true;
            this.AddKundButton.Click += new System.EventHandler(this.AddKundButton_Click);
            // 
            // listCustomers
            // 
            this.listCustomers.FormattingEnabled = true;
            this.listCustomers.Location = new System.Drawing.Point(149, 12);
            this.listCustomers.Name = "listCustomers";
            this.listCustomers.Size = new System.Drawing.Size(596, 251);
            this.listCustomers.TabIndex = 11;
            // 
            // ShowKundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 273);
            this.Controls.Add(this.RemoveKundButton);
            this.Controls.Add(this.EditKundButton);
            this.Controls.Add(this.AddKundButton);
            this.Controls.Add(this.listCustomers);
            this.Name = "ShowKundForm";
            this.Text = "Kunder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RemoveKundButton;
        private System.Windows.Forms.Button EditKundButton;
        private System.Windows.Forms.Button AddKundButton;
        private System.Windows.Forms.ListBox listCustomers;

    }
}