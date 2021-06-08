using AnalizaUtakmica.Klase;
using Microsoft.Reporting.WinForms;
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
    public partial class frmIzvjestajUtakmice : Form
    {
        List<Utakmica> _utakmica;
        public frmIzvjestajUtakmice()
        {
            InitializeComponent();
        }
        public frmIzvjestajUtakmice(List<Utakmica> utakmica):this()
        {
            _utakmica = utakmica;
        }

        private void frmIzvjestajUtakmice_Load(object sender, EventArgs e)
        {
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("BrojUtakmica", $"Broj utakmica: {_utakmica.Count}"));

            var listaUtakmica = new List<object>();
            for(int i=0;i<_utakmica.Count;i++)
            {
                Utakmica obj = _utakmica[i];
                listaUtakmica.Add(new
                {
                    GlavniPomocni=obj.GlavniPomocni.ToString(),
                    DomacaEkipa=obj.DomacaEkipa,
                    GostujucaEkipa=obj.GostujucaEkipa,
                    Datum=obj.Datum,
                    Kolega1=obj.Kolega1,
                    Kolega2 = obj.Kolega2,
                    Misljenje=obj.MisljenjeOUtakmici,
                    Rezultat=obj.Rezultat,
                    Kategorija=obj.Kategorija.ToString(),
                    Placena=obj.Placena?"DA":"NE"
                });
            }
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = listaUtakmica;
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
