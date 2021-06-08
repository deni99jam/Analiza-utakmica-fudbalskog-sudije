using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizaUtakmica.Klase
{
    public class KonekcijaNaBazu: DbContext
    {
        public KonekcijaNaBazu(): base("PutanjaDoBaze")
        {

        }
        public virtual DbSet<Utakmica> Utakmice { get; set; }
        public virtual DbSet<Trening> Treninzi { get; set; }
        public virtual DbSet<Sezona> Sezone { get; set; }
        public virtual DbSet<SezonaTrening> SezonaTreninzi { get; set; }
        public virtual DbSet<SezonaUtakmica> SezonaUtakmice { get; set; }
        public virtual DbSet<GlavniPomocni> GlavniPomocni { get; set; }
        public virtual DbSet<Kategorija> Kategorije { get; set; }
        public virtual DbSet<Sastanak> Sastanci { get; set; }
        public virtual DbSet<SezonaSastanak> SezonaSastanci { get; set; }
        public virtual DbSet<DodatneAktivnosti> DodatneAktivnosti { get; set; }

    }
}
