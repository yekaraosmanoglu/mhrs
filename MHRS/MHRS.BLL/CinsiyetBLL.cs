using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
    public class CinsiyetBLL
    {
        CinsiyetDAL _cinsiyetDAL;

        public CinsiyetBLL()
        {
            _cinsiyetDAL = new CinsiyetDAL();
        }

        public List<Cinsiyet> List()
        {
            return _cinsiyetDAL.GetAllCinsiyet();
        }

      

    }
}
