using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.Entities
{
    public class Seanslar
    {
        public int SeansID { get; set; }
        public TimeSpan BaslagicSaati { get; set; }
        public TimeSpan BitisSaati { get; set; }
    }
}
