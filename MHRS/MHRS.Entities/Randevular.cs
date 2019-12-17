using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.Entities
{
    public class Randevular
    {
        public int RandevuID { get; set; }
        public int HastaID { get; set; }
        public int DoktorID { get; set; }
        public DateTime Tarih { get; set; }
        public int SeansID { get; set; }
        public int HastaneDetayID { get; set; }
        public bool MuayeneGerçeklestiMi { get; set; }
        public int TeshisID { get; set; }
        public bool TahlilGerekliMi { get; set; }
        public int ReceteID { get; set; }
        public string TeshisNotu { get; set; }
    }
}
