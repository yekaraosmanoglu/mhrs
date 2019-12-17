using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.Entities
{
    public class HastaneDetay
    {
        public int ID { get; set; }
        public int HastaneID { get; set; }
        public int PolikinlikID { get; set; }
        public int DepertmanID { get; set; }
        public int DoktorID { get; set; }
    }
}
