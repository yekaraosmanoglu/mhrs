using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
    public class TeshislerBLL
    {
        TeshislerDAL _teshislerDAL;
        public TeshislerBLL()
        {
            _teshislerDAL = new TeshislerDAL();
        }

        public List<Teshisler> TeshisleriGetir()
        {
            return _teshislerDAL.GetAllTeshisler();
        }

        public Teshisler TeshisGetir(int TeshisID)
        {
            return _teshislerDAL.GetTeshisByID(TeshisID);
        }

    }
}
