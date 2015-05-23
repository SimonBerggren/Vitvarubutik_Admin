namespace Vitvarubutik_Admin.Tables.Kund
{
    partial class AddKundForm
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
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.Box_Name = new System.Windows.Forms.TextBox();
            this.Box_Phone = new System.Windows.Forms.TextBox();
            this.Box_Mail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(13, 127);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(259, 47);
            this.AddCustomerButton.TabIndex = 0;
            this.AddCustomerButton.Text = "Lägg till";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // Box_Name
            // 
            this.Box_Name.Location = new System.Drawing.Point(12, 12);
            this.Box_Name.Name = "Box_Name";
            this.Box_Name.Size = new System.Drawing.Size(260, 20);
            this.Box_Name.TabIndex = 1;
            this.Box_Name.Text = "Namn";
            // 
            // Box_Phone
            // 
            this.Box_Phone.Location = new System.Drawing.Point(13, 38);
            this.Box_Phone.Name = "Box_Phone";
            this.Box_Phone.Size = new System.Drawing.Size(259, 20);
            this.Box_Phone.TabIndex = 2;
            this.Box_Phone.Text = "Telefonnummer";
            // 
            // Box_Mail
            // 
            this.Box_Mail.Location = new System.Drawing.Point(12, 64);
            this.Box_Mail.Name = "Box_Mail";
            this.Box_Mail.Size = new System.Drawing.Size(260, 20);
            this.Box_Mail.TabIndex = 4;
            this.Box_Mail.Text = "Email";
            // 
            // AddKundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.Box_Mail);
            this.Controls.Add(this.Box_Phone);
            this.Controls.Add(this.Box_Name);
            this.Controls.Add(this.AddCustomerButton);
            this.Name = "AddKundForm";
            this.Text = "Ny Kund";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.TextBox Box_Name;
        private System.Windows.Forms.TextBox Box_Phone;
        private System.Windows.Forms.TextBox Box_Mail;
    }
}