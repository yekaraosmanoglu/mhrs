using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.Entities;

namespace MHRS.DAL
{
    public class PolikinliklerDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;

        public PolikinliklerDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.MHRSConString);
        }

        public List<Poliklinikler> GetAllPolikinlikler()
        {
            cmd = new SqlCommand("select * from poliklinikler", cnn);
            List<Poliklinikler> tumPolikinlikler = new List<Poliklinikler>();

            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tumPolikinlikler.Add(new Poliklinikler()
                    {
                        PoliklinikID = Convert.ToInt32(reader["poliklinikid"]),
                        PoliklinikAdi = reader["poliklinikadi"].ToString(),
                        HastaneID = Convert.ToInt32(reader["hastaneid"])
                    });

                }
                reader.Close();
                return tumPolikinlikler;

            }
            catch (Exception)
            {
                return tumPolikinlikler;
            }
            finally
            {
                cnn.Close();
            }
        }

        public Poliklinikler GetPolikinlikByID(int polikinlikID)
        {
            cmd = new SqlCommand("select * from poliklinikler where poliklinikid=@polid", cnn);
            cmd.Parameters.AddWithValue("@polid", polikinlikID);

            Poliklinikler pol = null;

            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                pol = new Poliklinikler()
                {
                    PoliklinikID = Convert.ToInt32(reader["poliklinikid"]),
                    PoliklinikAdi = reader["poliklinikadi"].ToString(),
                    HastaneID = Convert.ToInt32(reader["hastaneid"])
                };
                reader.Close();
                return pol;
            }
            catch (Exception)
            {
                return pol;
            }
            finally
            {
                cnn.Close();
            }
        }

        public List<Poliklinikler> GetPolikinliklerByHastaneID(int HastaneID)
        {
            cmd = new SqlCommand("select * from poliklinikler where HastaneID=@HastaneID", cnn);
            cmd.Parameters.AddWithValue("@HastaneID", HastaneID);

            List<Poliklinikler> tumPolikinlikler = new List<Poliklinikler>();

            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tumPolikinlikler.Add(new Poliklinikler()
                    {
                        PoliklinikID = Convert.ToInt32(reader["poliklinikid"]),
                        PoliklinikAdi = reader["poliklinikadi"].ToString(),
                        HastaneID = Convert.ToInt32(reader["hastaneid"])
                    });

                }
                reader.Close();
                return tumPolikinlikler;

            }
            catch (Exception)
            {
                return tumPolikinlikler;
            }
            finally
            {
                cnn.Close();
            }
        }


    }
}
