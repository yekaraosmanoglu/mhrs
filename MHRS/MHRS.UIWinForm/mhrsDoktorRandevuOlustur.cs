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
    public partial class mhrsDoktorRandevuOlustur : Form
    {
        public mhrsDoktorRandevuOlustur(Randevular randevu)
        {
            InitializeComponent();
            _randevu = randevu;
            dtpTarih.Value = DateTime.Now.AddDays(1);
        }
        Randevular _randevu = new Randevular();
        RandevularBLL _randevularBLL = new RandevularBLL();
        SeanslarBLL _seanslarBLL = new SeanslarBLL();
        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                Randevular yeniRandevu = new Randevular();
                yeniRandevu.DoktorID = _randevu.DoktorID;
                yeniRandevu.HastaID = _randevu.HastaID;
                yeniRandevu.HastaneDetayID = _randevu.HastaneDetayID;
                yeniRandevu.Tarih = dtpTarih.Value;
                yeniRandevu.SeansID = Convert.ToInt32(cmbSeans.SelectedValue);

                _randevularBLL.RandevuEkle(yeniRandevu);

                MessageBox.Show("Yeni randevu başarıyla oluşturuldu.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void MhrsDoktorRandevuOlustur_Load(object sender, EventArgs e)
        {
            SeanslariGetir();
            dtpTarih.Value = DateTime.Now.Date.AddDays(1);
        }
        void SeanslariGetir()
        {
            List<Seanslar> seanslar = _seanslarBLL.BosSeansGetir(_randevu.DoktorID, dtpTarih.Value.Date);
            DataTable dt = new DataTable();
            dt.Columns.Add("SeansID");
            dt.Columns.Add("Saat");
            foreach (var item in seanslar)
            {
                dt.Rows.Add(item.SeansID, item.BaslagicSaati + " - " + item.BitisSaati);
            }
            cmbSeans.DataSource = dt;
            cmbSeans.ValueMember = "SeansID";
            cmbSeans.DisplayMember = "Saat";

        }

        private void DtpTarih_ValueChanged(object sender, EventArgs e)
        {
            SeanslariGetir();
        }
    }
}
