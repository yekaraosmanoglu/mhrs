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
    public partial class mhrsMuayeneOlustur : Form
    {
        public mhrsMuayeneOlustur(Randevular randevu)
        {
            InitializeComponent();
            _randevu = randevu;
            _hasta = _hastalarBLL.HastaGetir(randevu.HastaID);
            _doktor = _doktorlarBLL.DoktorGetir(randevu.DoktorID);
            TeshisleriGetir();
        }
        int sonreceteid = 0;

        Randevular _randevu = new Randevular();
        Hastalar _hasta = new Hastalar();
        Doktorlar _doktor = new Doktorlar();

        HastalarBLL _hastalarBLL = new HastalarBLL();
        DoktorlarBLL _doktorlarBLL = new DoktorlarBLL();
        TeshislerBLL _teshislerBLL = new TeshislerBLL();
        RandevularBLL _randevularBLL = new RandevularBLL();
        RecetelerBLL _recetelerBLL = new RecetelerBLL();


        private void MhrsMuayeneOlustur_Load(object sender, EventArgs e)
        {
            lblAd.Text = _hasta.HastaAdi;
            lblSoyad.Text = _hasta.HastaSoyadi;
            lblCinsiyet.Text = _hasta.Cinsiyeti.ToString();
            if (_recetelerBLL.ReceteGetirRandevuID(_randevu.RandevuID) != null)
            {
                sonreceteid = _recetelerBLL.ReceteGetirRandevuID(_randevu.RandevuID).ReceteID;
                lblReceteNo.Text = sonreceteid.ToString();
                btnReceteOlustur.Enabled = false;
                lblReceteNo.ForeColor = Color.Green;
            }

        }

        private void TeshisleriGetir()
        {
            List<Teshisler> teshisler = _teshislerBLL.TeshisleriGetir();
            cmbTeshis.DataSource = teshisler;
            cmbTeshis.DisplayMember = "TeshisAdi";
            cmbTeshis.ValueMember = "TeshisID";
        }

        private void BtnTamamla_Click(object sender, EventArgs e)
        {
            _randevu.TeshisID = Convert.ToInt32(cmbTeshis.SelectedValue);
            _randevu.TeshisNotu = txtTeshisNotu.Text;
            _randevu.TahlilGerekliMi = chkTahlil.Checked;
            _randevu.MuayeneGerçeklestiMi = true;
            if (int.TryParse(lblReceteNo.Text, out int rid))
            {
                _randevu.ReceteID = rid;
            }
            _randevularBLL.RandevuGuncelle(_randevu);
            MessageBox.Show("Muayene başarıyla tamamlandı.");
            lblReceteNo.Text = "...";
            this.Close();
        }

        private void BtnReceteOlustur_Click(object sender, EventArgs e)
        {
            mhrsReceteOlustur receteolustur = new mhrsReceteOlustur(_randevu);
            if (receteolustur.ShowDialog()==DialogResult.OK)
            {
                lblReceteNo.ForeColor = Color.Green;
                btnReceteOlustur.Enabled = false;
                lblReceteNo.Text = _randevu.ReceteID.ToString();
            }
        }

        private void BtnRandevuOlustur_Click(object sender, EventArgs e)
        {
            mhrsDoktorRandevuOlustur randevuolustur = new mhrsDoktorRandevuOlustur(_randevu);
            if (randevuolustur.ShowDialog()==DialogResult.OK)
            {
                btnRandevuOlustur.Enabled = false;
            }
        }
    }
}
