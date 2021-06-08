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
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void treninziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTreninzi forma = new frmTreninzi();
            forma.MdiParent = this;
            forma.Show();
        }

        private void frmGlavna_Load(object sender, EventArgs e)
        {

        }

        private void utakmiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUtakmice forma = new frmUtakmice();
            forma.MdiParent = this;
            forma.Show();
        }

        private void dodajSezonuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajSezonu forma = new frmDodajSezonu();
            forma.MdiParent = this;
            forma.Show();
        }

        private void sastanciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSastanci forma = new frmSastanci();
            forma.MdiParent = this;
            forma.Show();
        }

        private void dodatneAktivnostiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodatneAktivnosti forma = new frmDodatneAktivnosti();
            forma.MdiParent = this;
            forma.Show();
        }
    }
}
