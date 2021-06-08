using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizaUtakmica.Klase
{
    [Table("GlavniPomocni")]
    public class GlavniPomocni
    {
        public int Id { get; set; }
        public string Pozicija { get; set; }
        public override string ToString()
        {
            return Pozicija;
        }
    }
}
