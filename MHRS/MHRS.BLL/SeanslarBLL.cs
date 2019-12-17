using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
    public class SeanslarBLL
    {
        SeanslarDAL _seanslarDAL;
        public SeanslarBLL()
        {
            _seanslarDAL = new SeanslarDAL();
        }

        public List<Seanslar> SeanslariGetir()
        {
            return _seanslarDAL.GetAllSeans();
        }

        public Seanslar SeansGetir(int SeansID)
        {
            return _seanslarDAL.GetSeansByID(SeansID);
        }

        public List<Seanslar> BosSeansGetir(int DoktorID,DateTime Date)
        {
            return _seanslarDAL.BosSeanslar(DoktorID, Date);
        }

    }
}
