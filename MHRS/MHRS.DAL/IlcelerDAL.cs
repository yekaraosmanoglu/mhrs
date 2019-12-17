using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.Entities;

namespace MHRS.DAL
{
    public class IlcelerDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;

        public IlcelerDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.MHRSConString);
        }

        public List<Ilceler> GetIlceBySehirID(int sehirID)
        {
            List<Ilceler> ilceler = new List<Ilceler>();

            try
            {
                cmd = new SqlCommand("SELECT * FROM Ilceler WHERE SehirID=@sehirID", cnn);
                cmd.Parameters.AddWithValue("@sehirID", sehirID);

                cnn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ilceler.Add(new Ilceler()
                    {
                        IlceID = Convert.ToInt32(dr["IlceID"]),
                        IlceAdi = dr["IlceAdi"].ToString(),
                        SehirID = Convert.ToInt32(dr["SehirID"])
                    });
                }

                return ilceler;
            }
            catch (Exception)
            {
                return ilceler;
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
