
namespace AnalizaUtakmica.Forme
{
    partial class frmSastanci
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
            this.dgvSastanci = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cbSezona = new System.Windows.Forms.CheckBox();
            this.cbPris = new System.Windows.Forms.CheckBox();
            this.cbPrisustvovao = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DatumSastanka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpisSastanka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prisustvovao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblSastanciPoluszona = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSastanciUkupno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastanci)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSastanci
            // 
            this.dgvSastanci.AllowUserToAddRows = false;
            this.dgvSastanci.AllowUserToDeleteRows = false;
            this.dgvSastanci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSastanci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatumSastanka,
            this.OpisSastanka,
            this.Prisustvovao,
            this.Obrisi});
            this.dgvSastanci.Location = new System.Drawing.Point(39, 97);
            this.dgvSastanci.Name = "dgvSastanci";
            this.dgvSastanci.ReadOnly = true;
            this.dgvSastanci.RowHeadersWidth = 51;
            this.dgvSastanci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSastanci.Size = new System.Drawing.Size(674, 310);
            this.dgvSastanci.TabIndex = 0;
            this.dgvSastanci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSastanci_CellContentClick);
            this.dgvSastanci.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSastanci_CellDoubleClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(587, 425);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(125, 35);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj sastanak";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cbSezona
            // 
            this.cbSezona.AutoSize = true;
            this.cbSezona.Location = new System.Drawing.Point(102, 24);
            this.cbSezona.Name = "cbSezona";
            this.cbSezona.Size = new System.Drawing.Size(132, 19);
            this.cbSezona.TabIndex = 17;
            this.cbSezona.Text = "Pretraga po sezoni";
            this.cbSezona.UseVisualStyleBackColor = true;
            this.cbSezona.CheckedChanged += new System.EventHandler(this.cbSezona_CheckedChanged);
            // 
            // cbPris
            // 
            this.cbPris.AutoSize = true;
            this.cbPris.Location = new System.Drawing.Point(569, 24);
            this.cbPris.Name = "cbPris";
            this.cbPris.Size = new System.Drawing.Size(144, 19);
            this.cbPris.TabIndex = 16;
            this.cbPris.Text = "Pretraga po prisustvu";
            this.cbPris.UseVisualStyleBackColor = true;
            this.cbPris.CheckedChanged += new System.EventHandler(this.cbPris_CheckedChanged);
            // 
            // cbPrisustvovao
            // 
            this.cbPrisustvovao.AutoSize = true;
            this.cbPrisustvovao.Location = new System.Drawing.Point(616, 57);
            this.cbPrisustvovao.Name = "cbPrisustvovao";
            this.cbPrisustvovao.Size = new System.Drawing.Size(97, 19);
            this.cbPrisustvovao.TabIndex = 15;
            this.cbPrisustvovao.Text = "Prisustvovao";
            this.cbPrisustvovao.UseVisualStyleBackColor = true;
            this.cbPrisustvovao.CheckedChanged += new System.EventHandler(this.cbPrisustvovao_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sezona:";
            // 
            // DatumSastanka
            // 
            this.DatumSastanka.DataPropertyName = "Datum";
            this.DatumSastanka.HeaderText = "Datum sastanka";
            this.DatumSastanka.MinimumWidth = 6;
            this.DatumSastanka.Name = "DatumSastanka";
            this.DatumSastanka.ReadOnly = true;
            this.DatumSastanka.Width = 125;
            // 
            // OpisSastanka
            // 
            this.OpisSastanka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OpisSastanka.DataPropertyName = "OpisSastanka";
            this.OpisSastanka.HeaderText = "Opis sastanka";
            this.OpisSastanka.MinimumWidth = 6;
            this.OpisSastanka.Name = "OpisSastanka";
            this.OpisSastanka.ReadOnly = true;
            // 
            // Prisustvovao
            // 
            this.Prisustvovao.DataPropertyName = "Prisustvovao";
            this.Prisustvovao.HeaderText = "Prisustvovao";
            this.Prisustvovao.MinimumWidth = 6;
            this.Prisustvovao.Name = "Prisustvovao";
            this.Prisustvovao.ReadOnly = true;
            this.Prisustvovao.Width = 85;
            // 
            // Obrisi
            // 
            this.Obrisi.HeaderText = "Obrisi";
            this.Obrisi.MinimumWidth = 6;
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.ReadOnly = true;
            this.Obrisi.Text = "Obrisi";
            this.Obrisi.UseColumnTextForButtonValue = true;
            this.Obrisi.Width = 95;
            // 
            // lblSastanciPoluszona
            // 
            this.lblSastanciPoluszona.AutoSize = true;
            this.lblSastanciPoluszona.Location = new System.Drawing.Point(287, 459);
            this.lblSastanciPoluszona.Name = "lblSastanciPoluszona";
            this.lblSastanciPoluszona.Size = new System.Drawing.Size(0, 15);
            this.lblSastanciPoluszona.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Broj ukupno odrađenih sastanaka:";
            // 
            // lblSastanciUkupno
            // 
            this.lblSastanciUkupno.AutoSize = true;
            this.lblSastanciUkupno.Location = new System.Drawing.Point(266, 425);
            this.lblSastanciUkupno.Name = "lblSastanciUkupno";
            this.lblSastanciUkupno.Size = new System.Drawing.Size(0, 15);
            this.lblSastanciUkupno.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Broj odrađenih sastanaka u polusezoni:";
            // 
            // frmSastanci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 497);
            this.Controls.Add(this.lblSastanciPoluszona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSastanciUkupno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSezona);
            this.Controls.Add(this.cbPris);
            this.Controls.Add(this.cbPrisustvovao);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvSastanci);
            this.Name = "frmSastanci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sastanci";
            this.Load += new System.EventHandler(this.frmSastanci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastanci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSastanci;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.CheckBox cbSezona;
        private System.Windows.Forms.CheckBox cbPris;
        private System.Windows.Forms.CheckBox cbPrisustvovao;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumSastanka;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpisSastanka;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Prisustvovao;
        private System.Windows.Forms.DataGridViewButtonColumn Obrisi;
        private System.Windows.Forms.Label lblSastanciPoluszona;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSastanciUkupno;
        private System.Windows.Forms.Label label2;
    }
}