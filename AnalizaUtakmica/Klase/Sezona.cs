using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizaUtakmica.Klase
{
    [Table("Sezona")]
    public class Sezona
    {
        public int Id { get; set; }
        public string GodinaSezone { get; set; }
        public int DioSezone { get; set; }
        public string PunoIme { 
            get
            {
                return $"{GodinaSezone} {DioSezone.ToString()}.polusezona";
            }
        }
        public override string ToString()
        {
            return $"{GodinaSezone} {DioSezone.ToString()}.polusezona";
        }
    }
}
