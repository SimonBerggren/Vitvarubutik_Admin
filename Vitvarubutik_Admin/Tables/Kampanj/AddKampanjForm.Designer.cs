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
            this.BeskrivningTextBox = new System.Windows.Forms.RichTextBox();
            this.PercentTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.Date_FROM.CustomFormat = "";
            this.Date_FROM.Location = new System.Drawing.Point(46, 38);
            this.Date_FROM.Name = "Date_FROM";
            this.Date_FROM.Size = new System.Drawing.Size(138, 20);
            this.Date_FROM.TabIndex = 1;
            // 
            // Label_FROM
            // 
            this.Label_FROM.AutoSize = true;
            this.Label_FROM.Location = new System.Drawing.Point(12, 38);
            this.Label_FROM.Name = "Label_FROM";
            this.Label_FROM.Size = new System.Drawing.Size(28, 13);
            this.Label_FROM.TabIndex = 2;
            this.Label_FROM.Text = "Från";
            // 
            // Label_TO
            // 
            this.Label_TO.AutoSize = true;
            this.Label_TO.Location = new System.Drawing.Point(20, 67);
            this.Label_TO.Name = "Label_TO";
            this.Label_TO.Size = new System.Drawing.Size(20, 13);
            this.Label_TO.TabIndex = 3;
            this.Label_TO.Text = "Till";
            // 
            // Date_TO
            // 
            this.Date_TO.Location = new System.Drawing.Point(46, 67);
            this.Date_TO.Name = "Date_TO";
            this.Date_TO.Size = new System.Drawing.Size(138, 20);
            this.Date_TO.TabIndex = 4;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(12, 207);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(112, 31);
            this.Button.TabIndex = 5;
            this.Button.Text = "Lägg till ny kampanj";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // BeskrivningTextBox
            // 
            this.BeskrivningTextBox.Location = new System.Drawing.Point(12, 93);
            this.BeskrivningTextBox.Name = "BeskrivningTextBox";
            this.BeskrivningTextBox.Size = new System.Drawing.Size(260, 108);
            this.BeskrivningTextBox.TabIndex = 6;
            this.BeskrivningTextBox.Text = "Beskrivning";
            // 
            // PercentTextBox
            // 
            this.PercentTextBox.Location = new System.Drawing.Point(190, 67);
            this.PercentTextBox.MaxLength = 3;
            this.PercentTextBox.Name = "PercentTextBox";
            this.PercentTextBox.Size = new System.Drawing.Size(82, 20);
            this.PercentTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "% rabatt";
            // 
            // AddKampanjForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PercentTextBox);
            this.Controls.Add(this.BeskrivningTextBox);
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
        private RichTextBox BeskrivningTextBox;
        private TextBox PercentTextBox;
        private Label label1;
    }
}