namespace SchoolerWorks
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaSzkolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajSzkoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jużNicCiNiePomożeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oMnieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(624, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaSzkolaToolStripMenuItem,
            this.wczytajSzkoleToolStripMenuItem});
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.mToolStripMenuItem.Text = "Plik";
            // 
            // nowaSzkolaToolStripMenuItem
            // 
            this.nowaSzkolaToolStripMenuItem.Name = "nowaSzkolaToolStripMenuItem";
            this.nowaSzkolaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.nowaSzkolaToolStripMenuItem.Text = "Nowa szkoła";
            this.nowaSzkolaToolStripMenuItem.Click += new System.EventHandler(this.nowaSzkolaToolStripMenuItem_Click);
            // 
            // wczytajSzkoleToolStripMenuItem
            // 
            this.wczytajSzkoleToolStripMenuItem.Name = "wczytajSzkoleToolStripMenuItem";
            this.wczytajSzkoleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.wczytajSzkoleToolStripMenuItem.Text = "Wczytaj szkołę";
            this.wczytajSzkoleToolStripMenuItem.Click += new System.EventHandler(this.wczytajSzkoleToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jużNicCiNiePomożeToolStripMenuItem,
            this.oMnieToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // jużNicCiNiePomożeToolStripMenuItem
            // 
            this.jużNicCiNiePomożeToolStripMenuItem.Enabled = false;
            this.jużNicCiNiePomożeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.jużNicCiNiePomożeToolStripMenuItem.Name = "jużNicCiNiePomożeToolStripMenuItem";
            this.jużNicCiNiePomożeToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.jużNicCiNiePomożeToolStripMenuItem.Text = "Już nic Ci nie pomoże";
            // 
            // oMnieToolStripMenuItem
            // 
            this.oMnieToolStripMenuItem.Name = "oMnieToolStripMenuItem";
            this.oMnieToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.oMnieToolStripMenuItem.Text = "O mnie";
            this.oMnieToolStripMenuItem.Click += new System.EventHandler(this.oMnieToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 509);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindow";
            this.Text = "Szkola 2.0";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajSzkoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jużNicCiNiePomożeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oMnieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowaSzkolaToolStripMenuItem;
    }
}

