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
    public partial class mhrsEczaci : Form
    {
        Eczacilar _eczaci;
        public mhrsEczaci(Eczacilar eczaci)
        {
            InitializeComponent();
            _eczaci = eczaci;
        }
        mhrsReceteSorgula mhrsReceteSorgula;
        mhrsHastaReceteGecmisi mhrsHastaReceteGecmisi;
        private void mhrsEczaci_Load(object sender, EventArgs e)
        {
            lblEczaciAdi.Text = "Hoşgeldiniz\n" + _eczaci.EczaciAdi.ToUpper() +" "+_eczaci.EczaciSoyadi.ToUpper();

            mhrsReceteSorgula = new mhrsReceteSorgula();
            mhrsReceteSorgula.TopLevel = false;
            gunaTasiyiciPanel.Controls.Add(mhrsReceteSorgula);
            mhrsReceteSorgula.Show();
        }

        private void gunaReceteSorgula_Click(object sender, EventArgs e)
        {
            foreach (Control item in gunaTasiyiciPanel.Controls)
            {
                if (item.Name != "mhrsReceteSorgula")
                {
                    gunaTasiyiciPanel.Controls.Remove(mhrsHastaReceteGecmisi);
                    mhrsReceteSorgula = new mhrsReceteSorgula();
                    mhrsReceteSorgula.TopLevel = false;
                    gunaTasiyiciPanel.Controls.Add(mhrsReceteSorgula);
                    mhrsReceteSorgula.Show();
                }
            }
        }

        private void gunaReceteGecmisi_Click(object sender, EventArgs e)
        {
            foreach (Control item in gunaTasiyiciPanel.Controls)
            {
                if (item.Name != "mhrsHastaReceteGecmisi")
                {
                    gunaTasiyiciPanel.Controls.Remove(mhrsReceteSorgula);
                    mhrsHastaReceteGecmisi = new mhrsHastaReceteGecmisi();
                    mhrsHastaReceteGecmisi.TopLevel = false;
                    gunaTasiyiciPanel.Controls.Add(mhrsHastaReceteGecmisi);
                    mhrsHastaReceteGecmisi.Show();
                }
            }
        }

        private void MhrsEczaci_FormClosed(object sender, FormClosedEventArgs e)
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
