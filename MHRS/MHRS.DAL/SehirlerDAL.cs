using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.Entities;

namespace MHRS.DAL
{
    public class SehirlerDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;

        public SehirlerDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.MHRSConString);
        }

        //Tüm Şehirler
        public List<Sehirler> GetAllSehirler()
        {
            cmd = new SqlCommand("select * from sehirler", cnn);
            List<Sehirler> tumSehirler = new List<Sehirler>();

            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tumSehirler.Add(new Sehirler()
                    {
                        SehirID = Convert.ToInt32(reader["sehirid"]),
                        SehirAdi = reader["sehiradi"].ToString()
                    });

                }
                reader.Close();
                return tumSehirler;

            }
            catch (Exception)
            {
                return tumSehirler;
            }
            finally
            {
                cnn.Close();
            }
        }

        //id ile şehirler
        public Sehirler GetSehirByID(int sehirID)
        {
            cmd = new SqlCommand("select * from sehirler where sehirid=@sehid", cnn);
            cmd.Parameters.AddWithValue("@sehid", sehirID);

            Sehirler sehir = null;

            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                sehir = new Sehirler()
                {
                    SehirID = Convert.ToInt32(reader["sehirid"]),
                    SehirAdi = reader["sehiradi"].ToString()
                };
                reader.Close();
                return sehir;
            }
            catch (Exception)
            {
                return sehir;
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
