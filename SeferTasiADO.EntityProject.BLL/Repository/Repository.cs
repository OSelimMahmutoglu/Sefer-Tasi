using SeferTasiADO.EntityProject.DAL;
using SeferTasiADO.EntityProject.Model.Entities;
using SeferTasiADO.EntityProject.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeferTasiADO.EntityProject.BLL.Repository
{
    public class CategoryRepo : RepositoryBase<Kategoriler, int> { }

    public class UrunDetayRepo : RepositoryBase<UrunDetay, int>

    {
        #region açıklama
        //public List<UrunDetay> GetAllByFirm(int FirmaId)
        //{
        //    dbContext = new MyContext();
        //    Firmalar Firma = dbContext.Firmalar.Find(FirmaId);
        //    return Firma.UrunDetay.ToList();
        //}
        // alttaki daha kısa pamps
        #endregion
        public List<UrunDetay> GetAllByFirm(int FirmaId) => new MyContext().Firmalar.Find(FirmaId).UrunDetay.ToList();

        public UrunDetay GetById(int UrunId, int FirmaId)
        {
            return new UrunDetayRepo().GetAll().Where(x => x.UrunId == UrunId && x.FirmaId == FirmaId).FirstOrDefault();

        }

    }
    public class ProductRepo : RepositoryBase<Urunler, int>
    {
        public List<UrunAdiViewModel> SiparisIdyeGoreUrunGetir(int siparisId)
        {
            MyContext db = new MyContext();


            var rapor = from sd in db.SiparisDetay
                        join u in db.Urunler
                        on sd.PF_UrunId equals u.UrunId
                        where (sd.PF_SiparisId == siparisId)
                        select new UrunAdiViewModel()
                        {
                            UrunAdi = u.UrunAdi,
                            UrunId = u.UrunId
                        };
            return rapor.ToList();
        }
        public List<Urunler> GetAllByCategory(Kategoriler kategori)
        {
            dbContext = new MyContext();
            Kategoriler kat = dbContext.Kategoriler.Find(kategori.KategoriId);
            return kat != null ? kat.Urunler.ToList() : new List<Urunler>();

        }

        public override void Delete(Urunler entity)
        {
            dbContext = dbContext ?? new MyContext();
            try
            {
                var silinecek = dbContext.Urunler.Find(entity.UrunId);
                if (silinecek == null) return;
                silinecek.SatistaMi = false;
                dbContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Urunler> ProductSearch(string key)
        {
            return this.GetAll()
                .Where(x => (x.UrunAdi.ToLower().Contains(key.ToLower()) ||
                x.Kategoriler.KategoriAdi.ToLower().Contains(key.ToLower())) & x.SatistaMi)
                .ToList();
        }

    }

    public class OdemeRepo : RepositoryBase<Odemeler, int>
    {
        public List<OdemeTuruViewModel> OdemeTurunuListele(int firmaId)
        {
            MyContext db = new MyContext();
            var sorgu = from odemeler in db.Odemeler
                        join siparisler in db.Siparisler
                        on odemeler.OdemeId equals siparisler.OdemeId
                        join siparisdetay in db.SiparisDetay
                        on siparisler.SiparisId equals siparisdetay.PF_SiparisId
                        group odemeler
                        by new
                        {
                          odemeler.OdemeTuru,
                          siparisdetay.SepetFiyati
                        } into K
                        select new OdemeTuruViewModel
                        {
                            OdemeTuru = K.Key.OdemeTuru,
                            Toplam = K.Key.SepetFiyati,

                        };
            return sorgu.ToList();


        }

    }
    public class SiparisRepo : RepositoryBase<Siparisler, int>
    {
        public List<PuanViewModel> FirmaPuanıHesapla(int firmaId)
        {
            MyContext db = new MyContext();
            var sorgu = from s in db.Siparisler
                        where (s.FirmaId == firmaId)
                        group new
                        {
                            s
                        } by new
                        {
                            puan = s.Puan
                        } into sipPuan
                        select new PuanViewModel
                        {
                            ToplamPuan = sipPuan.Sum(x => x.s.Puan) / sipPuan.Count(),

                        };

            return sorgu.ToList();
        }
        public List<FirmaninKategorileriViewModel> FirmaninKategorileri(int firmaId)
        {
            MyContext db = new MyContext();
            var sorgu = from Kategori in db.Kategoriler
                        join UrunDetaylari in db.UrunDetay
                        on Kategori.KategoriId equals UrunDetaylari.KategoriId
                        where UrunDetaylari.FirmaId == firmaId
                        group Kategori by new { Kategori.KategoriAdi, Kategori.KategoriId } into k
                        select new FirmaninKategorileriViewModel
                        {
                            KategoriAdi = k.Key.KategoriAdi,
                            KategoriId = k.Key.KategoriId
                        };

            return sorgu.ToList();
        }

        public List<UrunDetayViewModel> FirmaninKategorisininUrunleriniGetir(int firmaId, int kategoriId)
        {
            MyContext db = new MyContext();
            var sorgu = from Kategori in db.Kategoriler
                        join UrunDetaylari in db.UrunDetay
                        on Kategori.KategoriId equals UrunDetaylari.KategoriId
                        join Urun in db.Urunler
                        on UrunDetaylari.UrunId equals Urun.UrunId
                        where UrunDetaylari.FirmaId == firmaId && Urun.KategoriId == kategoriId && UrunDetaylari.SatistaMi == true
                        select new UrunDetayViewModel()
                        {
                            KategoriId = Kategori.KategoriId,
                            FirmaId = UrunDetaylari.FirmaId,
                            KategoriAdi = Kategori.KategoriAdi,
                            SatistaMi = UrunDetaylari.SatistaMi,
                            UrunDetayId = UrunDetaylari.UrunDetayId,
                            UrunFiyati = UrunDetaylari.UrunFiyati,
                            UrunId = Urun.UrunId,
                            UrunAdi = Urun.UrunAdi,

                        };

            return sorgu.ToList();
        }

        public bool SiparisOlustur(Siparisler yeniSiparis, List<SepetViewModel> sepet)
        {

            using (MyContext db = new MyContext())
            {
                using (var tran = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Siparisler.Add(yeniSiparis);
                        db.SaveChanges();
                        foreach (var item in sepet)
                        {

                            db.SiparisDetay.Add(new SiparisDetay()
                            {
                                PF_SiparisId = yeniSiparis.SiparisId,
                                PF_UrunId = item.PF_UrunId,
                                Adet = item.Adet,
                                SepetFiyati = -item.SepetFiyati,
                                KategoriId = item.KategoriId

                            });

                        }
                        db.SaveChanges();
                        tran.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        return false;

                    }

                }

            }


        }

        public List<SiparisRaporuViewModel> SiparisRaporu(int id)
        {

            MyContext db = new MyContext();


            var rapor = from s in db.Siparisler
                        join sd in db.SiparisDetay
                        on s.SiparisId equals sd.PF_SiparisId
                        join f in db.Firmalar
                        on s.FirmaId equals f.FirmaId
                        where (s.MusteriId == id && s.OnaylandiMi == true)
                        group new
                        {
                            sd,
                            s,
                            f
                        } by new
                        {
                            sipId = sd.PF_SiparisId,
                            firmaAdi = f.FirmaAdi
                        } into sipIdfirmaAdiGrup
                        select new SiparisRaporuViewModel()
                        {
                            SiparisId = sipIdfirmaAdiGrup.Key.sipId,
                            FirmaAdi = sipIdfirmaAdiGrup.Key.firmaAdi,
                            ToplamFiyat = sipIdfirmaAdiGrup.Sum(x => x.sd.SepetFiyati * x.sd.Adet)

                        };
            return rapor.ToList();
        }
        public List<SiparisRaporuFirmaViewModel> SiparisRaporuFirma(int id)
        {

            MyContext db = new MyContext();


            var rapor = from s in db.Siparisler
                        join sd in db.SiparisDetay
                        on s.SiparisId equals sd.PF_SiparisId
                        join m in db.Musteriler
                        on s.MusteriId equals m.MusteriId
                        where (s.FirmaId == id)
                        group new
                        {
                            sd,
                            s,
                            m
                        } by new
                        {
                            sipId = sd.PF_SiparisId,
                            musteriAdi = m.Adi,
                            onay = s.OnaylandiMi
                        } into sipIdfirmaAdiGrup
                        select new SiparisRaporuFirmaViewModel()
                        {
                            SiparisId = sipIdfirmaAdiGrup.Key.sipId,
                            MusteriAdi = sipIdfirmaAdiGrup.Key.musteriAdi,
                            Onay = sipIdfirmaAdiGrup.Key.onay,
                            ToplamFiyat = sipIdfirmaAdiGrup.Sum(x => x.sd.SepetFiyati * x.sd.Adet)
                        };
            return rapor.ToList();

        }


        public List<KategoriSiparisRaporuViewModel> KategoriyeGoreSiparisRaporu()
        {


            MyContext db = new MyContext();



            var rapor = from urun in db.Urunler
                        join Kategori in db.Kategoriler
                        on urun.KategoriId equals Kategori.KategoriId
                        join siparisdetay in db.SiparisDetay
                        on urun.UrunId equals siparisdetay.PF_UrunId
                        join siparis in db.Siparisler
                        on siparisdetay.PF_UrunId equals siparis.SiparisId


                        select new
                        {

                            SiparisId = siparis.SiparisId,
                            KategoriAdi = Kategori.KategoriAdi,
                            UrunAdi = urun.UrunAdi,
                            Adet = siparisdetay.Adet,
                            UrunFiyati = Convert.ToDecimal(siparisdetay.SepetFiyati),
                            Toplam = siparisdetay.SepetFiyati * siparisdetay.Adet,


                        };

            var raporson = rapor.AsParallel()
                .GroupBy(x => new { x.SiparisId, x.KategoriAdi })
                .Select(x => new KategoriSiparisRaporuViewModel

                {
                    SiparisId = x.Key.SiparisId,
                    KategoriAdi = x.Key.KategoriAdi,
                    /*Toplam = Convert.ToDecimal(x.Key.Toplam),   */        /*Sum(y => Convert.ToDecimal(y.Indirim) * y.Toplam)*/
                                                                            // linq decimal convert ile çarpma işlemi yapamadı diye bunu yazdık. 

                })
                .OrderBy(x => x.SiparisId)
                .ToList();
            return raporson;
        }
        public List<SiparisToplamViewModel> SiparisToplamRaporu()
        {


            MyContext db = new MyContext();



            var rapor = from urun in db.Urunler
                        join Kategori in db.Kategoriler
                        on urun.KategoriId equals Kategori.KategoriId
                        join siparisdetay in db.SiparisDetay
                        on urun.UrunId equals siparisdetay.PF_UrunId
                        join siparis in db.Siparisler
                        on siparisdetay.PF_UrunId equals siparis.SiparisId


                        select new
                        {

                            SiparisId = siparis.SiparisId,
                            KategoriAdi = Kategori.KategoriAdi,
                            UrunAdi = urun.UrunAdi,
                            Adet = siparisdetay.Adet,
                            UrunFiyati = siparisdetay.SepetFiyati,
                            Toplam = siparisdetay.SepetFiyati * siparisdetay.Adet,
                            //Indirim = (1 - siparisdetay.Indirim)

                        };

            var raporson = rapor.AsParallel()
                .GroupBy(x => new { x.SiparisId })
                .Select(x => new SiparisToplamViewModel

                {
                    SiparisId = x.Key.SiparisId,
                    //Toplam = x.Sum(y => Convert.ToDecimal(y.Indirim) * y.Toplam)
                    // linq decimal convert ile çarpma işlemi yapamadı diye bunu yazdık. 

                })
                .OrderBy(x => x.SiparisId)
                .ToList();

            return raporson;

        }
    }


    public class SiparisDetayRepo : RepositoryBase<SiparisDetay, int>
    {

    }
    public class GirisBilgisiRepo : RepositoryBase<GirisBilgisi, int>
    {
        public virtual GirisBilgisi GirisIdsiGetir(string kullaniciAdi, string parola)
        {
            return this.GetAll().Where(x => (x.KullaniciAdi.ToLower() == kullaniciAdi.ToLower() || x.Mail.ToLower() == kullaniciAdi.ToLower()) && x.Parola == parola).FirstOrDefault();
        }
    }

    public class FirmaRepo : RepositoryBase<Firmalar, int>
    {
        public List<FirmaSiparislerininUrunFiyatiViewModel> FirmaSiparislerininUrunlereGoreFiyatlariniGetir(int firmaId)
        {
            MyContext db = new MyContext();
            var sorgu = from siparisDetaylari in db.SiparisDetay
                        join siparisler in db.Siparisler
                        on siparisDetaylari.PF_SiparisId equals siparisler.SiparisId
                        join urunler in db.Urunler
                        on siparisDetaylari.PF_UrunId equals urunler.UrunId
                        join urunDetay in db.UrunDetay
                        on urunler.UrunId equals urunDetay.UrunId
                        where siparisler.FirmaId == firmaId 
                        group new
                        {
                            urunler,
                            siparisDetaylari,
                            urunDetay,
                        } by new
                        {
                            urunler.UrunAdi,
                            urunler.UrunId,
                            siparisDetaylari.PF_SiparisId,
                            urunDetay.UrunFiyati,
                            siparisler.FirmaId,
                            siparisDetaylari.Adet
                        } into urunsiparis
                        select new FirmaSiparislerininUrunFiyatiViewModel()
                        {
                            SiparisId = urunsiparis.Key.PF_SiparisId,
                            FirmaId = urunsiparis.Key.FirmaId,
                            UrunId = urunsiparis.Key.UrunId,
                            UrunAdi = urunsiparis.Key.UrunAdi,
                            Toplam = (urunsiparis.Key.UrunFiyati * urunsiparis.Key.Adet)
                        };

            return sorgu.ToList();
        }

        public virtual Firmalar FirmayiGetir(GirisBilgisi girisBilgisi)
        {
            try
            {
                Firmalar firma = new FirmaRepo().GetByID(girisBilgisi.Firmalar.Where(x => x.GirisBilgisiId == girisBilgisi.GirisBilgisiId).FirstOrDefault().FirmaId);
                return firma;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }



        }
    }
    public class YoneticiRepo : RepositoryBase<Yoneticiler, int>
    {
        public virtual Yoneticiler YoneticiGetir(GirisBilgisi girisBilgisi)
        {
            try
            {
                Yoneticiler yonetici = new YoneticiRepo().GetByID(girisBilgisi.Yoneticiler.Where(x => x.GirisBilgisiId == girisBilgisi.GirisBilgisiId).FirstOrDefault().YoneticiId);
                return yonetici;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }



        }
    }
    public class MusteriRepo : RepositoryBase<Musteriler, int>
    {
        public virtual Musteriler MusteriyiGetir(GirisBilgisi girisBilgisi)
        {
            try
            {
                Musteriler musteri = new MusteriRepo().GetByID(girisBilgisi.Musteriler.Where(x => x.GirisBilgisiId == girisBilgisi.GirisBilgisiId).FirstOrDefault().MusteriId);
                return musteri;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }



        }
    }
}




