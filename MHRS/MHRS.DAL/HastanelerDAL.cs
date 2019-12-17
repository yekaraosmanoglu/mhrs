using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.Entities;

namespace MHRS.DAL
{
    public class HastanelerDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;

        public HastanelerDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.MHRSConString);
        }

        public List<Hastaneler> GetAllHastane()
        {
            cmd = new SqlCommand("select * from hastaneler", cnn);
            List<Hastaneler> hastaneler = new List<Hastaneler>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    hastaneler.Add(new Hastaneler()
                    {
                        HastaneID = Convert.ToInt32(reader["HastaneID"]),
                        HastaneAdi = reader["HastaneAdi"].ToString(),
                        HastaneAdresi = reader["HastaneAdresi"].ToString(),
                        HastaneTelefonu = reader["HastaneTelefonu"].ToString(),
                        SehirID= Convert.ToInt32(reader["SehirID"]),
                        IlceID= Convert.ToInt32(reader["IlceID"])
                    }) ; 
                }
                reader.Close();
                return hastaneler;
            }
            catch (Exception)
            {
                return hastaneler;
            }
            finally
            {
                cnn.Close();
            }
        }

        public Hastaneler GetHastaneByID(int HastaneID)
        {
            cmd = new SqlCommand("select * from Hastaneler where HastaneID=@HastaneID", cnn);
            cmd.Parameters.AddWithValue("@HastaneID", HastaneID);
            Hastaneler hastane = null;
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                hastane = new Hastaneler()
                {
                    HastaneID = Convert.ToInt32(reader["HastaneID"]),
                    HastaneAdi = reader["HastaneAdi"].ToString(),
                    HastaneAdresi = reader["HastaneAdresi"].ToString(),
                    HastaneTelefonu = reader["HastaneTelefonu"].ToString(),
                    SehirID = Convert.ToInt32(reader["SehirID"]),
                    IlceID = Convert.ToInt32(reader["IlceID"])
                };
                return hastane;
            }
            catch (Exception)
            {
                return hastane;
            }
            finally
            {
                cnn.Close();
            }
        }
        public List<Hastaneler> GetllceHastaneByID(int ilceId)
        {
            cmd = new SqlCommand("select * from Hastaneler where ilceid=@ilceid", cnn);
            cmd.Parameters.AddWithValue("@ilceid", ilceId);
            List<Hastaneler> hastaneler = new List<Hastaneler>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    hastaneler.Add(new Hastaneler()
                    {
                        HastaneID = Convert.ToInt32(reader["HastaneID"]),
                        HastaneAdi = reader["HastaneAdi"].ToString(),
                        HastaneAdresi = reader["HastaneAdresi"].ToString(),
                        HastaneTelefonu = reader["HastaneTelefonu"].ToString(),
                        SehirID = Convert.ToInt32(reader["SehirID"]),
                        IlceID = Convert.ToInt32(reader["IlceID"])
                    });
                }
                return hastaneler;
            }
            catch (Exception)
            {
                return hastaneler;
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
