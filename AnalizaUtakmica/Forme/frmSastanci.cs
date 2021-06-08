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
    public partial class frmSastanci : Form
    {
        KonekcijaNaBazu _db = ApkDb.Baza;
        public frmSastanci()
        {
            InitializeComponent();
            dgvSastanci.AutoGenerateColumns = false;
        }

        private void frmSastanci_Load(object sender, EventArgs e)
        {
            UcitajSezone();
            UcitajSastanke();
        }

        private void UcitajSastanke(List<Sastanak> obj=null)
        {
            try
            {
                dgvSastanci.DataSource = null;
                if (obj == null)
                {
                    dgvSastanci.DataSource = _db.Sastanci.ToList();
                }
                else
                {
                    dgvSastanci.DataSource = obj.ToList();
                }
                lblSastanciUkupno.Text = $"{_db.Sastanci.Where(x => x.Prisustvovao == true).Count()}/{_db.Sastanci.Count()}";
                BrojSastanakaPoSezoni();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }
        private void PretraziSastanke()
        {
            List<Sastanak> sastanci;
            if (cbSezona.Checked)
            {
                sastanci = new List<Sastanak>();
                foreach (var item in _db.SezonaSastanci)
                {
                    if (item.Sezona == comboBox1.SelectedItem as Sezona)
                    {
                        sastanci.Add(item.Sastanak);
                    }
                }
            }
            else
            {
                sastanci = _db.Sastanci.ToList();
            }
            if (cbPris.Checked)
            {
                if (cbPrisustvovao.Checked)
                    sastanci = sastanci.Where(x => x.Prisustvovao == true).ToList();
                else
                    sastanci = sastanci.Where(x => x.Prisustvovao == false).ToList();
            }
            UcitajSastanke(sastanci);
        }
        private void BrojSastanakaPoSezoni()
        {
            int index;
            bool parseOK = Int32.TryParse(comboBox1.SelectedValue.ToString(), out index);
            //var index = int.Parse(comboBox1.SelectedValue as string);
            int ukupno = _db.SezonaSastanci.Where(x => x.Sezona.Id == index).Count();
            int odradjeni = _db.SezonaSastanci.Where(x => x.Sezona.Id == index && x.Sastanak.Prisustvovao == true).Count();
            lblSastanciPoluszona.Text = $"{comboBox1.Text} {odradjeni}/{ukupno}";

        }
        private void UcitajSezone()
        {
            comboBox1.DataSource = _db.Sezone.ToList();
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "PunoIme";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PretraziSastanke();
        }

        private void cbSezona_CheckedChanged(object sender, EventArgs e)
        {
            PretraziSastanke();
        }

        private void cbPris_CheckedChanged(object sender, EventArgs e)
        {
            PretraziSastanke();
        }

        private void cbPrisustvovao_CheckedChanged(object sender, EventArgs e)
        {
            PretraziSastanke();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajSastanak forma = new frmDodajSastanak();
            this.Hide();
            forma.ShowDialog();
            PretraziSastanke();
            this.Show();
        }

        private void dgvSastanci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var obj = dgvSastanci.SelectedRows[0].DataBoundItem as Sastanak;
            SezonaSastanak obj2 = null;
            foreach (var item in _db.SezonaSastanci)
            {
                if (item.Sastanak.Id == obj.Id)
                {
                    obj2 = item;
                    break;
                }
            }
            if (e.ColumnIndex == 3)
            {
                if (MessageBox.Show(Poruke.RemoveSasUpit, "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _db.Sastanci.Remove(obj);
                    _db.SezonaSastanci.Remove(obj2);
                    _db.SaveChanges();
                    PretraziSastanke();
                }
            }
        }

        private void dgvSastanci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var obj = dgvSastanci.SelectedRows[0].DataBoundItem as Sastanak;
            SezonaSastanak obj2 = null;
            foreach (var item in _db.SezonaSastanci)
            {
                if (item.Sastanak.Id == obj.Id)
                {
                    obj2 = item;
                    break;
                }
            }
            frmInformacijeOSastanku forma = new frmInformacijeOSastanku(obj, obj2);
            this.Hide();
            forma.ShowDialog();
            PretraziSastanke();
            this.Show();
        }
    }
}
