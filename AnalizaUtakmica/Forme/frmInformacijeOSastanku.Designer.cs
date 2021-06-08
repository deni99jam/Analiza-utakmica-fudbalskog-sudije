
namespace AnalizaUtakmica.Forme
{
    partial class frmInformacijeOSastanku
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
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSezona = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUredi = new System.Windows.Forms.Button();
            this.cbPrisustvovao = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDatumSastanka = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(24, 138);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(326, 120);
            this.txtOpis.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Opis:";
            // 
            // cmbSezona
            // 
            this.cmbSezona.FormattingEnabled = true;
            this.cmbSezona.Location = new System.Drawing.Point(150, 26);
            this.cmbSezona.Name = "cmbSezona";
            this.cmbSezona.Size = new System.Drawing.Size(200, 24);
            this.cmbSezona.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Sezona:";
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(216, 264);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(134, 29);
            this.btnUredi.TabIndex = 19;
            this.btnUredi.Text = "Uredi sastanak";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // cbPrisustvovao
            // 
            this.cbPrisustvovao.AutoSize = true;
            this.cbPrisustvovao.Location = new System.Drawing.Point(24, 272);
            this.cbPrisustvovao.Name = "cbPrisustvovao";
            this.cbPrisustvovao.Size = new System.Drawing.Size(97, 19);
            this.cbPrisustvovao.TabIndex = 18;
            this.cbPrisustvovao.Text = "Prisustvovao";
            this.cbPrisustvovao.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "DatumSastanka:";
            // 
            // dtpDatumSastanka
            // 
            this.dtpDatumSastanka.Location = new System.Drawing.Point(150, 68);
            this.dtpDatumSastanka.Name = "dtpDatumSastanka";
            this.dtpDatumSastanka.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumSastanka.TabIndex = 16;
            // 
            // frmInformacijeOSastanku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 308);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSezona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.cbPrisustvovao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatumSastanka);
            this.Name = "frmInformacijeOSastanku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled i update sastanka";
            this.Load += new System.EventHandler(this.frmInformacijeOSastanku_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSezona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.CheckBox cbPrisustvovao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDatumSastanka;
    }
}