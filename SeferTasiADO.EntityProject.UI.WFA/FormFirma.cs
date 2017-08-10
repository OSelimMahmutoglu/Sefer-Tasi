using SeferTasiADO.EntityProject.BLL.Repository;
using SeferTasiADO.EntityProject.Model.Entities;
using SeferTasiADO.EntityProject.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeferTasiADO.EntityProject.UI.WFA
{
    public partial class FormFirma : FormBase
    {
        public FormFirma()
        {
            InitializeComponent();
        }

        private void FormFirma_Load(object sender, EventArgs e)
        {
            this.Text = "Merhaba " + FormLogin.LoginFirmalar.FirmaAdi;
            lstUrunEkleUrunler.DisplayMember = "UrunAdi";
            cmbUrunEkleKategoriler.DisplayMember = "KategoriAdi";
            lstUrunleri.DisplayMember = "UrunAdi";
            kategoriYukle();
            IstatistikleriYukle();
            siparisYukle();
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void siparisYukle()
        {
            lstSiparisOnay.Items.Clear();

            foreach (var item in new SiparisRepo().SiparisRaporuFirma(FormLogin.LoginFirmalar.FirmaId))
            {
                lstSiparisOnay.Items.Add(item);
            }
        }

        private void IstatistikleriYukle()
        {
            
            if (new FirmaRepo().FirmaSiparislerininUrunlereGoreFiyatlariniGetir(FormLogin.LoginFirmalar.FirmaId).ToList() == null && new OdemeRepo().OdemeTurunuListele(FormLogin.LoginFirmalar.FirmaId).ToList() == null) return;

            foreach (var item in new FirmaRepo().FirmaSiparislerininUrunlereGoreFiyatlariniGetir(FormLogin.LoginFirmalar.FirmaId).ToList())
            {
                ChartUrunFiyat.Series["UrunFiyat"].Points.AddXY(item.UrunAdi, item.Toplam);
            }

            foreach (var item in new SiparisRepo().SiparisRaporu(FormLogin.LoginFirmalar.FirmaId))
            {
                ChartOdemeTuru.Series["siparisId"].Points.AddXY(item.SiparisId.ToString(), item.ToplamFiyat);
            }



        }

        private void kategoriYukle()
        {
            cmbUrunEkleKategoriler.DataSource = new CategoryRepo().GetAll();
        }

        Urunler seciliUrun = new Urunler();
        UrunDetay seciliUrunDetay = new UrunDetay();

        private void UrunleriYukle()
        {
            if (cmbUrunEkleKategoriler.SelectedItem == null) return;
            var seciliKategori = cmbUrunEkleKategoriler.SelectedItem as Kategoriler;
            List<UrunDetay> urunDetaylari = new UrunDetayRepo().GetAllByFirm(FormLogin.LoginFirmalar.FirmaId);
            List<Urunler> urunler = new List<Urunler>();
            foreach (var item in urunDetaylari)
            {
                urunler.AddRange(new ProductRepo().GetAll().Where(x => x.UrunId == item.UrunId && x.KategoriId == seciliKategori.KategoriId).ToList());
            }
            lstUrunEkleUrunler.DataSource = !cbTum.Checked ? urunler.Where(x => x.SatistaMi).ToList() : urunler;
            lstUrunEkleUrunler.SelectedIndex = -1;
        }

        private void cmbUrunEkleKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrunleriYukle();

        }

        private void btnUrunEkleYeni_Click(object sender, EventArgs e)
        {
            try
            {
                Kategoriler kategori = cmbUrunEkleKategoriler.SelectedItem as Kategoriler;

                if (kategori != null)
                {
                    bool UrunVarMi = false;
                    foreach (var item in new ProductRepo().GetAll())
                    {
                        UrunVarMi = item.UrunAdi.ToLower() == txtUrunEkleUrunAdi.Text.ToLower();
                        if (UrunVarMi)
                            break;
                    }
                    var yeniUrun = new Urunler();
                    int Id = 0;
                    if (!UrunVarMi)
                    {
                        yeniUrun = new Urunler()
                        {
                            UrunAdi = txtUrunEkleUrunAdi.Text,
                            SatistaMi = cbSatistaMi.Checked,
                            KategoriId = kategori.KategoriId,
                            Resim = memoryStream.ToArray()

                        };
                        new ProductRepo().Insert(yeniUrun);
                        Id = yeniUrun.UrunId;
                    }
                    bool urunDetaydaVarmi = false;
                    Id = new ProductRepo().GetAll().Where(x => x.UrunAdi == txtUrunEkleUrunAdi.Text).FirstOrDefault().UrunId;

                    foreach (var item in new UrunDetayRepo().GetAll())
                    {
                        urunDetaydaVarmi = ((item.FirmaId == FormLogin.LoginFirmalar.FirmaId) && (item.UrunId == Id));
                        if (urunDetaydaVarmi)
                            break;
                    }
                    if (!urunDetaydaVarmi)
                    {
                        new UrunDetayRepo().Insert(new UrunDetay()
                        {
                            FirmaId = FormLogin.LoginFirmalar.FirmaId,
                            UrunId = Id,
                            UrunFiyati = Convert.ToDecimal(txtUrunEKleFiyat.Text),
                            KategoriId = kategori.KategoriId
                        });
                    }
                    else
                        MessageBox.Show("Bu Ürünü Listenize Daha Önce Eklemiştiniz");

                }
                seciliUrun.Resim = null;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            UrunleriYukle();
        }

        MemoryStream memoryStream = new MemoryStream();
        int bufferSize = 64;
        byte[] resimArray = new byte[64];

        private void pbUrun_Click(object sender, EventArgs e)
        {
            memoryStream = new MemoryStream();
            DosyaAc.Title = "Bir fotoğraf dosyasını seçiniz";
            DosyaAc.Filter = "JPG | *.jpg";
            DosyaAc.Multiselect = false;
            DosyaAc.FileName = string.Empty;
            DosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (DosyaAc.ShowDialog() == DialogResult.OK)
            {
                FileStream dosya = File.Open(DosyaAc.FileName, FileMode.Open);
                while (dosya.Read(resimArray, 0, bufferSize) != 0)
                {
                    memoryStream.Write(resimArray, 0, resimArray.Length);
                }
                dosya.Close();
                dosya.Dispose();
                pbUrun.Image = new Bitmap(memoryStream);
            }
        }

        private void lstUrunEkleUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstUrunEkleUrunler.SelectedItem == null) return;
            {

                Urunler seciliUrun = lstUrunEkleUrunler.SelectedItem as Urunler;
                if (seciliUrun.Resim != null && seciliUrun.Resim.Length > 0)
                    pbUrun.Image = new Bitmap(new MemoryStream(seciliUrun.Resim));
                else
                    pbUrun.Image = null;
                txtUrunEkleUrunAdi.Text = seciliUrun.UrunAdi;
                cbSatistaMi.Checked = seciliUrun.SatistaMi;

                txtUrunEKleFiyat.Text = (new UrunDetayRepo().GetAll().Where(x => x.UrunId == seciliUrun.UrunId && x.FirmaId == FormLogin.LoginFirmalar.FirmaId).FirstOrDefault().UrunFiyati).ToString();
                // bunu iki basamaklı para birimi olarak yazdıracaksın.

            }
        }

        private void btnUrunEkleSil_Click(object sender, EventArgs e)
        {
            if (lstUrunEkleUrunler.SelectedItem == null) return;
            Urunler seciliUrun = lstUrunEkleUrunler.SelectedItem as Urunler;
            try
            {

                new ProductRepo().Delete(seciliUrun);
                UrunleriYukle();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            seciliUrun.Resim = null;
            pbUrun.Image = null;
        }

        private void btnUrunEkleGuncelle_Click(object sender, EventArgs e)
        {
            if (lstUrunEkleUrunler.SelectedItem == null) return;

            Urunler seciliUrun = lstUrunEkleUrunler.SelectedItem as Urunler;
            Urunler guncellenecekUrun = new Urunler();
            UrunDetay guncellenecekUrunDetay = new UrunDetay();
            guncellenecekUrun = new ProductRepo().GetByID(seciliUrun.UrunId);
            guncellenecekUrunDetay = new UrunDetayRepo().GetByID(seciliUrun.UrunId);
            try
            {
                seciliUrun = new ProductRepo().GetByID(seciliUrun.UrunId);
                seciliUrun.UrunAdi = txtUrunEkleUrunAdi.Text;
                guncellenecekUrunDetay.UrunFiyati = Convert.ToDecimal(txtUrunEKleFiyat.Text);
                seciliUrun.SatistaMi = cbSatistaMi.Checked;

                if (memoryStream.Length != 0)
                {
                    Image image = Properties.Resources.yemeksepeti_com;
                    MemoryStream stream = new MemoryStream();
                    image.Save(stream, ImageFormat.Png);
                    seciliUrun.Resim = memoryStream.ToArray();
                } // resim güncellemede bir sıkıntımız var kardeş

                new ProductRepo().Update();
                new UrunDetayRepo().Update();

                UrunleriYukle();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            seciliUrun.Resim = null;
        }

        private void cbTum_CheckedChanged(object sender, EventArgs e)
        {
            UrunleriYukle();
        }
        SiparisRaporuFirmaViewModel seciliSiparis = new SiparisRaporuFirmaViewModel();
        private void lstSiparisOnay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSiparisOnay.SelectedItem == null) return;
            SiparisleriGetir();
        }

        private void SiparisleriGetir()
        {
            seciliSiparis = lstSiparisOnay.SelectedItem as SiparisRaporuFirmaViewModel;
            lstUrunleri.DataSource = new ProductRepo().SiparisIdyeGoreUrunGetir(seciliSiparis.SiparisId);
            lstUrunleri.SelectedIndex = -1;
        }

        private void btnSiparisOnaySiparisOnayla_Click(object sender, EventArgs e)
        {
            if (lstSiparisOnay.SelectedItem == null)
            {
                MessageBox.Show("Listeden Sipariş Seçin");
                return;
            }
           
            try
            {
                Siparisler guncellenecekSiperis = new SiparisRepo().GetByID((lstSiparisOnay.SelectedItem as SiparisRaporuFirmaViewModel).SiparisId);
                guncellenecekSiperis.OnaylandiMi = true;
                guncellenecekSiperis.TeslimTarihi = dateTimePicker1.Value;
                new SiparisRepo().Update();
                siparisYukle();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSiparisOnaySiparisİptal_Click(object sender, EventArgs e)
        {
            if (lstSiparisOnay.SelectedItem == null) return;
            int id= (lstSiparisOnay.SelectedItem as SiparisRaporuFirmaViewModel).SiparisId;
            SiparisDetay silincek = new SiparisDetayRepo().GetAll().Where(x => x.PF_SiparisId == id).FirstOrDefault();
            new SiparisDetayRepo().Delete(silincek);
            new SiparisRepo().Delete(new SiparisRepo().GetByID(id));
            siparisYukle();

        }

       
    }

}



