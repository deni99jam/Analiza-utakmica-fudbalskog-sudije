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
    public partial class frmDodajUtakmicu : Form
    {
        KonekcijaNaBazu _db = ApkDb.Baza;
        public frmDodajUtakmicu()
        {
            InitializeComponent();
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            UcitajSezone();
            UcitajUloge();
            UcitajKategorije();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void frmDodajUtakmicu_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(ValidirajUnos())
            {
                var obj = _db.Utakmice.Add(new Utakmica()
                {
                    GlavniPomocni=cmbUloga.SelectedItem as GlavniPomocni,
                    DomacaEkipa=txtDomacaEkipa.Text,
                    GostujucaEkipa=txtGostujucaEkipa.Text,
                    Datum=dateTimePicker1.Value,
                    Kolega1=txtKolega1.Text,
                    Kolega2=txtKolega2.Text,
                    MisljenjeOUtakmici=txtMisljenje.Text,
                    Rezultat=txtRezultat.Text,
                    Placena=cbPlacena.Checked,
                    Kategorija=cmbKat.SelectedItem as Kategorija,
                    CijenaUtakmice=int.Parse(txtCijena.Text)
                });
                _db.SezonaUtakmice.Add(new SezonaUtakmica()
                {
                    Sezona = cmbSezona.SelectedItem as Sezona,
                    Utakmica = obj
                });
                _db.SaveChanges();
                MessageBox.Show(Poruke.DodanaUtakmica);
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
