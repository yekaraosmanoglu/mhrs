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
    public partial class mhrsKayitOl : Form
    {
        HastalarBLL _hastalarBLL;
        Hastalar _hasta;
        public mhrsKayitOl()
        {
            InitializeComponent();
            _hastalarBLL = new HastalarBLL();
            txtAd.KeyPress += HarfKontrol;
            txtSoyad.KeyPress += HarfKontrol;
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            try
            {
                _hasta = new Hastalar();
                _hasta.HastaAdi = txtAd.Text;
                _hasta.HastaSoyadi = txtSoyad.Text;
                _hasta.RolID = 1;

                if(radioErkek.Checked==false && radioKadin.Checked == false)
                {
                    MessageBox.Show("Cinsiyet Seçmediniz");
                }

                _hasta.Cinsiyeti = (radioErkek.Checked ? 'E' : 'K');//hiçbir şey seçili dğeilken ne kaydediyor bak
                _hasta.KullaniciAdi = txtKullaniciAdi.Text;
                _hasta.Sifre = txtSifre.Text;

                _hastalarBLL.Ekle(_hasta);
                MessageBox.Show("Kayıt başarılı.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HarfKontrol(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
      
    }
}
