using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MHRS.BLL;
using MHRS.Entities;

namespace MHRS.UIWinForm
{
    public partial class mhrsHastaReceteGecmisi : Form
    {
        public mhrsHastaReceteGecmisi()
        {
            InitializeComponent();
        }
        HastalarBLL _hastalarBLL = new HastalarBLL();
        DoktorlarBLL _doktorlarBLL = new DoktorlarBLL();
        RecetelerBLL _recetelerBLL = new RecetelerBLL();
        private void ReceteleriGetir(int HastaID)
        {
            dgvReceteler.Rows.Clear();
            List<Receteler> receteler = _recetelerBLL.ReceteleriGetirHastaID(HastaID);
            if (receteler.Count==0)
            {
                MessageBox.Show("Herhangi bir reçete kaydına rastlanmadı.");
                txtHastaID.Focus();
            }
            else
            {
                foreach (var item in receteler)
                {
                    string Doktor = _doktorlarBLL.DoktorGetir(item.DoktorID).DoktorAdi + " " + _doktorlarBLL.DoktorGetir(item.DoktorID).DoktorSoyadi;
                    string Hasta = _hastalarBLL.HastaGetir(item.HastaID).HastaAdi + " " + _hastalarBLL.HastaGetir(item.HastaID).HastaSoyadi;
                    dgvReceteler.Rows.Add(item.ReceteID, item.Recete, Hasta, Doktor);
                }
            }           
        }

        private void BtnSorgula_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtHastaID.Text, out int hastaID))
            {
                ReceteleriGetir(hastaID);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir hasta ID bilgisi giriniz.");
                txtHastaID.Focus();
            }
        }
    }
}
