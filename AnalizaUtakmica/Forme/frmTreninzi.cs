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
    public partial class frmTreninzi : Form
    {
        KonekcijaNaBazu _db = ApkDb.Baza;
        public frmTreninzi()
        {
            InitializeComponent();
            dgvTreninzi.AutoGenerateColumns = false;
        }

        private void frmTreninzi_Load(object sender, EventArgs e)
        {
            UcitajSezone();
            UcitajTreninge();
        }

        private void UcitajSezone()
        {
            comboBox1.DataSource = _db.Sezone.ToList();
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "PunoIme";
        }

        private void UcitajTreninge(List<Trening> obj=null)
        {
            try
            {
                dgvTreninzi.DataSource = null;
                if (obj == null)
                {
                    dgvTreninzi.DataSource = _db.Treninzi.ToList();
                }
                else
                {
                    dgvTreninzi.DataSource = obj.ToList();
                }
                lblTreninziUkupno.Text = $"{_db.Treninzi.Where(x => x.Prisustvovao == true).Count()}/{_db.Treninzi.Count()}";
                BrojTreningaPoSezoni();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajTrening forma = new frmDodajTrening();
            this.Hide();
            forma.ShowDialog();
            PretraziTreninge();
            this.Show();
            //UcitajTreninge();
        }

        private void BrojTreningaPoSezoni()
        {
            int index;
            bool parseOK = Int32.TryParse(comboBox1.SelectedValue.ToString(), out index);
            //var index = int.Parse(comboBox1.SelectedValue as string);
            int ukupno = _db.SezonaTreninzi.Where(x => x.Sezona.Id == index).Count();
            int odradjeni = _db.SezonaTreninzi.Where(x => x.Sezona.Id == index && x.Trening.Prisustvovao == true).Count();
            lblTreninziPoluszona.Text = $"{comboBox1.Text} {odradjeni}/{ukupno}";

        }

        private void PretraziTreninge()
        {
            List<Trening> treninzi;
            if (cbSezona.Checked)
            {
                treninzi = new List<Trening>();
                foreach (var item in _db.SezonaTreninzi)
                {
                    if (item.Sezona == comboBox1.SelectedItem as Sezona)
                    {
                        treninzi.Add(item.Trening);
                    }
                }
            }
            else
            {
                treninzi = _db.Treninzi.ToList();
            }
            if(cbPris.Checked)
            {
                if (cbPrisustvovao.Checked)
                    treninzi = treninzi.Where(x => x.Prisustvovao == true).ToList();
                else
                    treninzi = treninzi.Where(x => x.Prisustvovao == false).ToList();
            }
            UcitajTreninge(treninzi);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PretraziTreninge();
            BrojTreningaPoSezoni();
        }

        private void cbPrisustvovao_CheckedChanged(object sender, EventArgs e)
        {
            PretraziTreninge();
        }
        private void dgvTreninzi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var obj = dgvTreninzi.SelectedRows[0].DataBoundItem as Trening;
            SezonaTrening obj2 = null;
            foreach (var item in _db.SezonaTreninzi)
            {
                if (item.Trening.Id == obj.Id)
                {
                    obj2 = item;
                    break;
                }
            }
            if (e.ColumnIndex==3)
            {
                if (MessageBox.Show(Poruke.RemoveTrUpit,"Pitanje",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    _db.Treninzi.Remove(obj);
                    _db.SezonaTreninzi.Remove(obj2);
                    _db.SaveChanges();
                    PretraziTreninge();
                }
            }
        }

        private void dgvTreninzi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var obj = dgvTreninzi.SelectedRows[0].DataBoundItem as Trening;
            SezonaTrening obj2=null;
            foreach (var item in _db.SezonaTreninzi)
            {
                if (item.Trening.Id == obj.Id)
                {
                    obj2 = item;
                    break;
                }
            }
            frmInformacijeOTreningu forma = new frmInformacijeOTreningu(obj,obj2);
            this.Hide();
            forma.ShowDialog();
            PretraziTreninge();
            this.Show();
        }

        private void cbSezona_CheckedChanged(object sender, EventArgs e)
        {
            PretraziTreninge();
        }

        private void cbPris_CheckedChanged(object sender, EventArgs e)
        {
            PretraziTreninge();
        }
    }
}
