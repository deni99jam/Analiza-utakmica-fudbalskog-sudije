
namespace AnalizaUtakmica.Forme
{
    partial class frmDodajUtakmicu
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSezona = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUloga = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDomacaEkipa = new System.Windows.Forms.TextBox();
            this.txtGostujucaEkipa = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKolega1 = new System.Windows.Forms.TextBox();
            this.txtKolega2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbKat = new System.Windows.Forms.ComboBox();
            this.cbPlacena = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMisljenje = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtRezultat = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sezona:";
            // 
            // cmbSezona
            // 
            this.cmbSezona.FormattingEnabled = true;
            this.cmbSezona.Location = new System.Drawing.Point(158, 30);
            this.cmbSezona.Name = "cmbSezona";
            this.cmbSezona.Size = new System.Drawing.Size(200, 24);
            this.cmbSezona.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Uloga na utakmici:";
            // 
            // cmbUloga
            // 
            this.cmbUloga.FormattingEnabled = true;
            this.cmbUloga.Location = new System.Drawing.Point(158, 67);
            this.cmbUloga.Name = "cmbUloga";
            this.cmbUloga.Size = new System.Drawing.Size(200, 24);
            this.cmbUloga.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Domaca ekipa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gostujuca ekipa:";
            // 
            // txtDomacaEkipa
            // 
            this.txtDomacaEkipa.Location = new System.Drawing.Point(158, 105);
            this.txtDomacaEkipa.Name = "txtDomacaEkipa";
            this.txtDomacaEkipa.Size = new System.Drawing.Size(200, 22);
            this.txtDomacaEkipa.TabIndex = 6;
            // 
            // txtGostujucaEkipa
            // 
            this.txtGostujucaEkipa.Location = new System.Drawing.Point(158, 141);
            this.txtGostujucaEkipa.Name = "txtGostujucaEkipa";
            this.txtGostujucaEkipa.Size = new System.Drawing.Size(200, 22);
            this.txtGostujucaEkipa.TabIndex = 7;
            this.txtGostujucaEkipa.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 178);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Datum odigravanja:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kolega1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Kolega2:";
            // 
            // txtKolega1
            // 
            this.txtKolega1.Location = new System.Drawing.Point(158, 217);
            this.txtKolega1.Name = "txtKolega1";
            this.txtKolega1.Size = new System.Drawing.Size(200, 22);
            this.txtKolega1.TabIndex = 12;
            // 
            // txtKolega2
            // 
            this.txtKolega2.Location = new System.Drawing.Point(158, 253);
            this.txtKolega2.Name = "txtKolega2";
            this.txtKolega2.Size = new System.Drawing.Size(200, 22);
            this.txtKolega2.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Rezultat:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Kategorija:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cmbKat
            // 
            this.cmbKat.FormattingEnabled = true;
            this.cmbKat.Location = new System.Drawing.Point(158, 323);
            this.cmbKat.Name = "cmbKat";
            this.cmbKat.Size = new System.Drawing.Size(200, 24);
            this.cmbKat.TabIndex = 17;
            // 
            // cbPlacena
            // 
            this.cbPlacena.AutoSize = true;
            this.cbPlacena.Location = new System.Drawing.Point(158, 473);
            this.cbPlacena.Name = "cbPlacena";
            this.cbPlacena.Size = new System.Drawing.Size(81, 21);
            this.cbPlacena.TabIndex = 18;
            this.cbPlacena.Text = "Placena";
            this.cbPlacena.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(428, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Misljenje o utakmici:";
            // 
            // txtMisljenje
            // 
            this.txtMisljenje.Location = new System.Drawing.Point(431, 67);
            this.txtMisljenje.Multiline = true;
            this.txtMisljenje.Name = "txtMisljenje";
            this.txtMisljenje.Size = new System.Drawing.Size(307, 360);
            this.txtMisljenje.TabIndex = 20;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(614, 460);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(124, 34);
            this.btnDodaj.TabIndex = 21;
            this.btnDodaj.Text = "Dodaj utakmicu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // txtRezultat
            // 
            this.txtRezultat.Location = new System.Drawing.Point(158, 287);
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.Size = new System.Drawing.Size(200, 22);
            this.txtRezultat.TabIndex = 22;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(158, 364);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.ReadOnly = true;
            this.txtCijena.Size = new System.Drawing.Size(200, 22);
            this.txtCijena.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Cijena utakmice:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(16, 392);
            this.trackBar1.Maximum = 300;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(342, 56);
            this.trackBar1.TabIndex = 50;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // frmDodajUtakmicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 528);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtRezultat);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtMisljenje);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbPlacena);
            this.Controls.Add(this.cmbKat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtKolega2);
            this.Controls.Add(this.txtKolega1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtGostujucaEkipa);
            this.Controls.Add(this.txtDomacaEkipa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbUloga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSezona);
            this.Controls.Add(this.label1);
            this.Name = "frmDodajUtakmicu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj novu utakmicu";
            this.Load += new System.EventHandler(this.frmDodajUtakmicu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSezona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUloga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDomacaEkipa;
        private System.Windows.Forms.TextBox txtGostujucaEkipa;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKolega1;
        private System.Windows.Forms.TextBox txtKolega2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbKat;
        private System.Windows.Forms.CheckBox cbPlacena;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMisljenje;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.TextBox txtRezultat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}