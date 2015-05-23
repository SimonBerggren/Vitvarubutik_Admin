namespace Vitvarubutik_Admin.Tables.Leverantör
{
    partial class ShowLeverantörForm
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
            this.listLeverantör = new System.Windows.Forms.ListBox();
            this.AddLeverantörButton = new System.Windows.Forms.Button();
            this.EditLeverantörButton = new System.Windows.Forms.Button();
            this.RemoveLeverantörButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listLeverantör
            // 
            this.listLeverantör.FormattingEnabled = true;
            this.listLeverantör.Location = new System.Drawing.Point(153, 12);
            this.listLeverantör.Name = "listLeverantör";
            this.listLeverantör.Size = new System.Drawing.Size(596, 251);
            this.listLeverantör.TabIndex = 0;
            // 
            // AddLeverantörButton
            // 
            this.AddLeverantörButton.Location = new System.Drawing.Point(12, 12);
            this.AddLeverantörButton.Name = "AddLeverantörButton";
            this.AddLeverantörButton.Size = new System.Drawing.Size(135, 32);
            this.AddLeverantörButton.TabIndex = 8;
            this.AddLeverantörButton.Text = "Lägg till";
            this.AddLeverantörButton.UseVisualStyleBackColor = true;
            this.AddLeverantörButton.Click += new System.EventHandler(this.AddLeverantörButton_Click);
            // 
            // EditLeverantörButton
            // 
            this.EditLeverantörButton.Location = new System.Drawing.Point(12, 50);
            this.EditLeverantörButton.Name = "EditLeverantörButton";
            this.EditLeverantörButton.Size = new System.Drawing.Size(135, 32);
            this.EditLeverantörButton.TabIndex = 9;
            this.EditLeverantörButton.Text = "Redigera";
            this.EditLeverantörButton.UseVisualStyleBackColor = true;
            this.EditLeverantörButton.Click += new System.EventHandler(this.EditLeverantörButton_Click);
            // 
            // RemoveLeverantörButton
            // 
            this.RemoveLeverantörButton.Location = new System.Drawing.Point(12, 88);
            this.RemoveLeverantörButton.Name = "RemoveLeverantörButton";
            this.RemoveLeverantörButton.Size = new System.Drawing.Size(135, 32);
            this.RemoveLeverantörButton.TabIndex = 10;
            this.RemoveLeverantörButton.Text = "Ta bort";
            this.RemoveLeverantörButton.UseVisualStyleBackColor = true;
            this.RemoveLeverantörButton.Click += new System.EventHandler(this.RemoveLeverantörButton_Click);
            // 
            // ShowLeverantörForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 275);
            this.Controls.Add(this.RemoveLeverantörButton);
            this.Controls.Add(this.EditLeverantörButton);
            this.Controls.Add(this.AddLeverantörButton);
            this.Controls.Add(this.listLeverantör);
            this.Name = "ShowLeverantörForm";
            this.Text = "ShowLeverantörForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listLeverantör;
        private System.Windows.Forms.Button AddLeverantörButton;
        private System.Windows.Forms.Button EditLeverantörButton;
        private System.Windows.Forms.Button RemoveLeverantörButton;
    }
}