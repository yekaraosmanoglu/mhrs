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
    public partial class mhrsRandevuAl : Form
    {
        SehirlerBLL _sehirlerBLL;
        IlcelerBLL _ilcelerBLL;
        HastanelerBLL _hastanelerBLL;
        PolikliniklerBLL _polikliniklerBLL;
        DepartmanBLL _departmanBLL;
        HastaneDetayBLL _hastaneDetay;
        SeanslarBLL _seanslarBLL;
        RandevularBLL _randevularBLL;
        Randevular _randevu;
        Hastalar _hasta;
        int seansID = 0;
        public mhrsRandevuAl(Hastalar hasta)
        {
            InitializeComponent();
            _sehirlerBLL = new SehirlerBLL();
            _ilcelerBLL = new IlcelerBLL();
            _hastanelerBLL = new HastanelerBLL();
            _polikliniklerBLL = new PolikliniklerBLL();
            _departmanBLL = new DepartmanBLL();
            _hastaneDetay = new HastaneDetayBLL();
            _seanslarBLL = new SeanslarBLL();
            _randevularBLL = new RandevularBLL();
            _randevu = new Randevular();
            _hasta = hasta;


            cmbSehir.DataSource = _sehirlerBLL.SehirleriGetir();
            cmbSehir.DisplayMember = "SehirAdi";
            cmbSehir.ValueMember = "SehirID";

            dtpTarih.Value = DateTime.Now.AddDays(1);
        }

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((Sehirler)cmbSehir.SelectedItem).SehirID;
            if (id >= 0)
            {
                cmbIlce.DataSource = _ilcelerBLL.IlceleriGetirSehirID(id);
                cmbIlce.DisplayMember = "IlceAdi";
                cmbIlce.ValueMember = "IlceID";

            }
        }

        private void cmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((Ilceler)cmbIlce.SelectedItem).IlceID;
            if (id > 0)
            {
                cmbHastane.DataSource = _hastanelerBLL.HastaneGetirIlceID(id);
                cmbHastane.DisplayMember = "HastaneAdi";
                cmbHastane.ValueMember = "HastaneID";

            }
        }

        private void cmbHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = ((Hastaneler)cmbHastane.SelectedItem).HastaneID;
            if (id > 0)
            {
                cmbPoliklinik.DataSource = _polikliniklerBLL.PoliklinikleriGetirHastaneID(id);
                cmbPoliklinik.DisplayMember = "PoliklinikAdi";
                cmbPoliklinik.ValueMember = "PoliklinikID";

            }

            if (id > 0)
            {
                cmbDepartman.DataSource = _departmanBLL.DepartmanGelByHastaneID(id);
                cmbDepartman.DisplayMember = "DepertmanAdi";
                cmbDepartman.ValueMember = "DepartmanID";

            }
        }

        private void cmbDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            int depID = ((Departmanlar)cmbDepartman.SelectedItem).DepartmanID;
            int HasID = ((Hastaneler)cmbHastane.SelectedItem).HastaneID;
            if (depID > 0 && HasID > 0)
            {
                cmbDoktor.DataSource = _departmanBLL.DoktorGetir(depID, HasID);
                cmbDoktor.DisplayMember = "AdSoyad";
                cmbDoktor.ValueMember = "DoktorID";
            }
        }

        private void SeanslariGetir()
        {

            try
            {
                int dokID = ((Doktorlar)cmbDoktor.SelectedItem).DoktorID;
                DateTime date = dtpTarih.Value.Date;
                if (dokID < 0 || date == null)
                {
                    return;
                }
                else
                {
                    pnlSeanslar.Controls.Clear();
                    List<Seanslar> tumSeanslar = _seanslarBLL.SeanslariGetir();
                    List<Seanslar> bosSeanslar = _seanslarBLL.BosSeansGetir(dokID, date);
                    foreach (var item in tumSeanslar)
                    {
                        Button btn = new Button();
                        btn.Tag = item;
                        btn.Text = item.BaslagicSaati.ToString(@"hh\:mm");
                        btn.Margin = new Padding(6, 3, 3, 3);
                        btn.Enabled = false;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderColor = Color.Red;
                        btn.Click += SeansSecim;
                        foreach (var bositem in bosSeanslar)
                        {
                            if (item.SeansID == bositem.SeansID && date > DateTime.Now.Date && dtpTarih.Value.DayOfWeek != DayOfWeek.Sunday && dtpTarih.Value.DayOfWeek != DayOfWeek.Saturday)
                            {
                                    btn.Enabled = true;
                                    btn.FlatAppearance.BorderColor = Color.Green;                               
                            }
                        }
                        pnlSeanslar.Controls.Add(btn);
                        seansID = 0;
                    }

                    foreach (Control item in pnlSeanslar.Controls)
                    {
                        item.BackColor = Control.DefaultBackColor;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SeansSecim(object sender, EventArgs e)
        {
            foreach (Control item in pnlSeanslar.Controls)
            {
                item.BackColor = Control.DefaultBackColor;
            }
            (sender as Button).BackColor = Color.Green;
            seansID = ((sender as Button).Tag as Seanslar).SeansID;
        }

        private void DtpTarih_ValueChanged(object sender, EventArgs e)
        {
            SeanslariGetir();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeanslariGetir();
        }

        private void BtnTamamla_Click(object sender, EventArgs e)
        {
            if (seansID == 0)
            {
                MessageBox.Show("Lütfen seans seçiniz!");
                return;
            }
            try
            {
                int hastaneid = (cmbHastane.SelectedItem as Hastaneler).HastaneID;
                int polid = (cmbPoliklinik.SelectedItem as Poliklinikler).PoliklinikID;
                int dokid = ((Doktorlar)cmbDoktor.SelectedItem).DoktorID;
                int depid = (cmbDepartman.SelectedItem as Departmanlar).DepartmanID;
                _randevu.Tarih = dtpTarih.Value.Date;
                _randevu.DoktorID = dokid;
                _randevu.HastaID = _hasta.HastaID;
                _randevu.SeansID = seansID;
                _randevu.MuayeneGerçeklestiMi = false;
                _randevu.HastaneDetayID = _hastaneDetay.HastaneDetayIDGetir(hastaneid, polid, depid, dokid).ID;
                _randevularBLL.RandevuEkle(_randevu);
                MessageBox.Show("Randevu oluşturuldu.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpTarih_ValueChanged_1(object sender, EventArgs e)
        {
            SeanslariGetir();
        }


    }
}
