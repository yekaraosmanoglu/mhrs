using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
    public class PolikliniklerBLL
    {
        PolikinliklerDAL _polikinliklerDAL;

        public PolikliniklerBLL()
        {
            _polikinliklerDAL = new PolikinliklerDAL();
        }

        public List<Poliklinikler> PoliklinikleriGetir()
        {
            return _polikinliklerDAL.GetAllPolikinlikler();
        }

        public Poliklinikler PoliklinikGetir(int PoliklinikID)
        {
            return _polikinliklerDAL.GetPolikinlikByID(PoliklinikID);
        }

        public List<Poliklinikler> PoliklinikleriGetirHastaneID(int HastaneID)
        {
            return _polikinliklerDAL.GetPolikinliklerByHastaneID(HastaneID);
        }
    }
}
