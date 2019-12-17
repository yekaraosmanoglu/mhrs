using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
    public class HastalarBLL
    {
        HastalarDAL _hastalarDAL;

        public HastalarBLL()
        {
            _hastalarDAL = new HastalarDAL();
        }

        public bool Ekle(Hastalar hasta)
        {
            AyniHastaTekrarEklenemez(hasta.HastaAdi, hasta.HastaSoyadi, hasta.KullaniciAdi);
            SifreKontrol(hasta.Sifre);
            MailKontrol(hasta.KullaniciAdi);
            AdKontrol(hasta.HastaAdi, hasta.HastaSoyadi);
            int result = _hastalarDAL.AddHasta(hasta);
            return result > 0;
        }

        public bool Duzenle(Hastalar hasta)
        {
            int result = _hastalarDAL.UpdateHasta(hasta);
            return result > 0;
        }

        public bool Delete(Hastalar hasta)
        {
            int result = _hastalarDAL.DeleteHasta(hasta);
            return result > 0;
        }

        public List<Hastalar> List()
        {
            return _hastalarDAL.GetAllHasta();
        }

        public Hastalar HastaGetir(int hastaId)
        {
            return _hastalarDAL.GetCHastaByID(hastaId);
        }

        void AyniHastaTekrarEklenemez(string ad, string soyad, string kullaniciadi)
        {
            List<Hastalar> hasta = _hastalarDAL.GetAllHasta();
            foreach (var item in hasta)
            {
                if (item.HastaAdi == ad && item.HastaSoyadi == soyad)
                {
                    throw new SameNameException();
                }
                if (item.KullaniciAdi == kullaniciadi)
                {
                    throw new SameUserNameException();
                }
            }

        }

        void SifreKontrol(string sifre)
        {
            char[] yasakli = new char[] { '\\', '/', ':', '*', '\"', '<', '>', '|' };
            foreach (char item in yasakli)
            {
                if (sifre.Contains(item))
                {
                    throw new PasswordCharacterException();
                }
            }
            if (sifre.Length < 8 || sifre.Length > 16)
            {
                throw new PasswordLenghtException();
            }
        }

        void MailKontrol(string mail)
        {
            string[] kontrol = new string[] { "@", ".com" };

            foreach (string item in kontrol)
            {
                if (!mail.Contains(item))
                {
                    throw new ErrorMailException();
                }
            }
            if (mail.Length < 8)
            {
                throw new ErrorLenghtMailException();
            }
        }

        void AdKontrol(string ad, string soyad)
        {
            if (ad.Length < 3)
            {
                throw new NameLenghtControlException();
            }
            if (soyad.Length < 1)
            {
                throw new SurnameLenghtControlException();
            }
        }
    }
}
