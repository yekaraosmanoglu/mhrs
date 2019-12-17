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
    public partial class mhrsRandevularim : Form
    {
        DoktorlarBLL _doktorlarBLL;
        Doktorlar _doktor;
        RandevularBLL _randevularBLL;
        Randevular _randevular;
        Hastalar _hasta;
        SeanslarBLL _seanslarBLL;
        Seanslar _seans;
        HastaneDetayBLL _hastaneDetayBLL;
        HastaneDetay _hastaneDetay;
        HastanelerBLL _hastanelerBLL;
        Hastaneler _hastane;
        PolikliniklerBLL _polikliniklerBLL;
        Poliklinikler _poliklinikler;
        DepartmanBLL _departmanBLL;
        Departmanlar _departmanlar;

        public mhrsRandevularim(Hastalar hasta)
        {
            InitializeComponent();
            _doktorlarBLL = new DoktorlarBLL();
            _randevularBLL = new RandevularBLL();
            _seanslarBLL = new SeanslarBLL();
            _hastaneDetayBLL = new HastaneDetayBLL();
            _hastanelerBLL = new HastanelerBLL();
            _polikliniklerBLL = new PolikliniklerBLL();
            _departmanBLL = new DepartmanBLL();
            _hastane = new Hastaneler();
            _doktor = new Doktorlar();
            _hasta = hasta;
            _poliklinikler = new Poliklinikler();
            _departmanlar = new Departmanlar();
        }

        private void mhrsRandevularim_Load(object sender, EventArgs e)
        {
            RandevulariListele();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            _randevular = (Randevular)dgvRandevularim.SelectedRows[0].Tag;

            DialogResult result = MessageBox.Show("Randevunuzu silmek üzeresiniz.", "Eminmisin ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _randevularBLL.RandevuSil(_randevular);
                RandevulariListele();
            }
        }

        void RandevulariListele()
        {
            dgvRandevularim.Rows.Clear();
            //dgvRandevularim.Refresh();
            List<Randevular> randevular = _randevularBLL.RandevularıGetirHastaID(_hasta.HastaID);
            foreach (var item in randevular)
            {
                _seans = _seanslarBLL.SeansGetir(item.SeansID);
                _doktor = _doktorlarBLL.DoktorGetir(item.DoktorID);
                _hastaneDetay = _hastaneDetayBLL.HastaneDetayGetir(item.HastaneDetayID);
                _hastane = _hastanelerBLL.HastaneGetir(_hastaneDetay.HastaneID);
                _poliklinikler = _polikliniklerBLL.PoliklinikGetir(_hastaneDetay.PolikinlikID);
                _departmanlar = _departmanBLL.DepartmanGetir(_hastaneDetay.DepertmanID);

                dgvRandevularim.Rows.Add(_doktor.DoktorAdi + " " + _doktor.DoktorSoyadi, item.Tarih.ToString("MM/dd/yyyy"), _seans.BaslagicSaati.ToString(@"hh\:mm") + " - " + _seans.BitisSaati.ToString(@"hh\:mm"), _hastane.HastaneAdi, _poliklinikler.PoliklinikAdi,_departmanlar.DepertmanAdi);


                dgvRandevularim.Rows[dgvRandevularim.Rows.Count - 1].Tag = item;
            }
        }
    }
}
