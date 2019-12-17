using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
    public class HastaneDetayBLL
    {
        HastaneDetayDAL _hastaneDetayDAL;

        public HastaneDetayBLL()
        {
            _hastaneDetayDAL = new HastaneDetayDAL();
        }

        public List<HastaneDetay> List()
        {
            return _hastaneDetayDAL.GetAllHastaneDetay();
        }

        public HastaneDetay HastaneDetayGetir(int hastaneDetayId)
        {
            return _hastaneDetayDAL.GetHastaneDetayByID(hastaneDetayId);
        }

        public HastaneDetay HastaneDetayIDGetir(int hastaneid, int poliklinikid, int departmanid, int doktorid)
        {
            return _hastaneDetayDAL.GetHastaneDetayID(hastaneid, poliklinikid, departmanid, doktorid);
        }
    }
}
