using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.Entities;

namespace MHRS.DAL
{
   public class HastalarDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;

        public HastalarDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.MHRSConString);
        }

        //Kayıt ekleme
        public int AddHasta(Hastalar hasta)
        {
            cmd = new SqlCommand("insert into hastalar (hastaadi,hastasoyadi,cinsiyeti,kullaniciadi,sifre,rolid) values (@ad,@soyad,@cinsiyet,@kulAdi,@sifresi,@rolidsi)", cnn);
            cmd.Parameters.AddWithValue("@ad", hasta.HastaAdi);
            cmd.Parameters.AddWithValue("@soyad", hasta.HastaSoyadi);
            cmd.Parameters.AddWithValue("@cinsiyet", hasta.Cinsiyeti);
            cmd.Parameters.AddWithValue("@kulAdi", hasta.KullaniciAdi);
            cmd.Parameters.AddWithValue("@sifresi", hasta.Sifre);
            cmd.Parameters.AddWithValue("@rolidsi", hasta.RolID);
            return ExecuteCommand();
        }

        //Kayıt Güncelleme
        public int UpdateHasta(Hastalar hasta)
        {
            cmd = new SqlCommand("update hastalar set hastaadi=@ad,hastasoyadi=@soyad,cinsiyeti=@cinsiyet,kullaniciadi=@kulAdi,sifre=@sifresi,rolid=@rolidsi", cnn);
            cmd.Parameters.AddWithValue("@ad", hasta.HastaAdi);
            cmd.Parameters.AddWithValue("@soyad", hasta.HastaSoyadi);
            cmd.Parameters.AddWithValue("@cinsiyet", hasta.Cinsiyeti);
            cmd.Parameters.AddWithValue("@kulAdi", hasta.KullaniciAdi);
            cmd.Parameters.AddWithValue("@sifresi", hasta.Sifre);
            cmd.Parameters.AddWithValue("@rolidsi", hasta.RolID);
            return ExecuteCommand();
        }

        //Kayıt Silme
        public int DeleteHasta(Hastalar hasta)
        {
            cmd = new SqlCommand("delete from hastalar where hastaid=@hastaidsi", cnn);
            cmd.Parameters.AddWithValue("@hastaidsi", hasta.HastaID);
            return ExecuteCommand();
        }

        //Kayıtların hepsini getirme
        public List<Hastalar> GetAllHasta()
        {
            cmd = new SqlCommand("select * from hastalar", cnn);
            List<Hastalar> tumHastalar = new List<Hastalar>();

            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tumHastalar.Add(new Hastalar()
                    {
                        HastaID = Convert.ToInt32(reader["hastaid"]),
                        HastaAdi = reader["hastaadi"].ToString(),
                        HastaSoyadi = reader["hastasoyadi"].ToString(),
                        Cinsiyeti = Convert.ToChar(reader["cinsiyeti"]),
                        KullaniciAdi = reader["kullaniciadi"].ToString(),
                        Sifre = reader["sifre"].ToString(),
                        RolID = Convert.ToInt32(reader["rolid"])

                    });

                }
                reader.Close();
                return tumHastalar;

            }
            catch (Exception)
            {
                return tumHastalar;
            }
            finally
            {
                cnn.Close();
            }

        }

        //kaydı id'sine göre getirme
        public Hastalar GetCHastaByID(int hastaid)
        {
            cmd = new SqlCommand("select * from hastalar where hastaid=@hastaidsi", cnn);
            cmd.Parameters.AddWithValue("@hastaidsi", hastaid);

            Hastalar hasta = null;

            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                hasta = new Hastalar()
                {
                    HastaID = Convert.ToInt32(reader["hastaid"]),
                    HastaAdi = reader["hastaadi"].ToString(),
                    HastaSoyadi = reader["hastasoyadi"].ToString(),
                    Cinsiyeti =Convert.ToChar (reader["cinsiyeti"]),
                    KullaniciAdi = reader["kullaniciadi"].ToString(),
                    Sifre = reader["sifre"].ToString(),
                    RolID = Convert.ToInt32(reader["rolid"])
                };
                reader.Close();
                return hasta;
            }
            catch (Exception)
            {
                return hasta;
            }
            finally
            {
                cnn.Close();
            }
        }




        int ExecuteCommand()
        {
            try
            {
                cnn.Open();
                return cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
