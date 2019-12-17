using MHRS.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.DAL
{
    public class TeshislerDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;

        public TeshislerDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.MHRSConString);
        }

        public List<Teshisler> GetAllTeshisler()
        {
            cmd = new SqlCommand("select * from teshisler", cnn);
            List<Teshisler> teshisler = new List<Teshisler>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    teshisler.Add(new Teshisler()
                    {
                        TeshisID = Convert.ToInt32(reader["TeshisID"]),
                        TeshisAdi = reader["TeshisAdi"].ToString()
                    });
                }
                reader.Close();
                return teshisler;
            }
            catch (Exception)
            {
                return teshisler;
            }
            finally
            {
                cnn.Close();
            }
        }

        public Teshisler GetTeshisByID(int TeshisID)
        {
            cmd = new SqlCommand("select * from teshisler where TeshisID=@TeshisID", cnn);
            cmd.Parameters.AddWithValue("@TeshisID", TeshisID);
            Teshisler teshis = null;
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                teshis = new Teshisler()
                {
                    TeshisID = Convert.ToInt32(reader["TeshisID"]),
                    TeshisAdi = reader["TeshisAdi"].ToString()
                };
                return teshis;
            }
            catch (Exception)
            {
                return teshis;
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
