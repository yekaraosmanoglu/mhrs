using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.Entities;

namespace MHRS.DAL
{
    public class CinsiyetDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;

        public CinsiyetDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.MHRSConString); 
        }


        public List<Cinsiyet> GetAllCinsiyet()
        {
            List<Cinsiyet> cinsiyet = new List<Cinsiyet>();

            try
            {
                cmd = new SqlCommand(@"SELECT * FROM Cinsiyet", cnn);
                cnn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cinsiyet.Add(new Cinsiyet()
                    {
                        Kisaltma= Convert.ToChar(dr["Kisaltma"]),
                        Cinsiyeti = dr["Cinsiyeti"].ToString()
                    });
                }
                return cinsiyet;
            }
            catch (Exception)
            {
                throw new Exception("Cinsiyet bilgisi getirilemedi");
            }
            finally
            {
                cnn.Close();
            }
            
        }
    }
}
