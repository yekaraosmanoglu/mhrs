using MHRS.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.DAL
{
    public class RollerDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;

        public RollerDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.MHRSConString);
        }

        public List<Roller> GetAllRoller()
        {
            cmd = new SqlCommand("select * from roller", cnn);
            List<Roller> roller = new List<Roller>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    roller.Add(new Roller()
                    {
                        RolID = Convert.ToInt32(reader["RolID"]),
                        RolAdi = reader["RolAdi"].ToString()
                    }) ;
                }
                reader.Close();
                return roller;
            }
            catch (Exception)
            {
                return roller;
            }
            finally
            {
                cnn.Close();
            }
        }

        public Roller GetRolByID(int RolID)
        {
            cmd = new SqlCommand("select * from roller where RolID=@RolID", cnn);
            cmd.Parameters.AddWithValue("@RolID", RolID);
            Roller rol = null;
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                rol = new Roller()
                {
                    RolID = Convert.ToInt32(reader["RolID"]),
                    RolAdi = reader["RolAdi"].ToString()
                };
                return rol;
            }
            catch (Exception)
            {
                return rol;
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
