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
    public partial class frmInformacijeOTreningu : Form
    {
        KonekcijaNaBazu _db = ApkDb.Baza;
        Trening _trening;
        SezonaTrening _sezonaTrening;
        public frmInformacijeOTreningu()
        {
            InitializeComponent();
        }
        
        public frmInformacijeOTreningu(Trening trening, SezonaTrening sezonaTrening):this()
        {
            _trening = trening;
            _sezonaTrening = sezonaTrening;
        }
        private void UcitajSezone()
        {
            cmbSezona.DataSource = _db.Sezone.ToList();
            cmbSezona.ValueMember = "Id";
            cmbSezona.DisplayMember = "PunoIme";
        }
        private void UcitajPodatke()
        {
            dtpDatumTreninga.Value = _trening.Datum;
            cbPrisustvovao.Checked = _trening.Prisustvovao;
            cmbSezona.SelectedItem = _sezonaTrening.Sezona;
            txtOpis.Text = _trening.Opis;
        }
        private void frmInformacijeOTreningu_Load(object sender, EventArgs e)
        {
            UcitajSezone();
            UcitajPodatke();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _trening.Datum = dtpDatumTreninga.Value;
            _trening.Opis = txtOpis.Text;
            _trening.Prisustvovao = cbPrisustvovao.Checked;
            _sezonaTrening.Sezona = cmbSezona.SelectedItem as Sezona;
            _db.Entry(_trening).State = System.Data.Entity.EntityState.Modified;
            _db.Entry(_sezonaTrening).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
            MessageBox.Show("Uspjesno ste uradili update treninga!");
            this.Close();
        }
    }
}
