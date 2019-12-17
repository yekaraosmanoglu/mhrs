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
    public partial class mhrsDoktor : Form
    {
        public mhrsDoktor(Doktorlar Doktor)
        {
            InitializeComponent();
            _doktor = Doktor;
        }
        Doktorlar _doktor;
        mhrsHastalarim mhrsHastalarim;
        mhrsMuayeneOlustur mhrsMuayeneOlustur;
        private void mhrsDoktor_Load(object sender, EventArgs e)
        {
            gunaTasiyiciPanel.Controls.Clear();
            lblKullanici.Text = "Hoşgeldiniz\n" + _doktor.DoktorAdi + " " + _doktor.DoktorSoyadi;
            HastalarimFormGetir();
        }

        public void muayeneFormGetir(Randevular randevu)
        {
            gunaTasiyiciPanel.Controls.Clear();
            mhrsMuayeneOlustur = new mhrsMuayeneOlustur(randevu);
            mhrsMuayeneOlustur.TopLevel = false;
            gunaTasiyiciPanel.Controls.Add(mhrsMuayeneOlustur);
            mhrsMuayeneOlustur.Show();
            mhrsMuayeneOlustur.FormClosed += formclose;
        }

        private void formclose(object sender, FormClosedEventArgs e)
        {
            HastalarimFormGetir();
        }

        private void BtnHastalarim_Click(object sender, EventArgs e)
        {
            HastalarimFormGetir();
        }

        private void HastalarimFormGetir()
        {
            gunaTasiyiciPanel.Controls.Clear();
            mhrsHastalarim = new mhrsHastalarim(_doktor);
            mhrsHastalarim.TopLevel = false;
            gunaTasiyiciPanel.Controls.Add(mhrsHastalarim);
            mhrsHastalarim.Show();

            foreach (Control item in gunaTasiyiciPanel.Controls)
            {
                if (item.Name == mhrsHastalarim.Name)
                {
                    mhrsHastalarim.BringToFront();
                    return;
                }
            }
        }

        private void MhrsDoktor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            mhrsGiris mhrsGiris = new mhrsGiris();
            mhrsGiris.Show();
        }
    }
}
