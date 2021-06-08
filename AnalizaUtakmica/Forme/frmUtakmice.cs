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
    public partial class frmUtakmice : Form
    {
        KonekcijaNaBazu _db = ApkDb.Baza;
        public frmUtakmice()
        {
            InitializeComponent();
            dgvUtakmice.AutoGenerateColumns = false;
            UcitajUtakmice();
        }

        private void UcitajUtakmice(List<Utakmica> obj = null)
        {
            dgvUtakmice.DataSource = null;
            if (obj == null)
                dgvUtakmice.DataSource = _db.Utakmice.ToList();
            else
                dgvUtakmice.DataSource = obj.ToList();
            Statistika();
        }

        private void Statistika()
        {
            lblUkupno.Text = _db.Utakmice.Count().ToString();
            lblPoPretrazi.Text = dgvUtakmice.Rows.Count.ToString();
        }

        private void FiltrirajUtakmice()
        {
            List<Utakmica> utakmice;
            if (cbSezona.Checked)
            {
                utakmice = new List<Utakmica>();
                foreach (var item in _db.SezonaUtakmice)
                {
                    if (item.Sezona == cmbSezona.SelectedItem as Sezona)
                    {
                        utakmice.Add(item.Utakmica);
                    }
                }
            }
            else
            {
                utakmice = _db.Utakmice.ToList();
            }
            if (cbUloga.Checked)
            {
                if (cmbUloga.SelectedIndex == 0)
                {
                    utakmice = utakmice.Where(x => x.GlavniPomocni.Id == 1).ToList();
                }
                else if (cmbUloga.SelectedIndex == 1)
                {
                    utakmice = utakmice.Where(x => x.GlavniPomocni.Id == 2).ToList();
                }
                else if (cmbUloga.SelectedIndex == 2)
                {
                    utakmice = utakmice.Where(x => x.GlavniPomocni.Id == 3).ToList();
                }
                else if (cmbUloga.SelectedIndex == 3)
                {
                    utakmice = utakmice.Where(x => x.GlavniPomocni.Id == 2 || x.GlavniPomocni.Id==3).ToList();
                }
            }
            if(cbKat.Checked)
            {
                utakmice = utakmice.Where(x => x.Kategorija.Id == int.Parse(cmbKategorija.SelectedValue.ToString())).ToList();
            }
            if(cbPlac.Checked)
            {
                if(cmbPlacena.SelectedIndex==0)
                {
                    utakmice = utakmice.Where(x => x.Placena == true).ToList();
                }
                else if (cmbPlacena.SelectedIndex == 1)
                {
                    utakmice = utakmice.Where(x => x.Placena == false).ToList();
                }
            }   
             UcitajUtakmice(utakmice);
        }


        private void dgvUtakmice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var obj = dgvUtakmice.SelectedRows[0].DataBoundItem as Utakmica;
            SezonaUtakmica obj2 = null;
            foreach (var item in _db.SezonaUtakmice)
            {
                if (item.Utakmica.Id == obj.Id)
                {
                    obj2 = item;
                    break;
                }
            }
            if (e.ColumnIndex == 10)
            {
                if (MessageBox.Show(Poruke.RemoveUtakUpit, "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _db.Utakmice.Remove(obj);
                    _db.SezonaUtakmice.Remove(obj2);
                    _db.SaveChanges();
                    FiltrirajUtakmice();
                }
            }
        }

        private void btnUtakmica_Click(object sender, EventArgs e)
        {
            frmDodajUtakmicu forma = new frmDodajUtakmicu();
            this.Hide();
            forma.ShowDialog();
            FiltrirajUtakmice();
            this.Show();
        }

        private void frmUtakmice_Load(object sender, EventArgs e)
        {
            UcitajKategorije();
            UcitajSezone();
        }
        private void UcitajSezone()
        {
            cmbSezona.DataSource = _db.Sezone.ToList();
            cmbSezona.ValueMember = "Id";
            cmbSezona.DisplayMember = "PunoIme";
        }
        private void UcitajKategorije()
        {
            cmbKategorija.DataSource = _db.Kategorije.ToList();
            cmbKategorija.ValueMember = "Id";
            cmbKategorija.DisplayMember = "NazivKategorije";
        }

        private void cbPretragaAll_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbUloga_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrirajUtakmice();
        }

        private void cmbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrirajUtakmice();
        }

        private void cmbSezona_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrirajUtakmice();
        }

        private void dgvUtakmice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var obj = dgvUtakmice.SelectedRows[0].DataBoundItem as Utakmica;
            SezonaUtakmica obj2 = null;
            foreach (var item in _db.SezonaUtakmice)
            {
                if(item.Utakmica.Id==obj.Id)
                {
                    obj2 = item;
                    break;
                }
            }
            frmInformacijeOUtakmici forma = new frmInformacijeOUtakmici(obj, obj2);
            this.Hide();
            forma.ShowDialog();
            FiltrirajUtakmice();
            this.Show();
        }
        private void cbUloga_CheckedChanged(object sender, EventArgs e)
        {
            FiltrirajUtakmice();
        }

        private void cbKat_CheckedChanged(object sender, EventArgs e)
        {
            FiltrirajUtakmice();
        }

        private void cbSezona_CheckedChanged(object sender, EventArgs e)
        {
            FiltrirajUtakmice();
        }

        private void cbPlac_CheckedChanged(object sender, EventArgs e)
        {
            FiltrirajUtakmice();
        }

        private void cmbPlacena_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrirajUtakmice();
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            frmIzvjestajUtakmice forma = new frmIzvjestajUtakmice(dgvUtakmice.DataSource as List<Utakmica>);
            forma.ShowDialog();
        }
    }
}
