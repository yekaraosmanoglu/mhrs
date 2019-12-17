using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
    public class EczacilarBLL
    {
        EczacilarDAL _eczacilarDAL;

        public EczacilarBLL()
        {
            _eczacilarDAL = new EczacilarDAL();
        }

        public List<Eczacilar> List()
        {
            return _eczacilarDAL.GetAllEczaci();
        }

        public Eczacilar EczaciGetir(int EczaciID)
        {
            return _eczacilarDAL.GetEczaciByID(EczaciID);
        }

    
    }
}
