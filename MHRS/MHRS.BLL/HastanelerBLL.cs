using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
    public class HastanelerBLL
    {
        HastanelerDAL _hastaneler;
        public HastanelerBLL()
        {
            _hastaneler = new HastanelerDAL();
        }

        public List<Hastaneler> HastaneleriGetir()
        {
            return _hastaneler.GetAllHastane();
        }

        public Hastaneler HastaneGetir(int HastaneID)
        {
            return _hastaneler.GetHastaneByID(HastaneID);
        }

        public List<Hastaneler> HastaneGetirIlceID(int ilceID)
        {
            return _hastaneler.GetllceHastaneByID(ilceID);
        }

    }
}
