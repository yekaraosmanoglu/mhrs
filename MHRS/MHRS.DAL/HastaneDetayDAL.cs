using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.Entities;

namespace MHRS.DAL
{
    public class HastaneDetayDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;

        public HastaneDetayDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.MHRSConString);
        }

        public List<HastaneDetay> GetAllHastaneDetay()
        {
            cmd = new SqlCommand("select * from hastanedetay", cnn);
            List<HastaneDetay> tumHastaneDetay = new List<HastaneDetay>();

            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tumHastaneDetay.Add(new HastaneDetay()
                    {
                        ID = Convert.ToInt32(reader["id"]),
                        HastaneID = Convert.ToInt32(reader["hastaneid"]),
                        PolikinlikID = Convert.ToInt32(reader["poliklinikid"]),
                        DepertmanID = Convert.ToInt32(reader["departmanid"]),
                        DoktorID = Convert.ToInt32(reader["doktorid"])
                    });

                }
                reader.Close();
                return tumHastaneDetay;

            }
            catch (Exception)
            {
                return tumHastaneDetay;
            }
            finally
            {
                cnn.Close();
            }


        }

        public HastaneDetay GetHastaneDetayByID(int hastaneDetayId)
        {
            cmd = new SqlCommand("select * from hastanedetay where id=@detayid", cnn);
            cmd.Parameters.AddWithValue("@detayid", hastaneDetayId);

            HastaneDetay detay = null;

            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                detay = new HastaneDetay()
                {
                    ID = Convert.ToInt32(reader["id"]),
                    HastaneID = Convert.ToInt32(reader["hastaneid"]),
                    PolikinlikID = Convert.ToInt32(reader["poliklinikid"]),
                    DepertmanID = Convert.ToInt32(reader["departmanid"]),
                    DoktorID = Convert.ToInt32(reader["doktorid"])
                };
                reader.Close();
                return detay;
            }
            catch (Exception)
            {
                return detay;
            }
            finally
            {
                cnn.Close();
            }
        }
        public HastaneDetay GetHastaneDetayID(int hastaneid, int poliklinikid, int departmanid, int doktorid)
        {
            cmd = new SqlCommand("select * from hastanedetay where hastaneid=@hastaneid and poliklinikid=@poliklinikid and departmanid=@departmanid and doktorid=@doktorid", cnn);
            
            cmd.Parameters.AddWithValue("@hastaneid", hastaneid);
            cmd.Parameters.AddWithValue("@poliklinikid", poliklinikid);
            cmd.Parameters.AddWithValue("@departmanid", departmanid);
            cmd.Parameters.AddWithValue("@doktorid", doktorid);

            HastaneDetay detay = null;

            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                detay = new HastaneDetay()
                {
                    ID = Convert.ToInt32(reader["id"]),
                    HastaneID = Convert.ToInt32(reader["hastaneid"]),
                    PolikinlikID = Convert.ToInt32(reader["poliklinikid"]),
                    DepertmanID = Convert.ToInt32(reader["departmanid"]),
                    DoktorID = Convert.ToInt32(reader["doktorid"])
                };
                reader.Close();
                return detay;
            }
            catch (Exception)
            {
                return detay;
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
