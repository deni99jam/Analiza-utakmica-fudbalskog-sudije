using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizaUtakmica.Klase
{
    [Table("Kategorija")]
    public class Kategorija
    {
        public int Id { get; set; }
        public string NazivKategorije { get; set; }
        public override string ToString()
        {
            return NazivKategorije;
        }
    }
}
