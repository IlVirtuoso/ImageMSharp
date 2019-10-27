namespace ImageMSharp.Filters
{
    partial class displayDriver
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
            this.parameter = new MetroFramework.Controls.MetroLabel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.trackBar = new MetroFramework.Controls.MetroTrackBar();
            this.valueDisplay = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // parameter
            // 
            this.parameter.AutoSize = true;
            this.parameter.Location = new System.Drawing.Point(20, 23);
            this.parameter.Name = "parameter";
            this.parameter.Size = new System.Drawing.Size(70, 19);
            this.parameter.TabIndex = 0;
            this.parameter.Text = "Parameter";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 107);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(768, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 2;
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.Color.Transparent;
            this.trackBar.Location = new System.Drawing.Point(116, 19);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(75, 23);
            this.trackBar.TabIndex = 3;
            this.trackBar.Text = "metroTrackBar1";
            // 
            // valueDisplay
            // 
            this.valueDisplay.AutoSize = true;
            this.valueDisplay.Location = new System.Drawing.Point(213, 19);
            this.valueDisplay.Name = "valueDisplay";
            this.valueDisplay.Size = new System.Drawing.Size(80, 19);
            this.valueDisplay.TabIndex = 4;
            this.valueDisplay.Text = "valueDisplay";
            // 
            // displayDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(797, 142);
            this.Controls.Add(this.valueDisplay);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.parameter);
            this.Name = "displayDriver";
            this.Text = "displayDriver";
            this.Load += new System.EventHandler(this.DisplayDriver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroLabel parameter;
        public System.Windows.Forms.ProgressBar progressBar;
        public MetroFramework.Controls.MetroTrackBar trackBar;
        public MetroFramework.Controls.MetroLabel valueDisplay;
    }
}