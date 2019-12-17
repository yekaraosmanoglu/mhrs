using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.Entities
{
    public class Eczacilar
    {
        public int EczaciID { get; set; }
        public string EczaciAdi { get; set; }
        public string EczaciSoyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public int RolID { get; set; }
        public char Cinsiyet { get; set; }
    }
}
