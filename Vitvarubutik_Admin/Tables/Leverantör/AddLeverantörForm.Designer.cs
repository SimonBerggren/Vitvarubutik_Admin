namespace Vitvarubutik_Admin.Tables.Leverantör
{
    partial class AddLeverantörForm
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
            this.Box_Name = new System.Windows.Forms.TextBox();
            this.Box_Phone = new System.Windows.Forms.TextBox();
            this.Box_Mail = new System.Windows.Forms.TextBox();
            this.Box_Adress = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Box_Name
            // 
            this.Box_Name.Location = new System.Drawing.Point(12, 12);
            this.Box_Name.Name = "Box_Name";
            this.Box_Name.Size = new System.Drawing.Size(260, 20);
            this.Box_Name.TabIndex = 0;
            this.Box_Name.Text = "Leverantör";
            // 
            // Box_Phone
            // 
            this.Box_Phone.Location = new System.Drawing.Point(12, 38);
            this.Box_Phone.Name = "Box_Phone";
            this.Box_Phone.Size = new System.Drawing.Size(260, 20);
            this.Box_Phone.TabIndex = 1;
            this.Box_Phone.Text = "Telefonnummer";
            // 
            // Box_Mail
            // 
            this.Box_Mail.Location = new System.Drawing.Point(12, 64);
            this.Box_Mail.Name = "Box_Mail";
            this.Box_Mail.Size = new System.Drawing.Size(260, 20);
            this.Box_Mail.TabIndex = 2;
            this.Box_Mail.Text = "Email";
            // 
            // Box_Adress
            // 
            this.Box_Adress.Location = new System.Drawing.Point(12, 90);
            this.Box_Adress.Name = "Box_Adress";
            this.Box_Adress.Size = new System.Drawing.Size(260, 20);
            this.Box_Adress.TabIndex = 3;
            this.Box_Adress.Text = "Faktureringsadress";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 116);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(260, 52);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Lägg till";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddLeverantörForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Box_Adress);
            this.Controls.Add(this.Box_Mail);
            this.Controls.Add(this.Box_Phone);
            this.Controls.Add(this.Box_Name);
            this.Name = "AddLeverantörForm";
            this.Text = "AddLeverantörForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Box_Name;
        private System.Windows.Forms.TextBox Box_Phone;
        private System.Windows.Forms.TextBox Box_Mail;
        private System.Windows.Forms.TextBox Box_Adress;
        private System.Windows.Forms.Button AddButton;
    }
}