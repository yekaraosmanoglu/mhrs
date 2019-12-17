using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.Entities
{
    public class Hastaneler
    {
        public int HastaneID { get; set; }
        public string HastaneAdi { get; set; }
        public string HastaneAdresi { get; set; }
        public string HastaneTelefonu { get; set; }
        public int SehirID { get; set; }
        public int IlceID { get; set; }
    }
}
