namespace ImageMSharp
{
    partial class GUI
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
            this.FilterSelector = new MetroFramework.Controls.MetroComboBox();
            this.ComputeButton = new MetroFramework.Controls.MetroButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalvaButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ApriButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ChiudiButton = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aiutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daSviluppatoreIndipendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitaIlCodiceSegretoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Reset = new MetroFramework.Controls.MetroButton();
            this.ViewBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilterSelector
            // 
            this.FilterSelector.AccessibleName = "FilterSelector";
            this.FilterSelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FilterSelector.FormattingEnabled = true;
            this.FilterSelector.ItemHeight = 23;
            this.FilterSelector.Items.AddRange(new object[] {
            "Threshold",
            "BorderRecon",
            "GreyScale"});
            this.FilterSelector.Location = new System.Drawing.Point(3, 3);
            this.FilterSelector.Name = "FilterSelector";
            this.FilterSelector.Size = new System.Drawing.Size(121, 29);
            this.FilterSelector.TabIndex = 1;
            this.FilterSelector.SelectedIndexChanged += new System.EventHandler(this.FilterSelector_SelectedIndexChanged);
            // 
            // ComputeButton
            // 
            this.ComputeButton.Location = new System.Drawing.Point(130, 3);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(75, 23);
            this.ComputeButton.TabIndex = 3;
            this.ComputeButton.Text = "Compute";
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.aiutoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalvaButton,
            this.ApriButton,
            this.ChiudiButton});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // SalvaButton
            // 
            this.SalvaButton.Name = "SalvaButton";
            this.SalvaButton.Size = new System.Drawing.Size(180, 22);
            this.SalvaButton.Text = "Salva";
            // 
            // ApriButton
            // 
            this.ApriButton.Name = "ApriButton";
            this.ApriButton.Size = new System.Drawing.Size(180, 22);
            this.ApriButton.Text = "Apri";
            this.ApriButton.Click += new System.EventHandler(this.ApriButton_Click);
            // 
            // ChiudiButton
            // 
            this.ChiudiButton.Name = "ChiudiButton";
            this.ChiudiButton.Size = new System.Drawing.Size(180, 22);
            this.ChiudiButton.Text = "Chiudi";
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importaToolStripMenuItem});
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.modificaToolStripMenuItem.Text = "Modifica";
            // 
            // importaToolStripMenuItem
            // 
            this.importaToolStripMenuItem.Name = "importaToolStripMenuItem";
            this.importaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importaToolStripMenuItem.Text = "Importa";
            // 
            // aiutoToolStripMenuItem
            // 
            this.aiutoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daSviluppatoreIndipendenteToolStripMenuItem,
            this.digitaIlCodiceSegretoToolStripMenuItem});
            this.aiutoToolStripMenuItem.Name = "aiutoToolStripMenuItem";
            this.aiutoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aiutoToolStripMenuItem.Text = "Aiuto";
            // 
            // daSviluppatoreIndipendenteToolStripMenuItem
            // 
            this.daSviluppatoreIndipendenteToolStripMenuItem.Name = "daSviluppatoreIndipendenteToolStripMenuItem";
            this.daSviluppatoreIndipendenteToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.daSviluppatoreIndipendenteToolStripMenuItem.Text = "Da sviluppatore indipendente";
            // 
            // digitaIlCodiceSegretoToolStripMenuItem
            // 
            this.digitaIlCodiceSegretoToolStripMenuItem.Name = "digitaIlCodiceSegretoToolStripMenuItem";
            this.digitaIlCodiceSegretoToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.digitaIlCodiceSegretoToolStripMenuItem.Text = "Digita il codice Segreto";
            this.digitaIlCodiceSegretoToolStripMenuItem.Click += new System.EventHandler(this.DigitaIlCodiceSegretoToolStripMenuItem_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(211, 3);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 5;
            this.Reset.Text = "Reset";
            this.Reset.Click += new System.EventHandler(this.Aggiorna_Click);
            // 
            // ViewBox
            // 
            this.ViewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewBox.Location = new System.Drawing.Point(0, 24);
            this.ViewBox.Name = "ViewBox";
            this.ViewBox.Size = new System.Drawing.Size(781, 385);
            this.ViewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ViewBox.TabIndex = 6;
            this.ViewBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.FilterSelector);
            this.flowLayoutPanel1.Controls.Add(this.ComputeButton);
            this.flowLayoutPanel1.Controls.Add(this.Reset);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 374);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(781, 35);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(781, 409);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ViewBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUI";
            this.Text = "ImageMSharp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox FilterSelector;
        private MetroFramework.Controls.MetroButton ComputeButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SalvaButton;
        private System.Windows.Forms.ToolStripMenuItem ApriButton;
        private System.Windows.Forms.ToolStripMenuItem ChiudiButton;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aiutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daSviluppatoreIndipendenteToolStripMenuItem;
        private MetroFramework.Controls.MetroButton Reset;
        private System.Windows.Forms.ToolStripMenuItem digitaIlCodiceSegretoToolStripMenuItem;
        private System.Windows.Forms.PictureBox ViewBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}