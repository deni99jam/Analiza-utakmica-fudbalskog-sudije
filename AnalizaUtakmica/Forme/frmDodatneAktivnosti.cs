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
    public partial class frmDodatneAktivnosti : Form
    {
        KonekcijaNaBazu _db = ApkDb.Baza;
        public frmDodatneAktivnosti()
        {
            InitializeComponent();
            dgvAktivnosti.AutoGenerateColumns = false;
        }

        private void frmDodatneAktivnosti_Load(object sender, EventArgs e)
        {
            UcitajAktivnosti();
        }

        private void UcitajAktivnosti()
        {
            try
            {
                dgvAktivnosti.DataSource = null;
                dgvAktivnosti.DataSource = _db.DodatneAktivnosti.ToList();
                lblUkupno.Text = dgvAktivnosti.Rows.Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajDodatnuAktivnost forma = new frmDodajDodatnuAktivnost();
            this.Hide();
            forma.ShowDialog();
            UcitajAktivnosti();
            this.Show();
        }

        private void dgvAktivnosti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var obj = dgvAktivnosti.SelectedRows[0].DataBoundItem as DodatneAktivnosti;

            if (e.ColumnIndex == 2)
            {
                if (MessageBox.Show(Poruke.RemoveAktUpit, "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _db.DodatneAktivnosti.Remove(obj);
                    _db.SaveChanges();
                    UcitajAktivnosti();
                }
            }
        }
    }
}
