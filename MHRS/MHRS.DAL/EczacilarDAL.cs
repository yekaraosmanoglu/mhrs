using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.Entities;

namespace MHRS.DAL
{
    public class EczacilarDAL
    {

        SqlConnection cnn;
        SqlCommand cmd;

        public EczacilarDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.MHRSConString);
        }

        public List<Eczacilar> GetAllEczaci()
        {
            List<Eczacilar> eczacilar = new List<Eczacilar>();

            try
            {
                cmd = new SqlCommand("SELECT * FROM Eczacilar", cnn);
                cnn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    eczacilar.Add(new Eczacilar()
                    {
                        EczaciID = Convert.ToInt32(dr["EczaciID"]),
                        EczaciAdi = dr["EczaciAdi"].ToString(),
                        EczaciSoyadi = dr["EczaciSoyadi"].ToString(),
                        KullaniciAdi = dr["KullaniciAdi"].ToString(),
                        Sifre = dr["Sifre"].ToString(),
                        Cinsiyet = Convert.ToChar(dr["Cinsiyet"]),
                        RolID = Convert.ToInt32(dr["RolID"])
                    });
                }
                return eczacilar;
            }
            catch (Exception)
            {
                return eczacilar;
            }
            finally
            {
                cnn.Close();
            }
        }

        public Eczacilar GetEczaciByID(int EczaciID)
        {
            Eczacilar eczaci = null;

            try
            {
                cmd = new SqlCommand("SELECT * FROM Eczacilar where EczaciID=@EczaciID", cnn);
                cmd.Parameters.AddWithValue("@EczaciID", EczaciID);
                cnn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                eczaci = new Eczacilar()
                {
                    EczaciID = Convert.ToInt32(dr["EczaciID"]),
                    EczaciAdi = dr["EczaciAdi"].ToString(),
                    EczaciSoyadi = dr["EczaciSoyadi"].ToString(),
                    KullaniciAdi = dr["KullaniciAdi"].ToString(),
                    Sifre = dr["Sifre"].ToString(),
                    Cinsiyet = Convert.ToChar(dr["Cinsiyeti"]),
                    RolID = Convert.ToInt32(dr["RolID"])
                };
                return eczaci;
            }
            catch (Exception)
            {
                return eczaci;
            }
            finally
            {
                cnn.Close();
            }
        }

    }
}
