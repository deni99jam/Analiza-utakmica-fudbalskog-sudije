using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizaUtakmica.Klase
{
    [Table("Sastanak")]
    public class Sastanak
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public string OpisSastanka { get; set; }
        public bool Prisustvovao { get; set; }
    }
}
