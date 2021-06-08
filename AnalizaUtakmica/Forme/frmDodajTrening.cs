using AnalizaUtakmica.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizaUtakmica.Forme
{
    public partial class frmDodajTrening : Form
    {
        KonekcijaNaBazu _db = ApkDb.Baza;
        public frmDodajTrening()
        {
            InitializeComponent();
        }

        private void frmDodajTrening_Load(object sender, EventArgs e)
        {
            UcitajSezone();
        }

        private void UcitajSezone()
        {
            cmbSezona.DataSource = _db.Sezone.ToList();
            cmbSezona.ValueMember = "Id";
            cmbSezona.DisplayMember = "PunoIme";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(ValidirajUnos())
            {
                var tr=_db.Treninzi.Add(new Trening()
                {
                    Datum=dtpDatumTreninga.Value,
                    Prisustvovao=cbPrisustvovao.Checked,
                    Opis=txtOpis.Text
                });
                _db.SezonaTreninzi.Add(new SezonaTrening()
                {
                    Sezona = cmbSezona.SelectedItem as Sezona,
                    Trening = tr
                });
                _db.SaveChanges();
                MessageBox.Show("Uspjesno ste dodali novi trening!");
                this.Close();
            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(cmbSezona, err, "Polje mora biti uneseno!");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbSezona_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtOpis_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPrisustvovao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpDatumTreninga_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
