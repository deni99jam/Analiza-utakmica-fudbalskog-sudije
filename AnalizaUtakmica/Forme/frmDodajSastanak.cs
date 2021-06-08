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
    public partial class frmDodajSastanak : Form
    {
        KonekcijaNaBazu _db = ApkDb.Baza;
        public frmDodajSastanak()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var sas = _db.Sastanci.Add(new Sastanak()
            {
                Datum = dtpDatumSastanka.Value,
                Prisustvovao = cbPrisustvovao.Checked,
                OpisSastanka = txtOpis.Text
            });
            _db.SezonaSastanci.Add(new SezonaSastanak()
            {
                Sezona = cmbSezona.SelectedItem as Sezona,
                Sastanak =  sas
            });
            _db.SaveChanges();
            MessageBox.Show("Uspjesno ste dodali novi sastanak!");
            this.Close();
        }

        private void frmDodajSastanak_Load(object sender, EventArgs e)
        {
            UcitajSezone();
        }
        private void UcitajSezone()
        {
            cmbSezona.DataSource = _db.Sezone.ToList();
            cmbSezona.ValueMember = "Id";
            cmbSezona.DisplayMember = "PunoIme";
        }
    }
}
