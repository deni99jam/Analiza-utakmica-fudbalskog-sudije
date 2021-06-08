using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizaUtakmica.Klase
{
    [Table("SezonaTrening")]

    public class SezonaTrening
    {
        public int Id { get; set; }
        public virtual Sezona Sezona { get; set; }
        public virtual Trening Trening { get; set; }
    }
}
