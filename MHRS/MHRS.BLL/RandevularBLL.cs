using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
    public class RandevularBLL
    {
        RandevularDAL _randevularDAL;
        public RandevularBLL()
        {
            _randevularDAL = new RandevularDAL();
        }
        public bool RandevuEkle(Randevular randevu)
        {
            RandevuKontrol(randevu.Tarih, randevu.SeansID,randevu.DoktorID);
            int result = _randevularDAL.AddRandevu(randevu);
            return result > 0;
        }

        public bool RandevuGuncelle(Randevular randevu)
        {
            int result = _randevularDAL.UpdateRandevu(randevu);
            return result > 0;
        }

        public bool RandevuyaReceteEkle(Randevular randevu)
        {
            int result = _randevularDAL.UpdateRandevuForRecete(randevu);
            return result > 0;
        }

        public bool RandevuSil(Randevular randevu)
        {
            int result = _randevularDAL.DeleteRandevu(randevu);
            return result > 0;
        }

        public List<Randevular> RandevulariGetir()
        {
            return _randevularDAL.GetAllRandevular();
        }

        public Randevular RandevuGetirRandevuID(int RandevuID)
        {
            return _randevularDAL.GetRandevuByID(RandevuID);
        }

        public List<Randevular> RandevularıGetirHastaID(int HastaID)
        {
            return _randevularDAL.GetRandevularByHastaID(HastaID);
        }

        public List<Randevular> RandevularıGetirDoktorID(int DoktorID)
        {
            return _randevularDAL.GetRandevularByDoktorID(DoktorID);
        }

        void RandevuKontrol(DateTime time,int seans,int doktorid)
        {
            List<Randevular> randevular = _randevularDAL.GetAllRandevular();
            foreach (var item in randevular)
            {
                if (item.SeansID==seans&&item.Tarih.Date==time.Date&&item.DoktorID==doktorid)
                {
                    throw new FullAppointmentException();
                }
            }

            TimeSpan sonuc = time.Date - DateTime.Now.Date;
            if (sonuc.TotalDays<=0)
            {
                throw new PastAppointmentException();
            }

            if (time.DayOfWeek==DayOfWeek.Sunday || time.DayOfWeek==DayOfWeek.Saturday)
            {
                throw new WeekendAppointmentException();
            }
        }

    }
}
