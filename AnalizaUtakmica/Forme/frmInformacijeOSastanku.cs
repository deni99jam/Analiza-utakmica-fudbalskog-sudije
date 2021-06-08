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
    public partial class frmInformacijeOSastanku : Form
    {
        KonekcijaNaBazu _db = ApkDb.Baza;
        Sastanak _sastanak;
        SezonaSastanak _sezonaSastanak;
        public frmInformacijeOSastanku()
        {
            InitializeComponent();
        }
        public frmInformacijeOSastanku(Sastanak sastanak, SezonaSastanak sezonaSastanak):this()
        {
            _sastanak = sastanak;
            _sezonaSastanak = sezonaSastanak;
        }

        private void frmInformacijeOSastanku_Load(object sender, EventArgs e)
        {
            UcitajSezone();
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            dtpDatumSastanka.Value = _sastanak.Datum;
            cbPrisustvovao.Checked = _sastanak.Prisustvovao;
            cmbSezona.SelectedItem = _sezonaSastanak.Sezona;
            txtOpis.Text = _sastanak.OpisSastanka;
        }

        private void UcitajSezone()
        {
            cmbSezona.DataSource = _db.Sezone.ToList();
            cmbSezona.ValueMember = "Id";
            cmbSezona.DisplayMember = "PunoIme";
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            _sastanak.Datum = dtpDatumSastanka.Value;
            _sastanak.OpisSastanka = txtOpis.Text;
            _sastanak.Prisustvovao = cbPrisustvovao.Checked;
            _sezonaSastanak.Sezona = cmbSezona.SelectedItem as Sezona;
            _db.Entry(_sastanak).State = System.Data.Entity.EntityState.Modified;
            _db.Entry(_sezonaSastanak).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
            MessageBox.Show("Uspjesno ste uradili update sastanka!");
            this.Close();
        }
    }
}
