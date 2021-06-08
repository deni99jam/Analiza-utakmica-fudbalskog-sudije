using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizaUtakmica.Klase
{
    [Table("SezonaUtakmica")]
    public class SezonaUtakmica
    {
        public int Id { get; set; }
        public virtual Utakmica Utakmica { get; set; }
        public virtual Sezona Sezona { get; set; }
    }
}
