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
    public partial class frmDodajSezonu : Form
    {
        KonekcijaNaBazu _db = ApkDb.Baza;
        public frmDodajSezonu()
        {
            InitializeComponent();
        }

        private void frmDodajSezonu_Load(object sender, EventArgs e)
        {
            if (dtpDatum.Value.Month > 6)
            {
                textBox1.Text = $"{(dtpDatum.Value.Year).ToString()}/{(dtpDatum.Value.Year + 1 - 2000).ToString()}";
                textBox2.Text = "1";
            }
            else
            {
                textBox1.Text = $"{(dtpDatum.Value.Year - 1).ToString()}/{(dtpDatum.Value.Year - 2000).ToString()}";
                textBox2.Text = "2";
            }
        }

        private void dtpDatum_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDatum.Value.Month > 6)
            {
                textBox1.Text = $"{(dtpDatum.Value.Year).ToString()}/{(dtpDatum.Value.Year + 1 - 2000).ToString()}";
                textBox2.Text = "1";
            }
            else
            {
                textBox1.Text = $"{(dtpDatum.Value.Year - 1).ToString()}/{(dtpDatum.Value.Year - 2000).ToString()}";
                textBox2.Text = "2";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                if (_db.Sezone.Where(x => x.GodinaSezone == textBox1.Text && x.DioSezone.ToString() == textBox2.Text).Count() == 0)
                {
                    _db.Sezone.Add(new Sezona()
                    {
                        GodinaSezone=textBox1.Text,
                        DioSezone=int.Parse(textBox2.Text)
                    });
                    _db.SaveChanges();
                    MessageBox.Show("Uspjesno ste dodali novu sezonu");
                    this.Close();
                }
                else
                    MessageBox.Show("Sezona vec postoji");
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(textBox1, err, Poruke.PraznoPolje)
                && Validator.ValidirajKontrolu(textBox2, err, Poruke.PraznoPolje);
        }
    }
}
