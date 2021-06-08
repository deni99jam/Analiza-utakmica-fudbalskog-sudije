
namespace AnalizaUtakmica.Forme
{
    partial class frmDodajTrening
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
            this.components = new System.ComponentModel.Container();
            this.dtpDatumTreninga = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPrisustvovao = new System.Windows.Forms.CheckBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSezona = new System.Windows.Forms.ComboBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDatumTreninga
            // 
            this.dtpDatumTreninga.Location = new System.Drawing.Point(173, 79);
            this.dtpDatumTreninga.Name = "dtpDatumTreninga";
            this.dtpDatumTreninga.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumTreninga.TabIndex = 0;
            this.dtpDatumTreninga.ValueChanged += new System.EventHandler(this.dtpDatumTreninga_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "DatumTreninga:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbPrisustvovao
            // 
            this.cbPrisustvovao.AutoSize = true;
            this.cbPrisustvovao.Location = new System.Drawing.Point(47, 283);
            this.cbPrisustvovao.Name = "cbPrisustvovao";
            this.cbPrisustvovao.Size = new System.Drawing.Size(97, 19);
            this.cbPrisustvovao.TabIndex = 2;
            this.cbPrisustvovao.Text = "Prisustvovao";
            this.cbPrisustvovao.UseVisualStyleBackColor = true;
            this.cbPrisustvovao.CheckedChanged += new System.EventHandler(this.cbPrisustvovao_CheckedChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(239, 275);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(134, 29);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj trening";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sezona:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbSezona
            // 
            this.cmbSezona.FormattingEnabled = true;
            this.cmbSezona.Location = new System.Drawing.Point(173, 37);
            this.cmbSezona.Name = "cmbSezona";
            this.cmbSezona.Size = new System.Drawing.Size(200, 24);
            this.cmbSezona.TabIndex = 5;
            this.cmbSezona.SelectedIndexChanged += new System.EventHandler(this.cmbSezona_SelectedIndexChanged);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Opis:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(47, 149);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(326, 120);
            this.txtOpis.TabIndex = 7;
            this.txtOpis.TextChanged += new System.EventHandler(this.txtOpis_TextChanged);
            // 
            // frmDodajTrening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 316);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSezona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbPrisustvovao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatumTreninga);
            this.Name = "frmDodajTrening";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje Treninga";
            this.Load += new System.EventHandler(this.frmDodajTrening_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatumTreninga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbPrisustvovao;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSezona;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label3;
    }
}