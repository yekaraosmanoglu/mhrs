using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MHRS.Entities;
using MHRS.BLL;

namespace MHRS.UIWinForm
{
    public partial class mhrsHasta : Form
    {
        Hastalar _hasta;
        public mhrsHasta(Hastalar hasta)
        {
            InitializeComponent();
            _hasta = hasta;
        }
        mhrsRandevuAl randevuAl;
        mhrsRandevularim randevularim;
        private void mhrsHasta_Load(object sender, EventArgs e)
        {
            randevuAl = new mhrsRandevuAl(_hasta);
            randevuAl.TopLevel = false;
            gunaTasiyiciPanel.Controls.Add(randevuAl);
            randevuAl.Show();

            lblHastaAdi.Text = "Hoşgeldiniz\n" + _hasta.HastaAdi.ToUpper()+" "+_hasta.HastaSoyadi.ToUpper() ;

        }

        private void gunaRandevularim_Click(object sender, EventArgs e)
        {
            gunaTasiyiciPanel.Controls.Clear();
            randevularim = new mhrsRandevularim(_hasta);
            randevularim.TopLevel = false;
            gunaTasiyiciPanel.Controls.Add(randevularim);
            randevularim.Show();

            //foreach (Control item in gunaTasiyiciPanel.Controls)
            //{
            //    if (item.Name != "mhrsRandevularim")
            //    {
            //        //gunaTasiyiciPanel.Controls.Remove(randevuAl);
            //        randevularim = new mhrsRandevularim();
            //        randevularim.TopLevel = false;
            //        gunaTasiyiciPanel.Controls.Add(randevularim);
            //        randevularim.Show();
            //    }
            //}

        }

        private void gunaRandevuAl_Click(object sender, EventArgs e)
        {
            gunaTasiyiciPanel.Controls.Clear();
            randevuAl = new mhrsRandevuAl(_hasta);
            randevuAl.TopLevel = false;
            gunaTasiyiciPanel.Controls.Add(randevuAl);
            randevuAl.Show();

            //foreach (Control item in gunaTasiyiciPanel.Controls)
            //{
            //    if (item.Name != "mhrsRandevuAl")
            //    {
            //        gunaTasiyiciPanel.Controls.Remove(randevularim);
            //        randevuAl = new mhrsRandevuAl();
            //        randevuAl.TopLevel = false;
            //        gunaTasiyiciPanel.Controls.Add(randevuAl);
            //        randevuAl.Show();  
            //    }
            //}
        }

        private void MhrsHasta_FormClosed(object sender, FormClosedEventArgs e)
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
