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
    public partial class frmDodajDodatnuAktivnost : Form
    {
        KonekcijaNaBazu _db = ApkDb.Baza;
        public frmDodajDodatnuAktivnost()
        {
            InitializeComponent();
        }

        private void frmDodajDodatnuAktivnost_Load(object sender, EventArgs e)
        {
           
        }

        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(txtOpis, err, Poruke.PraznoPolje);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                _db.DodatneAktivnosti.Add(new DodatneAktivnosti()
                {
                    Datum = dtpDatumAktivnosti.Value,
                    Opis = txtOpis.Text
                });
                _db.SaveChanges();
                MessageBox.Show("Uspjesno ste dodali novu dodatnu aktivnost!");
                this.Close();
            }
        }
    }
}
