
namespace AnalizaUtakmica.Forme
{
    partial class frmGlavna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treninziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utakmiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sastanciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodatneAktivnostiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajSezonuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.treninziToolStripMenuItem,
            this.utakmiceToolStripMenuItem,
            this.sastanciToolStripMenuItem,
            this.dodatneAktivnostiToolStripMenuItem,
            this.dodajSezonuToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // treninziToolStripMenuItem
            // 
            this.treninziToolStripMenuItem.Name = "treninziToolStripMenuItem";
            this.treninziToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.treninziToolStripMenuItem.Text = "Treninzi";
            this.treninziToolStripMenuItem.Click += new System.EventHandler(this.treninziToolStripMenuItem_Click);
            // 
            // utakmiceToolStripMenuItem
            // 
            this.utakmiceToolStripMenuItem.Name = "utakmiceToolStripMenuItem";
            this.utakmiceToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.utakmiceToolStripMenuItem.Text = "Utakmice";
            this.utakmiceToolStripMenuItem.Click += new System.EventHandler(this.utakmiceToolStripMenuItem_Click);
            // 
            // sastanciToolStripMenuItem
            // 
            this.sastanciToolStripMenuItem.Name = "sastanciToolStripMenuItem";
            this.sastanciToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.sastanciToolStripMenuItem.Text = "Sastanci";
            this.sastanciToolStripMenuItem.Click += new System.EventHandler(this.sastanciToolStripMenuItem_Click);
            // 
            // dodatneAktivnostiToolStripMenuItem
            // 
            this.dodatneAktivnostiToolStripMenuItem.Name = "dodatneAktivnostiToolStripMenuItem";
            this.dodatneAktivnostiToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.dodatneAktivnostiToolStripMenuItem.Text = "Dodatne aktivnosti";
            this.dodatneAktivnostiToolStripMenuItem.Click += new System.EventHandler(this.dodatneAktivnostiToolStripMenuItem_Click);
            // 
            // dodajSezonuToolStripMenuItem
            // 
            this.dodajSezonuToolStripMenuItem.Name = "dodajSezonuToolStripMenuItem";
            this.dodajSezonuToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.dodajSezonuToolStripMenuItem.Text = "Dodaj sezonu";
            this.dodajSezonuToolStripMenuItem.Click += new System.EventHandler(this.dodajSezonuToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "@Copyright by Deny";
            // 
            // frmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analiza treninga i utakmica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGlavna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treninziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utakmiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajSezonuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sastanciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodatneAktivnostiToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}