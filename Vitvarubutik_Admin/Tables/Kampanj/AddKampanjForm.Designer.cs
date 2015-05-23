using System.Windows.Forms;
namespace Vitvarubutik_Admin.Tables.Kampanj
{
    partial class AddKampanjForm
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
            this.Date_FROM = new System.Windows.Forms.DateTimePicker();
            this.Label_FROM = new System.Windows.Forms.Label();
            this.Label_TO = new System.Windows.Forms.Label();
            this.Date_TO = new System.Windows.Forms.DateTimePicker();
            this.Button = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // Box_Name
            // 
            this.Box_Name.Location = new System.Drawing.Point(12, 12);
            this.Box_Name.Name = "Box_Name";
            this.Box_Name.Size = new System.Drawing.Size(260, 20);
            this.Box_Name.TabIndex = 0;
            this.Box_Name.Text = "Namn";
            // 
            // Date_FROM
            // 
            this.Date_FROM.Location = new System.Drawing.Point(12, 64);
            this.Date_FROM.Name = "Date_FROM";
            this.Date_FROM.Size = new System.Drawing.Size(200, 20);
            this.Date_FROM.TabIndex = 1;
            this.Date_FROM.Format = DateTimePickerFormat.Long;
            // 
            // Label_FROM
            // 
            this.Label_FROM.AutoSize = true;
            this.Label_FROM.Location = new System.Drawing.Point(12, 48);
            this.Label_FROM.Name = "Label_FROM";
            this.Label_FROM.Size = new System.Drawing.Size(28, 13);
            this.Label_FROM.TabIndex = 2;
            this.Label_FROM.Text = "Från";
            // 
            // Label_TO
            // 
            this.Label_TO.AutoSize = true;
            this.Label_TO.Location = new System.Drawing.Point(12, 104);
            this.Label_TO.Name = "Label_TO";
            this.Label_TO.Size = new System.Drawing.Size(20, 13);
            this.Label_TO.TabIndex = 3;
            this.Label_TO.Text = "Till";
            // 
            // Date_TO
            // 
            this.Date_TO.Location = new System.Drawing.Point(12, 120);
            this.Date_TO.Name = "Date_TO";
            this.Date_TO.Size = new System.Drawing.Size(200, 20);
            this.Date_TO.TabIndex = 4;
            this.Date_TO.Format = DateTimePickerFormat.Long;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(12, 159);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(260, 31);
            this.Button.TabIndex = 5;
            this.Button.Text = "Lägg till";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // AddKampanjForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 195);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.Date_TO);
            this.Controls.Add(this.Label_TO);
            this.Controls.Add(this.Label_FROM);
            this.Controls.Add(this.Date_FROM);
            this.Controls.Add(this.Box_Name);
            this.Name = "AddKampanjForm";
            this.Text = "AddKampanjForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Box_Name;
        private System.Windows.Forms.DateTimePicker Date_FROM;
        private System.Windows.Forms.Label Label_FROM;
        private System.Windows.Forms.Label Label_TO;
        private System.Windows.Forms.DateTimePicker Date_TO;
        private System.Windows.Forms.Button Button;
    }
}