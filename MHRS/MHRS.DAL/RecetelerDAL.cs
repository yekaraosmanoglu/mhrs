using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.Entities;

namespace MHRS.DAL
{
    public class RecetelerDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;

        public RecetelerDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.MHRSConString);
        }

        public List<Receteler> GetAllReceteByHastaID(int hastaID)
        {
            List<Receteler> receteler = new List<Receteler>();

            try
            {
                cmd = new SqlCommand("SELECT * FROM Receteler WHERE HastaID=@hastaID",cnn);
                cmd.Parameters.AddWithValue("@hastaID", hastaID);
                cnn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    receteler.Add(new Receteler()
                    {
                        ReceteID = Convert.ToInt32(dr["ReceteID"]),
                        Recete = dr["Recete"].ToString(),
                        DoktorID = Convert.ToInt32(dr["DoktorID"]),
                        HastaID = Convert.ToInt32(dr["HastaID"]),
                        RandevuID = Convert.ToInt32(dr["RandevuID"]),
                    });
                }
                return receteler;
            }
            catch (Exception)
            {
                return receteler;
            }
            finally
            {
                cnn.Close();
            }
        }

        public Receteler GetReceteByReceteID(int receteID)
        {
            Receteler recete = null;
            try
            {
                cmd = new SqlCommand("SELECT * FROM Receteler WHERE ReceteID=@receteID",cnn);
                cmd.Parameters.AddWithValue("@receteID", receteID);
                cnn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                recete = new Receteler()
                {
                    ReceteID = Convert.ToInt32(dr["ReceteID"]),
                    Recete = dr["Recete"].ToString(),
                    DoktorID = Convert.ToInt32(dr["DoktorID"]),
                    HastaID = Convert.ToInt32(dr["HastaID"]),
                    RandevuID = Convert.ToInt32(dr["RandevuID"]),
                };

                return recete;
            }
            catch (Exception)
            {
                return recete;
            }
            finally
            {
                cnn.Close();
            }
        }

        public Receteler GetReceteByRandevuID(int randevuID)
        {
            Receteler recete = null;
            try
            {
                cmd = new SqlCommand("SELECT * FROM Receteler WHERE RandevuID=@randevuID", cnn);
                cmd.Parameters.AddWithValue("@randevuID", randevuID);
                cnn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                recete = new Receteler()
                {
                    ReceteID = Convert.ToInt32(dr["ReceteID"]),
                    Recete = dr["Recete"].ToString(),
                    DoktorID = Convert.ToInt32(dr["DoktorID"]),
                    HastaID = Convert.ToInt32(dr["HastaID"]),
                    RandevuID = Convert.ToInt32(dr["RandevuID"]),
                };

                return recete;
            }
            catch (Exception)
            {
                return recete;
            }
            finally
            {
                cnn.Close();
            }
        }

        int CmdExecuteNonQuery()
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

        public int AddRecete(Receteler recete)
        {
            cmd = new SqlCommand("INSERT INTO Receteler (Recete,HastaID,DoktorID,RandevuID) VALUES (@recete,@hastaID,@doktorID,@randevuID) select scope_identity()", cnn);

            cmd.Parameters.AddWithValue("@recete", recete.Recete);
            cmd.Parameters.AddWithValue("@hastaID", recete.HastaID);
            cmd.Parameters.AddWithValue("@doktorID", recete.DoktorID);
            cmd.Parameters.AddWithValue("@randevuID", recete.RandevuID);

            try
            {
                cnn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
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

        public int UpdateRecete(Receteler recete)
        {
            cmd = new SqlCommand("UPDATE Receteler SET Recete=@recete,HastaID=@hastaID,DoktorID=@doktorID,RandevuID=@randevuID WHERE ReceteID=@receteID", cnn);

            cmd.Parameters.AddWithValue("@recete", recete.Recete);
            cmd.Parameters.AddWithValue("@hastaID", recete.HastaID);
            cmd.Parameters.AddWithValue("@doktorID", recete.DoktorID);
            cmd.Parameters.AddWithValue("@randevuID", recete.RandevuID);
            cmd.Parameters.AddWithValue("@receteID", recete.ReceteID);

            return CmdExecuteNonQuery();
        }

        public int DeleteRecete(Receteler recete)
        {
            cmd = new SqlCommand("DELETE FROM Receteler WHERE ReceteID=@receteID", cnn);

            cmd.Parameters.AddWithValue("@receteID", recete.ReceteID);

            return CmdExecuteNonQuery();
        }
    }
}
