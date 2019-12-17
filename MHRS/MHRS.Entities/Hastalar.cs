using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.Entities
{
    public class Hastalar
    {
        public int HastaID { get; set; }
        public string HastaAdi { get; set; }
        public string HastaSoyadi { get; set; }
        public char Cinsiyeti { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public int RolID { get; set; }
    }
}
