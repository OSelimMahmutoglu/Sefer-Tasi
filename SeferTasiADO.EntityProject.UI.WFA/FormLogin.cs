using SeferTasiADO.EntityProject.BLL.Repository;
using SeferTasiADO.EntityProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeferTasiADO.EntityProject.UI.WFA
{
    public partial class FormLogin : FormBase
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void txtKullaniciAdi_MouseClick(object sender, MouseEventArgs e)
        {
            txtKullaniciAdi.Text = null;
        }

        private void txtKullaniciSifre_MouseClick(object sender, MouseEventArgs e)
        {
            txtKullaniciSifre.Text = null;
        }

        private void llKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormKayıtOlustur YeniKayit = new FormKayıtOlustur();
            YeniKayit.ShowDialog();
        }
        FormYonetici frmYonetici = new FormYonetici();
        FormFirma frmFirma = new FormFirma();
        FormKullanici frmMusteri = new FormKullanici();

        public static Yoneticiler LoginYonetici = new Yoneticiler();
        public static Musteriler LoginMusteri = new Musteriler();
        public static Firmalar LoginFirmalar = new Firmalar();


        private void btnKullaniciGiris_Click(object sender, EventArgs e)
        {
            try
            {
                GirisBilgisi girisBilgisi = new GirisBilgisiRepo().GirisIdsiGetir(txtKullaniciAdi.Text, txtKullaniciSifre.Text);
                if (girisBilgisi == null) throw new Exception("Kullanıcı adı veya şifre hatalı");

                if (girisBilgisi.RolId == 1)
                {
                    LoginYonetici = new YoneticiRepo().YoneticiGetir(girisBilgisi);
                    frmYonetici.ShowDialog();
                }
                if (girisBilgisi.RolId == 2)
                {
                    LoginMusteri = new MusteriRepo().MusteriyiGetir(girisBilgisi);
                    if (LoginMusteri.AktifMi==true)
                        frmMusteri.ShowDialog();
                    else
                        MessageBox.Show("Kullanıcı Hesabı Yönetici Tarafından Kapatılmıştır\n Bir Yanlışlık Olduğunu Düşünüyorsanız Yönetici İle İletişime Geçin");
                }
                if (girisBilgisi.RolId == 3)
                {
                    LoginFirmalar = new FirmaRepo().FirmayiGetir(girisBilgisi);
                    if (LoginFirmalar.AktifMi == true)
                        frmFirma.ShowDialog();
                   else
                        MessageBox.Show("Firma Hesabı Yönetici Tarafından Kapatılmıştır\n Bir Yanlışlık Olduğunu Düşünüyorsanız Yönetici İle İletişime Geçin");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnKullaniciGiris.PerformClick();
        }

        private void FormLogin_KeyUp(object sender, KeyEventArgs e)
        {
           
            btnKullaniciGiris.PerformClick();
        }
    }
}
