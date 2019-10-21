namespace ImageMSharp
{
    partial class SecretCode
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
            this.CodeBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CodeConfirmation = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // CodeBox
            // 
            this.CodeBox.Location = new System.Drawing.Point(153, 48);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Size = new System.Drawing.Size(140, 23);
            this.CodeBox.TabIndex = 0;
            this.CodeBox.Text = "Codice";
            this.CodeBox.Click += new System.EventHandler(this.CodeBox_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 48);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(117, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Digita qui il codice";
            // 
            // CodeConfirmation
            // 
            this.CodeConfirmation.Location = new System.Drawing.Point(87, 95);
            this.CodeConfirmation.Name = "CodeConfirmation";
            this.CodeConfirmation.Size = new System.Drawing.Size(106, 23);
            this.CodeConfirmation.TabIndex = 2;
            this.CodeConfirmation.Text = "Conferma";
            this.CodeConfirmation.Click += new System.EventHandler(this.CodeConfirmation_Click);
            // 
            // SecretCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 130);
            this.Controls.Add(this.CodeConfirmation);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CodeBox);
            this.Name = "SecretCode";
            this.Text = "SecretCode";
            this.Load += new System.EventHandler(this.SecretCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox CodeBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton CodeConfirmation;
    }
}