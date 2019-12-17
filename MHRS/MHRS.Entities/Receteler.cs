using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.Entities
{
    public class Receteler
    {
        public int ReceteID { get; set; }
        public string Recete { get; set; }
        public int HastaID { get; set; }
        public int DoktorID { get; set; }
        public int RandevuID { get; set; }
    }
}
