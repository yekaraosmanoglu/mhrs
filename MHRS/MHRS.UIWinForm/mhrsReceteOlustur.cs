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
    public partial class mhrsReceteOlustur : Form
    {
        public mhrsReceteOlustur(Randevular randevu)
        {
            InitializeComponent();
            _randevu = randevu;
        }
        Randevular _randevu = new Randevular();
        Receteler _recete = new Receteler();
        RecetelerBLL _recetelerBLL = new RecetelerBLL();
        RandevularBLL _randevularBLL = new RandevularBLL();

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRecete.Text))
            {
                MessageBox.Show("Reçete kısmı boş bırakılamaz.");
                return;
            }
            _recete.DoktorID = _randevu.DoktorID;
            _recete.HastaID = _randevu.HastaID;
            _recete.RandevuID = _randevu.RandevuID;
            _recete.Recete = txtRecete.Text;
            int rid = _recetelerBLL.ReceteEkle(_recete);
            _randevu.ReceteID = rid;
            _randevularBLL.RandevuyaReceteEkle(_randevu);
          //  mhrsMuayeneOlustur frm = (mhrsMuayeneOlustur)(Application.OpenForms["mhrsMuayeneOlustur"]);
            //frm.Controls["lblReceteNo"].Text = rid.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
