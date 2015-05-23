namespace Vitvarubutik_Admin.Tables.Kampanj
{
    partial class ShowKampanjForm
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
            this.RemoveKampanjButton = new System.Windows.Forms.Button();
            this.EditKampanjButton = new System.Windows.Forms.Button();
            this.AddKampanjButton = new System.Windows.Forms.Button();
            this.listKampanj = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RemoveKampanjButton
            // 
            this.RemoveKampanjButton.Location = new System.Drawing.Point(9, 88);
            this.RemoveKampanjButton.Name = "RemoveKampanjButton";
            this.RemoveKampanjButton.Size = new System.Drawing.Size(135, 32);
            this.RemoveKampanjButton.TabIndex = 14;
            this.RemoveKampanjButton.Text = "Ta bort";
            this.RemoveKampanjButton.UseVisualStyleBackColor = true;
            this.RemoveKampanjButton.Click += new System.EventHandler(this.RemoveKampanjButton_Click);
            // 
            // EditKampanjButton
            // 
            this.EditKampanjButton.Location = new System.Drawing.Point(9, 50);
            this.EditKampanjButton.Name = "EditKampanjButton";
            this.EditKampanjButton.Size = new System.Drawing.Size(135, 32);
            this.EditKampanjButton.TabIndex = 13;
            this.EditKampanjButton.Text = "Redigera";
            this.EditKampanjButton.UseVisualStyleBackColor = true;
            this.EditKampanjButton.Click += new System.EventHandler(this.EditKampanjButton_Click);
            // 
            // AddKampanjButton
            // 
            this.AddKampanjButton.Location = new System.Drawing.Point(9, 12);
            this.AddKampanjButton.Name = "AddKampanjButton";
            this.AddKampanjButton.Size = new System.Drawing.Size(135, 32);
            this.AddKampanjButton.TabIndex = 12;
            this.AddKampanjButton.Text = "Lägg till";
            this.AddKampanjButton.UseVisualStyleBackColor = true;
            this.AddKampanjButton.Click += new System.EventHandler(this.AddKampanjButton_Click);
            // 
            // listKampanj
            // 
            this.listKampanj.FormattingEnabled = true;
            this.listKampanj.Location = new System.Drawing.Point(150, 12);
            this.listKampanj.Name = "listKampanj";
            this.listKampanj.Size = new System.Drawing.Size(596, 251);
            this.listKampanj.TabIndex = 11;
            // 
            // ShowKampanjForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 272);
            this.Controls.Add(this.RemoveKampanjButton);
            this.Controls.Add(this.EditKampanjButton);
            this.Controls.Add(this.AddKampanjButton);
            this.Controls.Add(this.listKampanj);
            this.Name = "ShowKampanjForm";
            this.Text = "ShowKampanjForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RemoveKampanjButton;
        private System.Windows.Forms.Button EditKampanjButton;
        private System.Windows.Forms.Button AddKampanjButton;
        private System.Windows.Forms.ListBox listKampanj;

    }
}