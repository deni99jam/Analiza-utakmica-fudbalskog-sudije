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
    public partial class frmInformacijeOUtakmici : Form
    {
        KonekcijaNaBazu _db = ApkDb.Baza;
        Utakmica _utakmica;
        SezonaUtakmica _sezonaUtakmica;
        public frmInformacijeOUtakmici()
        {
            InitializeComponent();
        }
        public frmInformacijeOUtakmici(Utakmica utakmica, SezonaUtakmica sezonaUtakmica):this()
        {
            _utakmica = utakmica;
            _sezonaUtakmica = sezonaUtakmica;
        }

        private void frmInformacijeOUtakmici_Load(object sender, EventArgs e)
        {
            UcitajUloge();
            UcitajSezone();
            UcitajKategorije();
            UcitajPodatke();
        }
        private void UcitajKategorije()
        {
            cmbKat.DataSource = _db.Kategorije.ToList();
            cmbKat.ValueMember = "Id";
            cmbKat.DisplayMember = "NazivKategorije";
        }

        private void UcitajUloge()
        {
            cmbUloga.DataSource = _db.GlavniPomocni.ToList();
            cmbUloga.ValueMember = "Id";
            cmbUloga.DisplayMember = "Pozicija";
        }

        private void UcitajSezone()
        {
            cmbSezona.DataSource = _db.Sezone.ToList();
            cmbSezona.ValueMember = "Id";
            cmbSezona.DisplayMember = "PunoIme";
        }

        private void UcitajPodatke()
        {
            cmbSezona.SelectedItem = _sezonaUtakmica.Sezona;
            cmbUloga.SelectedItem = _utakmica.GlavniPomocni;
            txtDomacaEkipa.Text = _utakmica.DomacaEkipa;
            txtGostujucaEkipa.Text = _utakmica.GostujucaEkipa;
            dateTimePicker1.Value = _utakmica.Datum;
            txtKolega1.Text = _utakmica.Kolega1;
            txtKolega2.Text = _utakmica.Kolega2;
            txtRezultat.Text = _utakmica.Rezultat;
            cmbKat.SelectedItem = _utakmica.Kategorija;
            txtCijena.Text = _utakmica.CijenaUtakmice.ToString();
            cbPlacena.Checked = _utakmica.Placena;
            txtMisljenje.Text = _utakmica.MisljenjeOUtakmici;
            trackBar1.Value = _utakmica.CijenaUtakmice;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(ValidirajUnos())
            {
                _sezonaUtakmica.Sezona = cmbSezona.SelectedItem as Sezona;
                _utakmica.GlavniPomocni = cmbUloga.SelectedItem as GlavniPomocni;
                _utakmica.DomacaEkipa = txtDomacaEkipa.Text;
                _utakmica.GostujucaEkipa = txtGostujucaEkipa.Text;
                _utakmica.Datum = dateTimePicker1.Value;
                _utakmica.Kolega1 = txtKolega1.Text;
                _utakmica.Kolega2 = txtKolega2.Text;
                _utakmica.Rezultat = txtRezultat.Text;
                _utakmica.Kategorija = cmbKat.SelectedItem as Kategorija;
                _utakmica.CijenaUtakmice = int.Parse(txtCijena.Text);
                _utakmica.Placena = cbPlacena.Checked;
                _utakmica.MisljenjeOUtakmici = txtMisljenje.Text;
                _db.Entry(_utakmica).State = System.Data.Entity.EntityState.Modified;
                _db.Entry(_sezonaUtakmica).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                MessageBox.Show(Poruke.UpdateUtakmica);
                this.Close();
            }
        }
        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(cmbSezona, err, Poruke.PraznoPolje)
                && Validator.ValidirajKontrolu(cmbUloga, err, Poruke.PraznoPolje)
                && Validator.ValidirajKontrolu(txtDomacaEkipa, err, Poruke.PraznoPolje)
                && Validator.ValidirajKontrolu(txtGostujucaEkipa, err, Poruke.PraznoPolje)
                && Validator.ValidirajKontrolu(txtKolega1, err, Poruke.PraznoPolje)
                && Validator.ValidirajKontrolu(txtKolega2, err, Poruke.PraznoPolje)
                && Validator.ValidirajKontrolu(txtRezultat, err, Poruke.PraznoPolje)
                && Validator.ValidirajKontrolu(cmbKat, err, Poruke.PraznoPolje)
                && Validator.ValidirajKontrolu(txtMisljenje, err, Poruke.PraznoPolje);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtCijena.Text = trackBar1.Value.ToString();
        }
    }
}
