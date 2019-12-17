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
    public partial class mhrsGiris : Form
    {
        HastalarBLL _hastalarBLL;
        Hastalar _hastalar;
        DoktorlarBLL _doktorlarBLL;
        Doktorlar _doktorlar;
        EczacilarBLL _eczacilarBLL;
        Eczacilar _eczacilar;
        RollerBLL _rollerBLL;
        bool passChar;
        public mhrsGiris()
        {
            InitializeComponent();
            _hastalarBLL = new HastalarBLL();
            _doktorlarBLL = new DoktorlarBLL();
            _eczacilarBLL = new EczacilarBLL();
            _rollerBLL = new RollerBLL();


            passChar = true;
            tipPassShow.SetToolTip(picPassChar, "Şifreyi görmek için tıklayın.");
            picPassChar.BackgroundImage = Properties.Resources.icons8_show_password_100;
            txtSifre.PasswordChar = '*';
        }

        private void lblKaydol_Click(object sender, EventArgs e)
        {
            mhrsKayitOl mhrsKayitOl = new mhrsKayitOl();
            mhrsKayitOl.ShowDialog();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adınızı giriniz!");
                txtKullaniciAdi.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Lütfen şifrenizi giriniz!");
                txtSifre.Focus();
                return;
            }

            switch (cmbRol.SelectedIndex)
            {
                case 0:

                    _hastalar = new Hastalar();
                    List<Hastalar> hastalar = _hastalarBLL.List();

                    foreach (var item in hastalar)
                    {
                        if (item.KullaniciAdi == txtKullaniciAdi.Text)
                        {
                            if (item.Sifre == txtSifre.Text)
                            {
                                _hastalar = item;
                                mhrsHasta mhrsHasta = new mhrsHasta(_hastalar);
                                mhrsHasta.Show();
                                this.Hide();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Şifre hatalı!");
                                txtSifre.Focus();
                                return;
                            }
                        }
                    }
                    
                    if (_hastalar.HastaID == 0)
                    {
                        MessageBox.Show("E-Posta Hatalı !");
                        txtKullaniciAdi.Focus();
                    }
                    break;
                case 1:

                    _doktorlar = new Doktorlar();
                    List<Doktorlar> doktorlar = _doktorlarBLL.List();
                    foreach (var item in doktorlar)
                    {
                        if (item.KullaniciAdi == txtKullaniciAdi.Text)
                        {
                            if (item.Sifre == txtSifre.Text)
                            {
                                _doktorlar = item;
                                mhrsDoktor mhrsDoktor = new mhrsDoktor(_doktorlar);
                                mhrsDoktor.Show();
                                this.Hide();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Şifre hatalı!");
                                txtSifre.Focus();
                                return;
                            }
                        }
                    }
                    if (_doktorlar.DoktorID == 0)
                    {
                        MessageBox.Show("Böyle bir kullanıcı bulunamadı!");
                        txtKullaniciAdi.Focus();
                    }

                    break;
                case 2:
                    _eczacilar = new Eczacilar();
                    List<Eczacilar> eczacilar = _eczacilarBLL.List();
                    foreach (var item in eczacilar)
                    {
                        if (item.KullaniciAdi == txtKullaniciAdi.Text)
                        {
                            if (item.Sifre == txtSifre.Text)
                            {
                                _eczacilar = item;
                                mhrsEczaci mhrsEczaci = new mhrsEczaci(_eczacilar);
                                mhrsEczaci.Show();
                                this.Hide();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Şifre hatalı!");
                                txtSifre.Focus();
                                return;
                            }
                        }
                    }
                    if (_eczacilar.EczaciID == 0)
                    {
                        MessageBox.Show("Böyle bir kullanıcı bulunamadı!");
                        txtKullaniciAdi.Focus();
                    }
                    break;

                default:
                    break;
            }
        }

        private void mhrsGiris_Load(object sender, EventArgs e)
        {
            List<Roller> roller = _rollerBLL.RolleriGetir();

            foreach (var item in roller)
            {
                cmbRol.Items.Add(item.RolAdi);
            }
            cmbRol.SelectedIndex = 0;
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRol.SelectedIndex == 0)
            {
                lblKaydol.Visible = true;
                lblGiris.Text = "E-Posta Adresi";
            }
            else
            {
                lblGiris.Text = "Kullanıcı Adı";
                lblKaydol.Visible = false;
            }
            txtKullaniciAdi.Text = string.Empty;
            txtSifre.Text = string.Empty;
            txtKullaniciAdi.Focus();
        }

        private void PicPassChar_Click(object sender, EventArgs e)
        {
            if (passChar)
            {
                passChar = !passChar;
                picPassChar.BackgroundImage = Properties.Resources.icons8_hide_100;
                txtSifre.PasswordChar = '\0';
                tipPassShow.SetToolTip(picPassChar, "Şifreyi gizlemek için tıklayın.");
            }
            else
            {
                passChar = !passChar;
                picPassChar.BackgroundImage = Properties.Resources.icons8_show_password_100;
                txtSifre.PasswordChar = '*';
                tipPassShow.SetToolTip(picPassChar, "Şifreyi görmek için tıklayın.");
            }
        }
    }
}
