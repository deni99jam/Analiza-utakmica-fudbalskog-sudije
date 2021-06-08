
namespace AnalizaUtakmica.Forme
{
    partial class frmUtakmice
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
            this.dgvUtakmice = new System.Windows.Forms.DataGridView();
            this.GlavniPomocni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DomacaEkipa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GostujucaEkipa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolega1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolega2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MisljenjeOUtakmici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rezultat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placena = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnUtakmica = new System.Windows.Forms.Button();
            this.cmbUloga = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSezona = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPlacena = new System.Windows.Forms.ComboBox();
            this.cbUloga = new System.Windows.Forms.CheckBox();
            this.cbKat = new System.Windows.Forms.CheckBox();
            this.cbSezona = new System.Windows.Forms.CheckBox();
            this.cbPlac = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUkupno = new System.Windows.Forms.Label();
            this.lblPoPretrazi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUtakmice
            // 
            this.dgvUtakmice.AllowUserToAddRows = false;
            this.dgvUtakmice.AllowUserToDeleteRows = false;
            this.dgvUtakmice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtakmice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GlavniPomocni,
            this.DomacaEkipa,
            this.GostujucaEkipa,
            this.Datum,
            this.Kolega1,
            this.Kolega2,
            this.MisljenjeOUtakmici,
            this.Rezultat,
            this.Kategorija,
            this.Placena,
            this.Obrisi});
            this.dgvUtakmice.Location = new System.Drawing.Point(12, 93);
            this.dgvUtakmice.Name = "dgvUtakmice";
            this.dgvUtakmice.ReadOnly = true;
            this.dgvUtakmice.RowHeadersWidth = 51;
            this.dgvUtakmice.RowTemplate.Height = 24;
            this.dgvUtakmice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUtakmice.Size = new System.Drawing.Size(1458, 487);
            this.dgvUtakmice.TabIndex = 0;
            this.dgvUtakmice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUtakmice_CellContentClick);
            this.dgvUtakmice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUtakmice_CellDoubleClick);
            // 
            // GlavniPomocni
            // 
            this.GlavniPomocni.DataPropertyName = "GlavniPomocni";
            this.GlavniPomocni.HeaderText = "GlavniPomocni";
            this.GlavniPomocni.MinimumWidth = 6;
            this.GlavniPomocni.Name = "GlavniPomocni";
            this.GlavniPomocni.ReadOnly = true;
            this.GlavniPomocni.Width = 125;
            // 
            // DomacaEkipa
            // 
            this.DomacaEkipa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DomacaEkipa.DataPropertyName = "DomacaEkipa";
            this.DomacaEkipa.HeaderText = "DomacaEkipa";
            this.DomacaEkipa.MinimumWidth = 6;
            this.DomacaEkipa.Name = "DomacaEkipa";
            this.DomacaEkipa.ReadOnly = true;
            // 
            // GostujucaEkipa
            // 
            this.GostujucaEkipa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GostujucaEkipa.DataPropertyName = "GostujucaEkipa";
            this.GostujucaEkipa.HeaderText = "GostujucaEkipa";
            this.GostujucaEkipa.MinimumWidth = 6;
            this.GostujucaEkipa.Name = "GostujucaEkipa";
            this.GostujucaEkipa.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Kolega1
            // 
            this.Kolega1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kolega1.DataPropertyName = "Kolega1";
            this.Kolega1.HeaderText = "Kolega1";
            this.Kolega1.MinimumWidth = 6;
            this.Kolega1.Name = "Kolega1";
            this.Kolega1.ReadOnly = true;
            // 
            // Kolega2
            // 
            this.Kolega2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kolega2.DataPropertyName = "Kolega2";
            this.Kolega2.HeaderText = "Kolega2";
            this.Kolega2.MinimumWidth = 6;
            this.Kolega2.Name = "Kolega2";
            this.Kolega2.ReadOnly = true;
            // 
            // MisljenjeOUtakmici
            // 
            this.MisljenjeOUtakmici.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MisljenjeOUtakmici.DataPropertyName = "MisljenjeOUtakmici";
            this.MisljenjeOUtakmici.HeaderText = "MisljenjeOUtakmici";
            this.MisljenjeOUtakmici.MinimumWidth = 6;
            this.MisljenjeOUtakmici.Name = "MisljenjeOUtakmici";
            this.MisljenjeOUtakmici.ReadOnly = true;
            // 
            // Rezultat
            // 
            this.Rezultat.DataPropertyName = "Rezultat";
            this.Rezultat.HeaderText = "Rezultat";
            this.Rezultat.MinimumWidth = 6;
            this.Rezultat.Name = "Rezultat";
            this.Rezultat.ReadOnly = true;
            this.Rezultat.Width = 90;
            // 
            // Kategorija
            // 
            this.Kategorija.DataPropertyName = "Kategorija";
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.MinimumWidth = 6;
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.ReadOnly = true;
            this.Kategorija.Width = 90;
            // 
            // Placena
            // 
            this.Placena.DataPropertyName = "Placena";
            this.Placena.HeaderText = "Placena";
            this.Placena.MinimumWidth = 6;
            this.Placena.Name = "Placena";
            this.Placena.ReadOnly = true;
            this.Placena.Width = 90;
            // 
            // Obrisi
            // 
            this.Obrisi.HeaderText = "Obrisi";
            this.Obrisi.MinimumWidth = 6;
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.ReadOnly = true;
            this.Obrisi.Text = "Obrisi";
            this.Obrisi.UseColumnTextForButtonValue = true;
            this.Obrisi.Width = 125;
            // 
            // btnUtakmica
            // 
            this.btnUtakmica.Location = new System.Drawing.Point(1318, 603);
            this.btnUtakmica.Name = "btnUtakmica";
            this.btnUtakmica.Size = new System.Drawing.Size(152, 27);
            this.btnUtakmica.TabIndex = 1;
            this.btnUtakmica.Text = "Dodaj utakmicu";
            this.btnUtakmica.UseVisualStyleBackColor = true;
            this.btnUtakmica.Click += new System.EventHandler(this.btnUtakmica_Click);
            // 
            // cmbUloga
            // 
            this.cmbUloga.FormattingEnabled = true;
            this.cmbUloga.Items.AddRange(new object[] {
            "Glavni sudija",
            "Prvi asistent",
            "Drugi asistent",
            "Prvi/drugi asistent",
            "Sve uloge"});
            this.cmbUloga.Location = new System.Drawing.Point(158, 54);
            this.cmbUloga.Name = "cmbUloga";
            this.cmbUloga.Size = new System.Drawing.Size(163, 24);
            this.cmbUloga.TabIndex = 2;
            this.cmbUloga.SelectedIndexChanged += new System.EventHandler(this.cmbUloga_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pretraga po ulozi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pretraga po kategoriji:";
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(509, 54);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(156, 24);
            this.cmbKategorija.TabIndex = 5;
            this.cmbKategorija.SelectedIndexChanged += new System.EventHandler(this.cmbKategorija_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(693, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pretraga po sezoni:";
            // 
            // cmbSezona
            // 
            this.cmbSezona.FormattingEnabled = true;
            this.cmbSezona.Location = new System.Drawing.Point(840, 54);
            this.cmbSezona.Name = "cmbSezona";
            this.cmbSezona.Size = new System.Drawing.Size(178, 24);
            this.cmbSezona.TabIndex = 7;
            this.cmbSezona.SelectedIndexChanged += new System.EventHandler(this.cmbSezona_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1049, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Plaćena/nije plaćena:";
            // 
            // cmbPlacena
            // 
            this.cmbPlacena.FormattingEnabled = true;
            this.cmbPlacena.Items.AddRange(new object[] {
            "Plaćena",
            "NIje plaćena ",
            "Sve"});
            this.cmbPlacena.Location = new System.Drawing.Point(1198, 54);
            this.cmbPlacena.Name = "cmbPlacena";
            this.cmbPlacena.Size = new System.Drawing.Size(148, 24);
            this.cmbPlacena.TabIndex = 11;
            this.cmbPlacena.SelectedIndexChanged += new System.EventHandler(this.cmbPlacena_SelectedIndexChanged);
            // 
            // cbUloga
            // 
            this.cbUloga.AutoSize = true;
            this.cbUloga.Location = new System.Drawing.Point(158, 13);
            this.cbUloga.Name = "cbUloga";
            this.cbUloga.Size = new System.Drawing.Size(67, 21);
            this.cbUloga.TabIndex = 13;
            this.cbUloga.Text = "Uloga";
            this.cbUloga.UseVisualStyleBackColor = true;
            this.cbUloga.CheckedChanged += new System.EventHandler(this.cbUloga_CheckedChanged);
            // 
            // cbKat
            // 
            this.cbKat.AutoSize = true;
            this.cbKat.Location = new System.Drawing.Point(509, 13);
            this.cbKat.Name = "cbKat";
            this.cbKat.Size = new System.Drawing.Size(94, 21);
            this.cbKat.TabIndex = 14;
            this.cbKat.Text = "Kategorija";
            this.cbKat.UseVisualStyleBackColor = true;
            this.cbKat.CheckedChanged += new System.EventHandler(this.cbKat_CheckedChanged);
            // 
            // cbSezona
            // 
            this.cbSezona.AutoSize = true;
            this.cbSezona.Location = new System.Drawing.Point(840, 13);
            this.cbSezona.Name = "cbSezona";
            this.cbSezona.Size = new System.Drawing.Size(78, 21);
            this.cbSezona.TabIndex = 15;
            this.cbSezona.Text = "Sezona";
            this.cbSezona.UseVisualStyleBackColor = true;
            this.cbSezona.CheckedChanged += new System.EventHandler(this.cbSezona_CheckedChanged);
            // 
            // cbPlac
            // 
            this.cbPlac.AutoSize = true;
            this.cbPlac.Location = new System.Drawing.Point(1198, 13);
            this.cbPlac.Name = "cbPlac";
            this.cbPlac.Size = new System.Drawing.Size(81, 21);
            this.cbPlac.TabIndex = 16;
            this.cbPlac.Text = "Placena";
            this.cbPlac.UseVisualStyleBackColor = true;
            this.cbPlac.CheckedChanged += new System.EventHandler(this.cbPlac_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 592);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ukupno utakmica:";
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Location = new System.Drawing.Point(149, 592);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(0, 17);
            this.lblUkupno.TabIndex = 18;
            // 
            // lblPoPretrazi
            // 
            this.lblPoPretrazi.AutoSize = true;
            this.lblPoPretrazi.Location = new System.Drawing.Point(222, 613);
            this.lblPoPretrazi.Name = "lblPoPretrazi";
            this.lblPoPretrazi.Size = new System.Drawing.Size(0, 17);
            this.lblPoPretrazi.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 613);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Broj utakmica prema pretrazi:";
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.Location = new System.Drawing.Point(1167, 603);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(101, 27);
            this.btnIzvjestaj.TabIndex = 21;
            this.btnIzvjestaj.Text = "Izvjestaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // frmUtakmice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 652);
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.lblPoPretrazi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblUkupno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbPlac);
            this.Controls.Add(this.cbSezona);
            this.Controls.Add(this.cbKat);
            this.Controls.Add(this.cbUloga);
            this.Controls.Add(this.cmbPlacena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSezona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUloga);
            this.Controls.Add(this.btnUtakmica);
            this.Controls.Add(this.dgvUtakmice);
            this.Name = "frmUtakmice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utakmice";
            this.Load += new System.EventHandler(this.frmUtakmice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUtakmice;
        private System.Windows.Forms.Button btnUtakmica;
        private System.Windows.Forms.ComboBox cmbUloga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSezona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPlacena;
        private System.Windows.Forms.CheckBox cbUloga;
        private System.Windows.Forms.CheckBox cbKat;
        private System.Windows.Forms.CheckBox cbSezona;
        private System.Windows.Forms.CheckBox cbPlac;
        private System.Windows.Forms.DataGridViewTextBoxColumn GlavniPomocni;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomacaEkipa;
        private System.Windows.Forms.DataGridViewTextBoxColumn GostujucaEkipa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolega1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolega2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MisljenjeOUtakmici;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rezultat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Placena;
        private System.Windows.Forms.DataGridViewButtonColumn Obrisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.Label lblPoPretrazi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIzvjestaj;
    }
}