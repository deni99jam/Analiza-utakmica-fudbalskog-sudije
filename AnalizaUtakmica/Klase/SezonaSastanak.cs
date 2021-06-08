using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizaUtakmica.Klase
{
    [Table("SezonaSastanak")]
    public class SezonaSastanak
    {
        public int Id { get; set; }
        public Sezona Sezona { get; set; }
        public Sastanak Sastanak { get; set; }
    }
}
