
namespace AnalizaUtakmica.Forme
{
    partial class frmTreninzi
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
            this.dgvTreninzi = new System.Windows.Forms.DataGridView();
            this.DatumTreninga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prisustvovao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbPrisustvovao = new System.Windows.Forms.CheckBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTreninziUkupno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTreninziPoluszona = new System.Windows.Forms.Label();
            this.cbPris = new System.Windows.Forms.CheckBox();
            this.cbSezona = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTreninzi
            // 
            this.dgvTreninzi.AllowUserToAddRows = false;
            this.dgvTreninzi.AllowUserToDeleteRows = false;
            this.dgvTreninzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreninzi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatumTreninga,
            this.Prisustvovao,
            this.Opis,
            this.Obrisi});
            this.dgvTreninzi.Location = new System.Drawing.Point(26, 88);
            this.dgvTreninzi.Name = "dgvTreninzi";
            this.dgvTreninzi.ReadOnly = true;
            this.dgvTreninzi.RowHeadersWidth = 51;
            this.dgvTreninzi.RowTemplate.Height = 24;
            this.dgvTreninzi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTreninzi.Size = new System.Drawing.Size(794, 330);
            this.dgvTreninzi.TabIndex = 0;
            this.dgvTreninzi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTreninzi_CellContentClick);
            this.dgvTreninzi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTreninzi_CellDoubleClick);
            // 
            // DatumTreninga
            // 
            this.DatumTreninga.DataPropertyName = "Datum";
            this.DatumTreninga.HeaderText = "Datum Treninga";
            this.DatumTreninga.MinimumWidth = 6;
            this.DatumTreninga.Name = "DatumTreninga";
            this.DatumTreninga.ReadOnly = true;
            this.DatumTreninga.Width = 137;
            // 
            // Prisustvovao
            // 
            this.Prisustvovao.DataPropertyName = "Prisustvovao";
            this.Prisustvovao.HeaderText = "Prisustvovao";
            this.Prisustvovao.MinimumWidth = 6;
            this.Prisustvovao.Name = "Prisustvovao";
            this.Prisustvovao.ReadOnly = true;
            this.Prisustvovao.Width = 110;
            // 
            // Opis
            // 
            this.Opis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.MinimumWidth = 6;
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // Obrisi
            // 
            this.Obrisi.HeaderText = "Obrisi trening";
            this.Obrisi.MinimumWidth = 6;
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.ReadOnly = true;
            this.Obrisi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Obrisi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Obrisi.Text = "Obrisi trening";
            this.Obrisi.UseColumnTextForButtonValue = true;
            this.Obrisi.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sezona:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbPrisustvovao
            // 
            this.cbPrisustvovao.AutoSize = true;
            this.cbPrisustvovao.Location = new System.Drawing.Point(709, 49);
            this.cbPrisustvovao.Name = "cbPrisustvovao";
            this.cbPrisustvovao.Size = new System.Drawing.Size(111, 21);
            this.cbPrisustvovao.TabIndex = 3;
            this.cbPrisustvovao.Text = "Prisustvovao";
            this.cbPrisustvovao.UseVisualStyleBackColor = true;
            this.cbPrisustvovao.CheckedChanged += new System.EventHandler(this.cbPrisustvovao_CheckedChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(709, 436);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(111, 32);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj trening";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Broj odrađenih treninga u polusezoni:";
            // 
            // lblTreninziUkupno
            // 
            this.lblTreninziUkupno.AutoSize = true;
            this.lblTreninziUkupno.Location = new System.Drawing.Point(253, 451);
            this.lblTreninziUkupno.Name = "lblTreninziUkupno";
            this.lblTreninziUkupno.Size = new System.Drawing.Size(0, 17);
            this.lblTreninziUkupno.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Broj ukupno odrađenih treninga:";
            // 
            // lblTreninziPoluszona
            // 
            this.lblTreninziPoluszona.AutoSize = true;
            this.lblTreninziPoluszona.Location = new System.Drawing.Point(274, 485);
            this.lblTreninziPoluszona.Name = "lblTreninziPoluszona";
            this.lblTreninziPoluszona.Size = new System.Drawing.Size(0, 17);
            this.lblTreninziPoluszona.TabIndex = 10;
            // 
            // cbPris
            // 
            this.cbPris.AutoSize = true;
            this.cbPris.Location = new System.Drawing.Point(654, 12);
            this.cbPris.Name = "cbPris";
            this.cbPris.Size = new System.Drawing.Size(166, 21);
            this.cbPris.TabIndex = 11;
            this.cbPris.Text = "Pretraga po prisustvu";
            this.cbPris.UseVisualStyleBackColor = true;
            this.cbPris.CheckedChanged += new System.EventHandler(this.cbPris_CheckedChanged);
            // 
            // cbSezona
            // 
            this.cbSezona.AutoSize = true;
            this.cbSezona.Location = new System.Drawing.Point(89, 12);
            this.cbSezona.Name = "cbSezona";
            this.cbSezona.Size = new System.Drawing.Size(150, 21);
            this.cbSezona.TabIndex = 12;
            this.cbSezona.Text = "Pretraga po sezoni";
            this.cbSezona.UseVisualStyleBackColor = true;
            this.cbSezona.CheckedChanged += new System.EventHandler(this.cbSezona_CheckedChanged);
            // 
            // frmTreninzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 511);
            this.Controls.Add(this.cbSezona);
            this.Controls.Add(this.cbPris);
            this.Controls.Add(this.lblTreninziPoluszona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTreninziUkupno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbPrisustvovao);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTreninzi);
            this.Name = "frmTreninzi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Treninzi";
            this.Load += new System.EventHandler(this.frmTreninzi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTreninzi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox cbPrisustvovao;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTreninziUkupno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTreninziPoluszona;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumTreninga;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Prisustvovao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewButtonColumn Obrisi;
        private System.Windows.Forms.CheckBox cbPris;
        private System.Windows.Forms.CheckBox cbSezona;
    }
}