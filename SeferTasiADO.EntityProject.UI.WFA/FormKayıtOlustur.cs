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
    public partial class FormKayıtOlustur : FormBase
    {
        public FormKayıtOlustur()
        {
            InitializeComponent();
        }

        private void FormKayıtOlustur_Load(object sender, EventArgs e)
        {

        }

        private void tbKullaniciOlustur_Click(object sender, EventArgs e)
        {

        }

        private void FormKayıtOlustur_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnKullaniciOlusturKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKullaniciOlusturParola.Text != txtKullaniciOlusturParolaOnay.Text)
                {
                    MessageBox.Show("Parola Tekrarı Hatalı");
                    return;
                }
                List<GirisBilgisi> girisBilgileri = new GirisBilgisiRepo().GetAll();
                foreach (var item in girisBilgileri)
                {
                    if (item.KullaniciAdi.ToLower() == txtKullaniciOlusturKullaniciAdi.Text.ToLower())
                    {
                        MessageBox.Show("Kullanıcı Adı Kullanımda");
                        return;
                    }
                    else if (item.Mail.ToLower() == txtKullaniciOlusturMail.Text.ToLower())
                    {
                        MessageBox.Show("Mail Kullanımda");
                        return;
                    }
                }
                new GirisBilgisiRepo().Insert(new GirisBilgisi()
                {
                    KullaniciAdi = txtKullaniciOlusturKullaniciAdi.Text,
                    Mail = txtKullaniciOlusturMail.Text,
                    Parola = txtKullaniciOlusturParola.Text,
                    RolId = 2,
                    AktifMi = true,
                });
                GirisBilgisi sonEklenen = new GirisBilgisiRepo().GetAll().LastOrDefault();
                int Id = sonEklenen.GirisBilgisiId;

                new MusteriRepo().Insert(new Musteriler()
                {
                    Adi = txtKullaniciOlusturIsim.Text,
                    Adres = txtKullaniciOlusturAdres.Text,
                    AktifMi = true,
                    DogumTarihi = dateTimePicker1.Value.Date,
                    GirisBilgisiId = Id,
                    KayitTarihi = DateTime.Now,
                    SoyAdi = txtKullaniciOlusturSoyisim.Text,
                    Telefon = txtKullaniciOlusturTel.Text,
                    
                });
                MessageBox.Show("Kaydınız Oluşturuldu Giriş Yapabilirsiniz");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnFirmaKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirmaOlusturParola.Text != txtFirmaOlusturParolaTekrar.Text)
                {
                    MessageBox.Show("Parola Tekrarı Hatalı");
                    return;
                }
                List<GirisBilgisi> girisBilgileri = new GirisBilgisiRepo().GetAll();
                foreach (var item in girisBilgileri)
                {
                    if (item.KullaniciAdi.ToLower() == txtFirmaOlusturKullaniciAdi.Text.ToLower())
                    {
                        MessageBox.Show("Kullanıcı Adı Kullanımda");
                        return;
                    }
                    else if (item.Mail.ToLower() == txtFirmaOlusturMail.Text.ToLower())
                    {
                        MessageBox.Show("Mail Kullanımda");
                        return;
                    }
                }

                new GirisBilgisiRepo().Insert(new GirisBilgisi()
                {
                    KullaniciAdi = txtFirmaOlusturKullaniciAdi.Text,
                    Mail = txtFirmaOlusturMail.Text,
                    Parola = txtFirmaOlusturParola.Text,
                    RolId = 3,
                    AktifMi = true
                     
                });
                GirisBilgisi sonEklenen = new GirisBilgisiRepo().GetAll().LastOrDefault();
                int Id = sonEklenen.GirisBilgisiId;
                new FirmaRepo().Insert(new Firmalar()
                {

                    Adres = txtFirmaOlusturAdres.Text,
                    AktifMi = false,
                    GirisBilgisiId = Id,
                    KayitTarihi = DateTime.Now,
                    Telefon = txtFirmaOlusturTelefon.Text,
                    FirmaAdi = txtFirmaOlusturFirmaAdi.Text,
                    KurulusTarihi = dateTimePicker1.Value.Date,
                     MaximumSiparisSuresi =Convert.ToInt32(txtSiparisTeslim.Text),
                });
                MessageBox.Show("Kaydınız oluşturuldu Yönetici Onayının Ardından Sisteme giriş Yapabilirsiniz");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
