using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.Entities;

namespace MHRS.DAL
{
    public class DepartmanlarDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;

        public DepartmanlarDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.MHRSConString);
        }

        public List<Departmanlar> GetAllDepartman()
        {
            cmd = new SqlCommand("select * from departmanlar", cnn);
            List<Departmanlar> tumDepartmanlar = new List<Departmanlar>();

            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tumDepartmanlar.Add(new Departmanlar()
                    {
                        DepartmanID = Convert.ToInt32(reader["departmanid"]),
                        DepertmanAdi = reader["departmanadi"].ToString()
                    });

                }
                reader.Close();
                return tumDepartmanlar;

            }
            catch (Exception)
            {
                return tumDepartmanlar;
            }
            finally
            {
                cnn.Close();
            }
        }

        public Departmanlar GetDepartmanByID(int depID)
        {
            cmd = new SqlCommand("select * from departmanlar where departmanid=@depid", cnn);
            cmd.Parameters.AddWithValue("@depid", depID);

            Departmanlar dept = null;

            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                dept = new Departmanlar()
                {
                    DepartmanID = Convert.ToInt32(reader["departmanid"]),
                    DepertmanAdi = reader["departmanadi"].ToString()
                };
                reader.Close();
                return dept;
            }
            catch (Exception)
            {
                return dept;
            }
            finally
            {
                cnn.Close();
            }
        }

        public List<Departmanlar> GetDepartmanByHastaneID(int hastaneId)
        {
            cmd = new SqlCommand("select distinct d.* from HastaneDetay as hd join Departmanlar as d on hd.DepartmanID=d.DepartmanID where hd.HastaneID=@hastaneID", cnn);
            cmd.Parameters.AddWithValue("@hastaneID", hastaneId);

            List<Departmanlar> dep = new List<Departmanlar>();

            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dep.Add(new Departmanlar()
                    {
                        DepertmanAdi = reader["DepartmanAdi"].ToString(),
                        DepartmanID = Convert.ToInt32(reader["departmanid"])
                    });
                }

                reader.Close();
                return dep;
            }
            catch (Exception)
            {
                return dep;
            }
            finally
            {
                cnn.Close();
            }
        }

        public List<Doktorlar> GetDoktorByDepartmanIDandHastaneID(int departmanID, int hastaneID)
        {
            cmd = new SqlCommand("select distinct doc.* from Doktorlar as doc join HastaneDetay as hd on doc.DoktorID=hd.DoktorID where hd.DepartmanID=@departmanID and hd.HastaneID=@hastaneID", cnn);
            cmd.Parameters.AddWithValue("@hastaneID", hastaneID);
            cmd.Parameters.AddWithValue("@departmanID", departmanID);

            List<Doktorlar> doc = new List<Doktorlar>();

            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    doc.Add(new Doktorlar()
                    {
                        DoktorID = Convert.ToInt32(reader["DoktorID"]),//ne varsa getir abi
                        DoktorAdi = reader["DoktorAdi"].ToString(),
                        DoktorSoyadi = reader["DoktorSoyadi"].ToString(),
                        Cinsiyeti = Convert.ToChar(reader["Cinsiyeti"]),
                        DepartmanID = Convert.ToInt32(reader["DepartmanID"]),
                        PolikinlikID = Convert.ToInt32(reader["PoliklinikID"]),
                        RolID = Convert.ToInt32(reader["RolID"]),
                        KullaniciAdi = reader["KullaniciAdi"].ToString(),
                        Sifre = reader["Sifre"].ToString()
                    });
                }
                reader.Close();
                return doc;
            }
            catch (Exception)
            {
                return doc;
            }
            finally
            {
                cnn.Close();
            }
        }

    }
}
