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
    public partial class FormYonetici : Form
    {
        public FormYonetici()
        {
            InitializeComponent();
        }
        private void Firmalar_Click(object sender, EventArgs e)
        {

        }
        private void FormYonetici_Load(object sender, EventArgs e)
        {
            this.Text = "Merhaba " + FormLogin.LoginYonetici.Adi + " " + FormLogin.LoginYonetici.SoyAdi;
            lstFirmalar.DisplayMember = "FirmaAdi";
            lstKullaniciler.DisplayMember = "Adi";
            cmbFirmalar.DisplayMember = "FirmaAdi";
             cmbFirmalar.DataSource=new FirmaRepo().GetAll();
             dgvFirmaHareketleri.DataSource = new FirmaRepo().FirmaSiparislerininUrunlereGoreFiyatlariniGetir((cmbFirmalar.SelectedItem as Firmalar).FirmaId);
            Yukle();
           // IstatistileriYukle();
        }
        //public void IstatistileriYukle()
        //{

        //    if (new SiparisRepo().SiparisRaporu(FormLogin.LoginFirmalar.FirmaId).ToList() == null) return;
        //    try
        //    {
        //        foreach (var item in new SiparisRepo().SiparisRaporu(FormLogin.LoginFirmalar.FirmaId).ToList())
        //        {
        //            ChartFirmaCiro.Series["UrunFiyat"].Points.AddXY(FormLogin.LoginFirmalar.FirmaAdi, item.ToplamFiyat);
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        MessageBox.Show("İstatistikler Yüklenemedi");
        //    }

        //}

        private void Yukle()
        {
            if (cbTumFirmalar.Checked)
                lstFirmalar.DataSource = new FirmaRepo().GetAll();
            else if(!cbTumFirmalar.Checked)
                lstFirmalar.DataSource = new FirmaRepo().GetAll().Where(x => x.AktifMi == true).ToList();

        
        
            if (cbTumMusteriler.Checked)
                lstKullaniciler.DataSource = new MusteriRepo().GetAll();

            else if(!cbTumMusteriler.Checked)
                lstKullaniciler.DataSource = new MusteriRepo().GetAll().Where(x => x.AktifMi == true).ToList();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cbTumFirmalar_CheckedChanged(object sender, EventArgs e)
        {
            Yukle();
        }

        private void lstFirmalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFirmalar.SelectedItem == null) return;

            Firmalar firma = lstFirmalar.SelectedItem as Firmalar;
            lstSeciliFirma.Items.Clear();
            lstSeciliFirma.Items.Add($"Firma Adi:{firma.FirmaAdi}");
            lstSeciliFirma.Items.Add($"Firma Adresi:{firma.Adres}");
            lstSeciliFirma.Items.Add($" Kuruluş Yılı: {firma.KurulusTarihi.Date.Year} ");
            lstSeciliFirma.Items.Add($"Telefon:{firma.Telefon} ");
            lstSeciliFirma.Items.Add($"Kayıt Tarihi:{firma.KayitTarihi}");
            lstSeciliFirma.Items.Add($"Aktif Mi:{firma.AktifMi}");
        }

        private void cbTumMusteriler_CheckedChanged(object sender, EventArgs e)
        {
            Yukle();
        }

        private void lstKullaniciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKullaniciler.SelectedItem == null) return;

            Musteriler kullanici = lstKullaniciler.SelectedItem as Musteriler;
            lstSeciliKullanici.Items.Clear();
            lstSeciliKullanici.Items.Add($"Adi:{kullanici.Adi}");
            lstSeciliKullanici.Items.Add($"Soyadi:{kullanici.SoyAdi}");
            lstSeciliKullanici.Items.Add($"Adresi:{kullanici.Adres}");
            lstSeciliKullanici.Items.Add($"Telefon:{kullanici.Telefon} ");
            lstSeciliKullanici.Items.Add($"Kayıt Tarihi:{kullanici.KayitTarihi}");
            lstSeciliKullanici.Items.Add($"Aktif Mi:{kullanici.AktifMi}");
        }

        private void btnFirmaAktifEt_Click(object sender, EventArgs e)
        {
            if (lstFirmalar.SelectedItem == null) return;

            Firmalar seciliFirma = lstFirmalar.SelectedItem as Firmalar;
            try
            {
                seciliFirma = new FirmaRepo().GetByID(seciliFirma.FirmaId);
                seciliFirma.AktifMi = true;
                new FirmaRepo().Update();
                Yukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnFirmayiPasifYap_Click(object sender, EventArgs e)
        {
            if (lstFirmalar.SelectedItem == null) return;

            Firmalar seciliFirma = lstFirmalar.SelectedItem as Firmalar;
            try
            {
                seciliFirma = new FirmaRepo().GetByID(seciliFirma.FirmaId);
                seciliFirma.AktifMi = false;
                new FirmaRepo().Update();
                Yukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKullaniciyiAktifEt_Click(object sender, EventArgs e)
        {
            if (lstSeciliKullanici.SelectedItem == null) return;

            Musteriler seciliKullanici = lstSeciliKullanici.SelectedItem as Musteriler;
            try
            {
                seciliKullanici = new MusteriRepo().GetByID(seciliKullanici.MusteriId);
                seciliKullanici.AktifMi = true;
                new MusteriRepo().Update();
                Yukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKullaniciyiPasifYap_Click(object sender, EventArgs e)
        {
            if (lstSeciliKullanici.SelectedItem == null) return;

            Musteriler seciliKullanici = lstSeciliKullanici.SelectedItem as Musteriler;
            try
            {
                seciliKullanici = new MusteriRepo().GetByID(seciliKullanici.MusteriId);
                seciliKullanici.AktifMi = false;
                new MusteriRepo().Update();
                Yukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                        MessageBox.Show("Yönetici Adı Kullanımda");
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
                    RolId = 1,
                    AktifMi = true,
                });
                GirisBilgisi sonEklenen = new GirisBilgisiRepo().GetAll().LastOrDefault();
                int Id = sonEklenen.GirisBilgisiId;

                new YoneticiRepo().Insert(new Yoneticiler()
                {
                    Adi = txtKullaniciOlusturIsim.Text,
                    GirisBilgisiId = Id,
                    KayitTarihi = DateTime.Now,
                    SoyAdi = txtKullaniciOlusturSoyisim.Text,

                });
                MessageBox.Show("Yönetici Ekleme Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbFirmalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvFirmaHareketleri.DataSource = new FirmaRepo().FirmaSiparislerininUrunlereGoreFiyatlariniGetir((cmbFirmalar.SelectedItem as Firmalar).FirmaId);
        }
    }
}
