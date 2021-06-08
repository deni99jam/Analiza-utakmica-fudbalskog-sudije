using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizaUtakmica.Klase
{
    [Table("Utakmica")]
    public class Utakmica
    {
        public int Id { get; set; }
        public virtual GlavniPomocni GlavniPomocni { get; set; }
        public string DomacaEkipa { get; set; }
        public string GostujucaEkipa { get; set; }
        public DateTime Datum { get; set; }
        public string Kolega1 { get; set; }
        public string Kolega2 { get; set; }
        public string MisljenjeOUtakmici { get; set; }
        public string Rezultat { get; set; }
        public virtual Kategorija Kategorija { get; set; }
        public bool Placena { get; set; }
        public int CijenaUtakmice { get; set; }
    }
}
