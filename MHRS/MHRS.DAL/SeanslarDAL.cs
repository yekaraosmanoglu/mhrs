using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.Entities;

namespace MHRS.DAL
{
    public class SeanslarDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;

        public SeanslarDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.MHRSConString);
        }

        public List<Seanslar> GetAllSeans()
        {
            List<Seanslar> seanslar = new List<Seanslar>();

            try
            {
                cmd = new SqlCommand("SELECT * FROM Seanslar", cnn);
                cnn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Seanslar seans = new Seanslar();


                    seans.SeansID = Convert.ToInt32(dr["SeansID"]);
                    seans.BaslagicSaati = (TimeSpan)(dr["BaslangicSaati"]);
                    seans.BitisSaati = (TimeSpan)(dr["BitisSaati"]);
                    seanslar.Add(seans);

                }
                return seanslar;
            }
            catch (Exception)
            {
                return seanslar;
            }
            finally
            {
                cnn.Close();
            }
        }

        public Seanslar GetSeansByID(int SeansID)
        {
            Seanslar seans = null;

            try
            {
                cmd = new SqlCommand("SELECT * FROM Seanslar where SeansID=@SeansID", cnn);
                cmd.Parameters.AddWithValue("@SeansID", SeansID);
                cnn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                seans = new Seanslar()
                {
                    SeansID = Convert.ToInt32(dr["SeansID"]),
                    BaslagicSaati = (TimeSpan)(dr["BaslangicSaati"]),
                    BitisSaati = (TimeSpan)(dr["BitisSaati"])
                };

                return seans;
            }
            catch (Exception)
            {
                return seans;
            }
            finally
            {
                cnn.Close();
            }
        }

        public List<Seanslar> BosSeanslar(int DoktorID, DateTime Date)
        {
            List<Seanslar> seanslar = new List<Seanslar>();

            try
            {
                cmd = new SqlCommand("select * from Seanslar where SeansID not in (select SeansID from Randevular where DoktorID = @DoktorID and Tarih = @Date)", cnn);
                cmd.Parameters.AddWithValue("@DoktorID", DoktorID);
                cmd.Parameters.AddWithValue("@Date", Date);
                cnn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    seanslar.Add(new Seanslar()
                    {
                        SeansID = Convert.ToInt32(dr["SeansID"]),
                        BaslagicSaati = (TimeSpan)(dr["BaslangicSaati"]),
                        BitisSaati = (TimeSpan)(dr["BitisSaati"])
                    });
                }
                return seanslar;
            }
            catch (Exception)
            {
                return seanslar;
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
