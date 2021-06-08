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
    public partial class frmInformacijeODodatnojAktivnosti : Form
    {
        KonekcijaNaBazu _db = ApkDb.Baza;
        DodatneAktivnosti _dodatneAktivnosti;
        public frmInformacijeODodatnojAktivnosti()
        {
            InitializeComponent();
        }
        public frmInformacijeODodatnojAktivnosti(DodatneAktivnosti dodatneAktivnosti):this()
        {
            _dodatneAktivnosti = dodatneAktivnosti;
        }

        private void frmInformacijeODodatnojAktivnosti_Load(object sender, EventArgs e)
        {
            UcitajAktivnost();
        }

        private void UcitajAktivnost()
        {
            dtpDatumAktivnosti.Value = _dodatneAktivnosti.Datum;
            txtOpis.Text = _dodatneAktivnosti.Opis;
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            _dodatneAktivnosti.Datum = dtpDatumAktivnosti.Value;
            _dodatneAktivnosti.Opis = txtOpis.Text;
            _db.Entry(_dodatneAktivnosti).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
            MessageBox.Show("Uspjesno ste izmijenili dodatnu aktivnost!");
            this.Close();
        }
    }
}
