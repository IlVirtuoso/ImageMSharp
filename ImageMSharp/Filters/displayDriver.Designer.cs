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
            this.trackBar = new MetroFramework.Controls.MetroTrackBar();
            this.valueDisplay = new MetroFramework.Controls.MetroLabel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // parameter
            // 
            this.parameter.AutoSize = true;
            this.parameter.Location = new System.Drawing.Point(27, 28);
            this.parameter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.parameter.Name = "parameter";
            this.parameter.Size = new System.Drawing.Size(72, 20);
            this.parameter.TabIndex = 0;
            this.parameter.Text = "Parameter";
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.Color.Transparent;
            this.trackBar.Location = new System.Drawing.Point(155, 23);
            this.trackBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(100, 28);
            this.trackBar.TabIndex = 3;
            this.trackBar.Text = "metroTrackBar1";
            // 
            // valueDisplay
            // 
            this.valueDisplay.AutoSize = true;
            this.valueDisplay.Location = new System.Drawing.Point(284, 23);
            this.valueDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valueDisplay.Name = "valueDisplay";
            this.valueDisplay.Size = new System.Drawing.Size(86, 20);
            this.valueDisplay.TabIndex = 4;
            this.valueDisplay.Text = "valueDisplay";
            // 
            // progressBar
            // 
            this.progressBar.Cursor = System.Windows.Forms.Cursors.No;
            this.progressBar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar.Location = new System.Drawing.Point(16, 132);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1024, 28);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 2;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // displayDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1063, 175);
            this.Controls.Add(this.valueDisplay);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.parameter);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "displayDriver";
            this.Text = "displayDriver";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DisplayDriver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroLabel parameter;
        public MetroFramework.Controls.MetroTrackBar trackBar;
        public MetroFramework.Controls.MetroLabel valueDisplay;
        public System.Windows.Forms.ProgressBar progressBar;
    }
}