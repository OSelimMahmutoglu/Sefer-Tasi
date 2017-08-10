using SeferTasiADO.EntityProject.BLL.Repository;
using SeferTasiADO.EntityProject.Model.Entities;
using SeferTasiADO.EntityProject.Model.ViewModels;
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
    public partial class FormKullanici : FormBase
    {
        public FormKullanici()
        {
            InitializeComponent();
        }

        private void FormKullanici_Load(object sender, EventArgs e)
        {
            this.Text = "Merhaba " + FormLogin.LoginMusteri.Adi + " " + FormLogin.LoginMusteri.SoyAdi;
            cbRestoran.DisplayMember = "FirmaAdi";
            cbFirmaKategori.DisplayMember = "KategoriAdi";
            lstUrunler.DisplayMember = "UrunAdi";
            cbOdemeTipi.DisplayMember = "OdemeTuru";
            cbRestoran.DataSource = new FirmaRepo().GetAll().Where(x => x.AktifMi == true).ToList();
            cbOdemeTipi.DataSource = new OdemeRepo().GetAll().ToList();
            cbRestoran.Enabled = true;
            sepetUrunler = new List<SepetViewModel>();
            lstSepet.Items.Clear();
            Yukle();


        }


        List<FirmaninKategorileriViewModel> kategoriler = new List<FirmaninKategorileriViewModel>();

        private void cbRestoran_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRestoran.SelectedItem == null) return;
            Firmalar seciliFirma = cbRestoran.SelectedItem as Firmalar;
            kategoriler = new SiparisRepo().FirmaninKategorileri(seciliFirma.FirmaId);
            cbFirmaKategori.DataSource = kategoriler;
            dtpIstenenTarih.MinDate = (DateTime.Now).AddMinutes((cbRestoran.SelectedItem as Firmalar).MaximumSiparisSuresi);
            foreach (var item in new SiparisRepo().FirmaPuanıHesapla(seciliFirma.FirmaId))
            {
                lblFirmaPuani.Text = Convert.ToString(item.ToplamPuan);
            }
            
        }

        private void cbFirmaKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFirmaKategori.SelectedItem == null && cbRestoran.SelectedItem == null) return;

            lstUrunler.DataSource = new SiparisRepo().FirmaninKategorisininUrunleriniGetir((cbRestoran.SelectedItem as Firmalar).FirmaId, (cbFirmaKategori.SelectedItem as FirmaninKategorileriViewModel).KategoriId);
        }
        List<SepetViewModel> sepetUrunler = new List<SepetViewModel>();
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null)
            {
                MessageBox.Show("Öncelikle Sol Taraftan Ürün Seçiniz");
                return;
            }
            UrunDetayViewModel seciliUrun = lstUrunler.SelectedItem as UrunDetayViewModel;
            bool varMi = false;
            foreach (var item in sepetUrunler)
            {
                if (seciliUrun.UrunId == item.PF_UrunId)
                {
                    varMi = true;
                    break;
                }
            }
            if (varMi)
            {
                sepetUrunler.Where(x => x.PF_UrunId == seciliUrun.UrunId).FirstOrDefault().Adet += Convert.ToInt32(nAdet.Value);
                sepetDoldur();
            }
            else
            {
                sepetUrunler.Add(new SepetViewModel()
                {
                    UrunAdi = seciliUrun.UrunAdi,
                    Adet = Convert.ToInt32(nAdet.Value),
                    SepetFiyati = Convert.ToDecimal(seciliUrun.UrunFiyati),
                    PF_UrunId = seciliUrun.UrunId,
                    KategoriId = seciliUrun.KategoriId,
                });
                sepetDoldur();
            }

            cbRestoran.Enabled = false;

        }

        private void sepetDoldur()
        {
            lstSepet.Items.Clear();
            decimal SepetFiyati = 0;
            foreach (var item in sepetUrunler)
            {
                lstSepet.Items.Add(item);
                SepetFiyati += Convert.ToDecimal(item.SepetFiyati * item.Adet);
            }
            lblTutar.Text = $"{SepetFiyati:c2}\nKDV: {SepetFiyati * 0.18m:c2}";
        }

        private void btnSiparisiOnayla_Click(object sender, EventArgs e)
        {
            if (sepetUrunler.Count == 0)
            {
                MessageBox.Show("Öncelikle Sepete Ürün Eklemelisiniz!");
                return;
            }
            if (cbOdemeTipi.SelectedItem == null)
            {
                MessageBox.Show("Ödeme Tipi Belirtiniz");
                return;
            }
            Siparisler yeniSiparis = new Siparisler()
            {
                Adres = txtAdres.Text,
                SiparisTarihi = dtpIstenenTarih.Value,
                OdemeId = (cbOdemeTipi.SelectedItem as Odemeler).OdemeId,
                OnaylandiMi = false,
                Puan = null,
                MusteriId = FormLogin.LoginMusteri.MusteriId,
                FirmaId = (cbRestoran.SelectedItem as Firmalar).FirmaId,
            };
            try
            {

                bool durum = new SiparisRepo().SiparisOlustur(yeniSiparis, sepetUrunler);
                if (durum)
                {
                    MessageBox.Show("Siparişiniz Oluşmuştur.");
                    sepetUrunler = new List<SepetViewModel>();
                    sepetDoldur();
                }
                else
                {
                    MessageBox.Show("Siparişiz oluşturulurken bir hata meydana geldi");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbOdemeTipi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Yukle();
        }
        List<Siparisler> siparisRaporu = new List<Siparisler>();
        Siparisler siparisRaporuAyrıntı = new Siparisler();


        private void Yukle()
        {
            lstSiparisler.Items.Clear();
            
                foreach (var item in new SiparisRepo().SiparisRaporu(FormLogin.LoginMusteri.MusteriId))
                {
                    lstSiparisler.Items.Add(item);
                }
        }

        private void btnPuanVer_Click(object sender, EventArgs e)
        {
            if (lstSiparisler.SelectedItem == null)
            {
                MessageBox.Show("Hangi Siparişe Puan vericeğinizi seçiniz");
                return;
            }
            Siparisler seciliSiparis = new SiparisRepo().GetByID((lstSiparisler.SelectedItem as SiparisRaporuViewModel).SiparisId);
            try
            {
                seciliSiparis.Puan = Convert.ToInt16(cbPuan.Text);
                new SiparisRepo().Update();
                Yukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SiparisOlustur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Yukle();
        }
    }
}