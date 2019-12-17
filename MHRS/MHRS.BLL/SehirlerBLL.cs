using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
    public class SehirlerBLL
    {
        SehirlerDAL _sehirler;
        public SehirlerBLL()
        {
            _sehirler = new SehirlerDAL();
        }
        public List<Sehirler> SehirleriGetir()
        {
            return _sehirler.GetAllSehirler();
        }

        public Sehirler SehirGetir(int SehirID)
        {
            return _sehirler.GetSehirByID(SehirID);
        }
    }
}
