using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
    public class IlcelerBLL
    {
        IlcelerDAL _ilcelerDAL;
        public IlcelerBLL()
        {
            _ilcelerDAL = new IlcelerDAL();
        }

        public List<Ilceler> IlceleriGetirSehirID(int SehirID)
        {
            return _ilcelerDAL.GetIlceBySehirID(SehirID);
        }
    }
}
