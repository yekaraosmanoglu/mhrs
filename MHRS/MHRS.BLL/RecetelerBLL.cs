using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
    public class RecetelerBLL
    {
        RecetelerDAL _recetelerDAL;
        public RecetelerBLL()
        {
            _recetelerDAL = new RecetelerDAL();
        }

        public int ReceteEkle(Receteler recete)
        {
            return _recetelerDAL.AddRecete(recete);
        }

        public bool ReceteGuncelle(Receteler recete)
        {
            int result = _recetelerDAL.UpdateRecete(recete);
            return result > 0;
        }

        public bool ReceteSil(Receteler recete)
        {
            int result = _recetelerDAL.DeleteRecete(recete);
            return result > 0;
        }

        public List<Receteler> ReceteleriGetirHastaID(int HastaID)
        {
            return _recetelerDAL.GetAllReceteByHastaID(HastaID);
        }

        public Receteler ReceteGetir(int ReceteID)
        {
            return _recetelerDAL.GetReceteByReceteID(ReceteID);
        }

        public Receteler ReceteGetirRandevuID(int RandevuID)
        {
            return _recetelerDAL.GetReceteByRandevuID(RandevuID);
        }

    }
}
