namespace Vitvarubutik_Admin.Utilities
{
    partial class MSGForm
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
            this.Button = new System.Windows.Forms.Button();
            this.MSG_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(181, 79);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(62, 23);
            this.Button.TabIndex = 1;
            this.Button.Text = "OK";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // MSG_Label
            // 
            this.MSG_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MSG_Label.AutoSize = true;
            this.MSG_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSG_Label.Location = new System.Drawing.Point(167, 36);
            this.MSG_Label.Name = "MSG_Label";
            this.MSG_Label.Size = new System.Drawing.Size(65, 17);
            this.MSG_Label.TabIndex = 0;
            this.MSG_Label.Text = "Message";
            this.MSG_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MSGForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 114);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.MSG_Label);
            this.Name = "MSGForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MSG_Label;
        private System.Windows.Forms.Button Button;
    }
}