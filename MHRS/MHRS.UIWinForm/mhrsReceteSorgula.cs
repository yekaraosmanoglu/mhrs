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
    public partial class mhrsReceteSorgula : Form
    {
        public mhrsReceteSorgula()
        {
            InitializeComponent();
            _recete = new Receteler();
            _recetelerBLL = new RecetelerBLL();
            _hastalarBLL = new HastalarBLL();
            _hasta = new Hastalar();
            _doktor = new Doktorlar();
            _doktorlarBLL = new DoktorlarBLL();

        }

        Receteler _recete;
        RecetelerBLL _recetelerBLL;
        HastalarBLL _hastalarBLL;
        Hastalar _hasta;
        Doktorlar _doktor;
        DoktorlarBLL _doktorlarBLL;
        private void BtnSorgula_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtReceteNo.Text, out int receteNo))
            {
                _recete = _recetelerBLL.ReceteGetir(receteNo);
                if (_recete != null)
                {
                    _hasta = _hastalarBLL.HastaGetir(_recete.HastaID);
                    _doktor = _doktorlarBLL.DoktorGetir(_recete.DoktorID);
                    lblID.Text =(_hasta.HastaID).ToString();
                    lblAd.Text = _hasta.HastaAdi;
                    lblSoyad.Text = _hasta.HastaSoyadi;
                    lblDoc.Text = _doktor.DoktorAdi + " " + _doktor.DoktorSoyadi;
                    txtRecete.Text = _recete.Recete;
                    pnlRecete.Visible = true;
                }
                else
                {
                    MessageBox.Show("Girilen reçete bulunamadı!");
                    txtReceteNo.Focus();
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir reçete numarası giriniz!");
                txtReceteNo.Focus();

            }
        }
    }
}
