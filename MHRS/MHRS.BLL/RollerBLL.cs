using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;
namespace MHRS.BLL
{
    public class RollerBLL
    {
        RollerDAL _rollerDAL;
        public RollerBLL()
        {
            _rollerDAL = new RollerDAL();
        }

        public List<Roller> RolleriGetir()
        {
            return _rollerDAL.GetAllRoller();
        }

        public Roller RolGetirID(int RolID)
        {
            return _rollerDAL.GetRolByID(RolID);
        }

    }
}
