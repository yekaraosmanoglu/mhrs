using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.Entities;

namespace MHRS.DAL
{
    public class DoktorlarDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;

        public DoktorlarDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.MHRSConString);
        }

        public List<Doktorlar> GetAllDoktor()
        {
            cmd = new SqlCommand("select * from doktorlar", cnn);
            List<Doktorlar> doktorlar = new List<Doktorlar>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    doktorlar.Add(new Doktorlar()
                    {
                        DoktorID = Convert.ToInt32(reader["DoktorID"]),
                        DoktorAdi = reader["DoktorAdi"].ToString(),
                        DoktorSoyadi = reader["DoktorSoyadi"].ToString(),
                        KullaniciAdi = reader["KullaniciAdi"].ToString(),
                        Sifre = reader["Sifre"].ToString(),
                        Cinsiyeti = Convert.ToChar(reader["Cinsiyeti"]),
                        DepartmanID = Convert.ToInt32(reader["DepartmanID"]),
                        PolikinlikID = Convert.ToInt32(reader["PoliklinikID"]),
                        RolID = Convert.ToInt32(reader["RolID"])
                    });
                }
                reader.Close();
                return doktorlar;
            }
            catch (Exception)
            {
                return doktorlar;
            }
            finally
            {
                cnn.Close();
            }
        }

        public Doktorlar GetDoktorByID(int DoktorID)
        {
            cmd = new SqlCommand("select * from doktorlar where DoktorID=@DoktorID", cnn);
            cmd.Parameters.AddWithValue("@DoktorID", DoktorID);
            Doktorlar doktor = null;
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                doktor = new Doktorlar()
                {
                    DoktorID = Convert.ToInt32(reader["DoktorID"]),
                    DoktorAdi = reader["DoktorAdi"].ToString(),
                    DoktorSoyadi = reader["DoktorSoyadi"].ToString(),
                    KullaniciAdi = reader["KullaniciAdi"].ToString(),
                    Sifre = reader["Sifre"].ToString(),
                    Cinsiyeti = Convert.ToChar(reader["Cinsiyeti"]),
                    DepartmanID = Convert.ToInt32(reader["DepartmanID"]),
                    PolikinlikID = Convert.ToInt32(reader["PoliklinikID"]),
                    RolID = Convert.ToInt32(reader["RolID"])
                };
                return doktor;
            }
            catch (Exception)
            {
                return doktor;
            }
            finally
            {
                cnn.Close();
            }
        }

        public List<Doktorlar> GetDoktorlarByDepartmanID(int DepartmanID)
        {
            cmd = new SqlCommand("select * from doktorlar where departmanid=@DepartmanID", cnn);
            cmd.Parameters.AddWithValue("@departmanid", DepartmanID);
            List<Doktorlar> doktorlar = new List<Doktorlar>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    doktorlar.Add(new Doktorlar()
                    {
                        DoktorID = Convert.ToInt32(reader["DoktorID"]),
                        DoktorAdi = reader["DoktorAdi"].ToString(),
                        DoktorSoyadi = reader["DoktorSoyadi"].ToString(),
                        KullaniciAdi = reader["KullaniciAdi"].ToString(),
                        Sifre = reader["Sifre"].ToString(),
                        Cinsiyeti = Convert.ToChar(reader["Cinsiyeti"]),
                        DepartmanID = Convert.ToInt32(reader["DepartmanID"]),
                        PolikinlikID = Convert.ToInt32(reader["PoliklinikID"]),
                        RolID = Convert.ToInt32(reader["RolID"])
                    });
                }
               
                return doktorlar;
            }
            catch (Exception)
            {
                return doktorlar;
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
