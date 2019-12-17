using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.Entities;
namespace MHRS.DAL
{
    //CURL
    public class RandevularDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;

        public RandevularDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.MHRSConString);
        }


        public int AddRandevu(Randevular randevu)
        {
            cmd = new SqlCommand("insert into randevular (HastaID,DoktorID,Tarih,SeansID,HastaneDetayID,MuayeneGerçeklestiMi) values (@HastaID,@DoktorID,@Tarih,@SeansID,@HastaneDetayID,@MuayeneGerçeklestiMi)", cnn);
            cmd.Parameters.AddWithValue("@HastaID", randevu.HastaID);
            cmd.Parameters.AddWithValue("@DoktorID", randevu.DoktorID);
            cmd.Parameters.AddWithValue("@Tarih", randevu.Tarih);
            cmd.Parameters.AddWithValue("@SeansID", randevu.SeansID);
            cmd.Parameters.AddWithValue("@HastaneDetayID", randevu.HastaneDetayID);
            cmd.Parameters.AddWithValue("@MuayeneGerçeklestiMi", randevu.MuayeneGerçeklestiMi);

            return ExecuteCommand();
        }

        public int DeleteRandevu(Randevular randevu)
        {
            cmd = new SqlCommand("delete from randevular where RandevuID=@RandevuID", cnn);
            cmd.Parameters.AddWithValue("@RandevuID", randevu.RandevuID);
            return ExecuteCommand();
        }

        public int UpdateRandevu(Randevular randevu)
        {
            cmd = new SqlCommand("update randevular set HastaID=@HastaID,DoktorID=@DoktorID,Tarih=@Tarih,SeansID=@SeansID,HastaneDetayID=@HastaneDetayID,MuayeneGerçeklestiMi=@MuayeneGerçeklestiMi,TeshisID=@TeshisID,TahlilGerekliMi=@TahlilGerekliMi,ReceteID=@ReceteID,TeshisNotu=@TeshisNotu where RandevuID=@RandevuID", cnn);
            cmd.Parameters.AddWithValue("@RandevuID", randevu.RandevuID);
            cmd.Parameters.AddWithValue("@HastaID", randevu.HastaID);
            cmd.Parameters.AddWithValue("@DoktorID", randevu.DoktorID);
            cmd.Parameters.AddWithValue("@Tarih", randevu.Tarih);
            cmd.Parameters.AddWithValue("@SeansID", randevu.SeansID);
            cmd.Parameters.AddWithValue("@HastaneDetayID", randevu.HastaneDetayID);
            cmd.Parameters.AddWithValue("@MuayeneGerçeklestiMi", randevu.MuayeneGerçeklestiMi);
            if (randevu.TeshisID > 0)
            {
                cmd.Parameters.AddWithValue("@TeshisID", randevu.TeshisID);
            }
            else
            {
                cmd.Parameters.AddWithValue("@TeshisID", DBNull.Value);
            }
            // cmd.Parameters.AddWithValue("@TeshisID", randevu.TeshisID);
            cmd.Parameters.AddWithValue("@TahlilGerekliMi", randevu.TahlilGerekliMi);
            //cmd.Parameters.AddWithValue("@ReceteID", randevu.ReceteID);
            if (randevu.ReceteID > 0)
            {
                cmd.Parameters.AddWithValue("@ReceteID", randevu.ReceteID);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ReceteID", DBNull.Value);
            }
            cmd.Parameters.AddWithValue("@TeshisNotu", randevu.TeshisNotu);
            return ExecuteCommand();
        }

        public int UpdateRandevuForRecete (Randevular randevu)
        {
            cmd = new SqlCommand("update randevular set ReceteID=@ReceteID where RandevuID=@RandevuID", cnn);
            cmd.Parameters.AddWithValue("@RandevuID", randevu.RandevuID);
            if (randevu.ReceteID > 0)
            {
                cmd.Parameters.AddWithValue("@ReceteID", randevu.ReceteID);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ReceteID", DBNull.Value);
            }
            return ExecuteCommand();
        }


        int ExecuteCommand()
        {
            try
            {
                if (cnn.State != System.Data.ConnectionState.Open)
                {
                    cnn.Open();
                }
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

        public List<Randevular> GetAllRandevular()
        {
            cmd = new SqlCommand("select * from Randevular", cnn);
            List<Randevular> randevular = new List<Randevular>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Randevular randevu = new Randevular();

                    randevu.RandevuID = Convert.ToInt32(reader["RandevuID"]);
                    randevu.HastaID = Convert.ToInt32(reader["HastaID"]);
                    randevu.DoktorID = Convert.ToInt32(reader["DoktorID"]);
                    randevu.Tarih = Convert.ToDateTime(reader["Tarih"]);
                    randevu.SeansID = Convert.ToInt32(reader["SeansID"]);
                    randevu.HastaneDetayID = Convert.ToInt32(reader["HastaneDetayID"]);
                    randevu.MuayeneGerçeklestiMi = Convert.ToBoolean(reader["MuayeneGerçeklestiMi"]);
                    if (int.TryParse(reader["TeshisID"].ToString(), out int teshisid))
                    {
                        randevu.TeshisID = teshisid;
                    }
                    if (int.TryParse(reader["ReceteID"].ToString(), out int receteid))
                    {
                        randevu.TeshisID = receteid;
                    }
                    if (Boolean.TryParse(reader["TahlilGerekliMi"].ToString(), out bool tahlil))
                    {
                        randevu.TahlilGerekliMi = tahlil;
                    }
                    else
                    {
                        randevu.TahlilGerekliMi = false;
                    }
                    if (reader["TeshisNotu"] != null)
                    {
                        randevu.TeshisNotu = reader["TeshisNotu"].ToString();
                    }
                    randevular.Add(randevu);

                }
                reader.Close();
                return randevular;
            }
            catch (Exception)
            {
                return randevular;
            }
            finally
            {
                cnn.Close();
            }
        }

        public Randevular GetRandevuByID(int RandevuID)
        {
            cmd = new SqlCommand("select * from randevular where RandevuID=@RandevuID", cnn);
            cmd.Parameters.AddWithValue("@RandevuID", RandevuID);
            Randevular randevu = null;
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                randevu = new Randevular()
                {
                    HastaID = Convert.ToInt32(reader["HastaID"]),
                    DoktorID = Convert.ToInt32(reader["DoktorID"]),
                    Tarih = Convert.ToDateTime(reader["Tarih"]),
                    SeansID = Convert.ToInt32(reader["SeansID"]),
                    HastaneDetayID = Convert.ToInt32(reader["HastaneDetayID"]),
                    MuayeneGerçeklestiMi = Convert.ToBoolean(reader["MuayeneGerçeklestiMi"]),
                    TeshisID = Convert.ToInt32(reader["TeshisID"]),
                    TahlilGerekliMi = Convert.ToBoolean(reader["TahlilGerekliMi"]),
                    ReceteID = Convert.ToInt32(reader["ReceteID"]),
                    TeshisNotu = reader["TeshisNotu"].ToString()
                };
                reader.Close();
                return randevu;
            }
            catch (Exception)
            {
                return randevu;
            }
            finally
            {
                cnn.Close();
            }
        }

        public List<Randevular> GetRandevularByHastaID(int HastaID)
        {
            cmd = new SqlCommand("select * from Randevular where HastaID=@HastaID", cnn);
            cmd.Parameters.AddWithValue("@HastaID", HastaID);
            List<Randevular> randevular = new List<Randevular>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    randevular.Add(new Randevular
                    {
                        RandevuID = Convert.ToInt32(reader["RandevuID"]),
                        HastaID = Convert.ToInt32(reader["HastaID"]),
                        DoktorID = Convert.ToInt32(reader["DoktorID"]),
                        Tarih = Convert.ToDateTime(reader["Tarih"]),
                        SeansID = Convert.ToInt32(reader["SeansID"]),
                        HastaneDetayID = Convert.ToInt32(reader["HastaneDetayID"]),
                        MuayeneGerçeklestiMi = Convert.ToBoolean(reader["MuayeneGerçeklestiMi"]),
                        //TeshisID = Convert.ToInt32(reader["TeshisID"]),
                        //TahlilGerekliMi = Convert.ToBoolean(reader["TahlilGerekliMi"]),
                        //ReceteID = Convert.ToInt32(reader["ReceteID"]),
                        //TeshisNotu = reader["TeshisNotu"].ToString()
                    });
                }
                reader.Close();
                return randevular;
            }
            catch (Exception)
            {
                return randevular;
            }
            finally
            {
                cnn.Close();
            }
        }
        public List<Randevular> GetRandevularByDoktorID(int DoktorID)
        {
            cmd = new SqlCommand("select * from Randevular where DoktorID=@DoktorID", cnn);
            cmd.Parameters.AddWithValue("@DoktorID", DoktorID);
            List<Randevular> randevular = new List<Randevular>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    randevular.Add(new Randevular
                    {
                        RandevuID = Convert.ToInt32(reader["RandevuID"]),
                        HastaID = Convert.ToInt32(reader["HastaID"]),
                        DoktorID = Convert.ToInt32(reader["DoktorID"]),
                        Tarih = Convert.ToDateTime(reader["Tarih"]),
                        SeansID = Convert.ToInt32(reader["SeansID"]),
                        HastaneDetayID = Convert.ToInt32(reader["HastaneDetayID"]),
                        MuayeneGerçeklestiMi = Convert.ToBoolean(reader["MuayeneGerçeklestiMi"]),
                        // TeshisID = Convert.ToInt32(reader["TeshisID"]),
                        // TahlilGerekliMi = Convert.ToBoolean(reader["TahlilGerekliMi"]),
                        //ReceteID = Convert.ToInt32(reader["ReceteID"]),
                        // TeshisNotu = reader["TeshisNotu"].ToString()
                    });
                }
                reader.Close();
                return randevular;
            }
            catch (Exception)
            {
                return randevular;
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
