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
    public partial class mhrsHastalarim : Form
    {
        public mhrsHastalarim(Doktorlar Doktor)
        {
            InitializeComponent();
            _doktor = Doktor;
            _hastalarBLL = new HastalarBLL();
            _randevularBLL = new RandevularBLL();
            _seanslarBLL = new SeanslarBLL();
        }
        HastalarBLL _hastalarBLL;
        RandevularBLL _randevularBLL;
        SeanslarBLL _seanslarBLL;
        Doktorlar _doktor = new Doktorlar();
        Hastalar _hasta = new Hastalar();
        Seanslar _seans = new Seanslar();

        mhrsDoktor mhrsDoktor = (mhrsDoktor)(Application.OpenForms["mhrsDoktor"]);
        private void gunaDataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHastalarim.SelectedRows[0].Tag != null && !(dgvHastalarim.SelectedRows[0].Tag as Randevular).MuayeneGerçeklestiMi)
            {
                mhrsDoktor.muayeneFormGetir(dgvHastalarim.SelectedRows[0].Tag as Randevular);
            }
        }

        private void MhrsHastalarim_Load(object sender, EventArgs e)
        {
            List<Randevular> randevular = _randevularBLL.RandevularıGetirDoktorID(_doktor.DoktorID);
            foreach (var item in randevular)
            {
                _hasta = _hastalarBLL.HastaGetir(item.HastaID);
                _seans = _seanslarBLL.SeansGetir(item.SeansID);
                dgvHastalarim.Rows.Add(item.MuayeneGerçeklestiMi==true?"Tamamlandı":"Bekleniyor",_hasta.HastaAdi + " " + _hasta.HastaSoyadi,item.Tarih.ToShortDateString(), _seans.BaslagicSaati + " - " + _seans.BitisSaati);
                dgvHastalarim.Rows[dgvHastalarim.Rows.Count-1].Tag = item;
            }
        }
    }
}
