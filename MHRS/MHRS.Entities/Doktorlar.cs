using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.Entities
{
    public class Doktorlar
    {
        public int DoktorID { get; set; }
        public string DoktorAdi { get; set; }
        public string DoktorSoyadi { get; set; }
        public char Cinsiyeti { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public int RolID { get; set; }
        public int DepartmanID { get; set; }
        public int PolikinlikID { get; set; }

        public string AdSoyad { get { return DoktorAdi + " " + DoktorSoyadi; } }
    }
}
