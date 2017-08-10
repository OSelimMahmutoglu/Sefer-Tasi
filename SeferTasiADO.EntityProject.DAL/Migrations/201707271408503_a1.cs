namespace SeferTasiADO.EntityProject.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Firmalar",
                c => new
                    {
                        FirmaId = c.Int(nullable: false, identity: true),
                        GirisBilgisiId = c.Int(),
                        FirmaAdi = c.String(nullable: false, maxLength: 25, unicode: false),
                        Adres = c.String(nullable: false, maxLength: 25, unicode: false),
                        Telefon = c.String(nullable: false, maxLength: 12, unicode: false),
                        KurulusTarihi = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        KayitTarihi = c.DateTime(storeType: "smalldatetime"),
                        AktifMi = c.Boolean(),
                        MaximumSiparisSuresi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FirmaId)
                .ForeignKey("dbo.GirisBilgisi", t => t.GirisBilgisiId)
                .Index(t => t.GirisBilgisiId);
            
            CreateTable(
                "dbo.GirisBilgisi",
                c => new
                    {
                        GirisBilgisiId = c.Int(nullable: false, identity: true),
                        RolId = c.Int(),
                        KullaniciAdi = c.String(nullable: false, maxLength: 25, unicode: false),
                        Mail = c.String(nullable: false, maxLength: 25, unicode: false),
                        Parola = c.String(nullable: false, maxLength: 15),
                        AktifMi = c.Boolean(),
                    })
                .PrimaryKey(t => t.GirisBilgisiId)
                .ForeignKey("dbo.Rol", t => t.RolId)
                .Index(t => t.RolId)
                .Index(t => t.KullaniciAdi, unique: true, name: "giriskullaniciadi")
                .Index(t => t.Mail, unique: true, name: "girismail");
            
            CreateTable(
                "dbo.Musteriler",
                c => new
                    {
                        MusteriId = c.Int(nullable: false, identity: true),
                        GirisBilgisiId = c.Int(),
                        Adi = c.String(nullable: false, maxLength: 25, unicode: false),
                        SoyAdi = c.String(nullable: false, maxLength: 25, unicode: false),
                        Adres = c.String(nullable: false, maxLength: 25, unicode: false),
                        Telefon = c.String(nullable: false, maxLength: 12, unicode: false),
                        DogumTarihi = c.DateTime(storeType: "date"),
                        KayitTarihi = c.DateTime(storeType: "smalldatetime"),
                        AktifMi = c.Boolean(),
                    })
                .PrimaryKey(t => t.MusteriId)
                .ForeignKey("dbo.GirisBilgisi", t => t.GirisBilgisiId)
                .Index(t => t.GirisBilgisiId);
            
            CreateTable(
                "dbo.Siparisler",
                c => new
                    {
                        SiparisId = c.Int(nullable: false, identity: true),
                        MusteriId = c.Int(nullable: false),
                        FirmaId = c.Int(nullable: false),
                        OdemeId = c.Int(nullable: false),
                        SiparisTarihi = c.DateTime(storeType: "smalldatetime"),
                        Adres = c.String(maxLength: 200),
                        OnaylandiMi = c.Boolean(nullable: false),
                        Puan = c.Short(),
                        Urunler_UrunId = c.Int(),
                    })
                .PrimaryKey(t => t.SiparisId)
                .ForeignKey("dbo.Odemeler", t => t.OdemeId)
                .ForeignKey("dbo.Urunler", t => t.Urunler_UrunId)
                .ForeignKey("dbo.Musteriler", t => t.MusteriId)
                .ForeignKey("dbo.Firmalar", t => t.FirmaId)
                .Index(t => t.MusteriId)
                .Index(t => t.FirmaId)
                .Index(t => t.OdemeId)
                .Index(t => t.Urunler_UrunId);
            
            CreateTable(
                "dbo.Odemeler",
                c => new
                    {
                        OdemeId = c.Int(nullable: false, identity: true),
                        OdemeTuru = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.OdemeId);
            
            CreateTable(
                "dbo.SiparisDetay",
                c => new
                    {
                        PF_SiparisId = c.Int(nullable: false),
                        PF_UrunId = c.Int(nullable: false),
                        SepetFiyati = c.Decimal(nullable: false, storeType: "money"),
                        Adet = c.Int(),
                        KategoriId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PF_SiparisId, t.PF_UrunId })
                .ForeignKey("dbo.Urunler", t => t.PF_UrunId)
                .ForeignKey("dbo.Kategoriler", t => t.KategoriId, cascadeDelete: true)
                .ForeignKey("dbo.Siparisler", t => t.PF_SiparisId)
                .Index(t => t.PF_SiparisId)
                .Index(t => t.PF_UrunId)
                .Index(t => t.KategoriId);
            
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        KategoriId = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(nullable: false, maxLength: 50),
                        Tanimlar = c.String(storeType: "ntext"),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.KategoriId)
                .Index(t => t.KategoriAdi, unique: true);
            
            CreateTable(
                "dbo.UrunDetay",
                c => new
                    {
                        UrunDetayId = c.Int(nullable: false, identity: true),
                        UrunId = c.Int(nullable: false),
                        KategoriId = c.Int(nullable: false),
                        FirmaId = c.Int(nullable: false),
                        UrunFiyati = c.Decimal(storeType: "money"),
                        SatistaMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UrunDetayId)
                .ForeignKey("dbo.Kategoriler", t => t.KategoriId, cascadeDelete: true)
                .ForeignKey("dbo.Urunler", t => t.UrunId)
                .ForeignKey("dbo.Firmalar", t => t.FirmaId)
                .Index(t => t.UrunId)
                .Index(t => t.KategoriId)
                .Index(t => t.FirmaId);
            
            CreateTable(
                "dbo.Urunler",
                c => new
                    {
                        UrunId = c.Int(nullable: false, identity: true),
                        KategoriId = c.Int(),
                        UrunAdi = c.String(nullable: false, maxLength: 40),
                        Resim = c.Binary(),
                        SatistaMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UrunId)
                .ForeignKey("dbo.Kategoriler", t => t.KategoriId)
                .Index(t => t.KategoriId)
                .Index(t => t.UrunAdi, unique: true);
            
            CreateTable(
                "dbo.Rol",
                c => new
                    {
                        RolId = c.Int(nullable: false, identity: true),
                        Rol = c.String(nullable: false, maxLength: 8, unicode: false),
                    })
                .PrimaryKey(t => t.RolId);
            
            CreateTable(
                "dbo.Yoneticiler",
                c => new
                    {
                        YoneticiId = c.Int(nullable: false, identity: true),
                        GirisBilgisiId = c.Int(),
                        Adi = c.String(nullable: false, maxLength: 25, unicode: false),
                        SoyAdi = c.String(nullable: false, maxLength: 25, unicode: false),
                        KayitTarihi = c.DateTime(storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => t.YoneticiId)
                .ForeignKey("dbo.GirisBilgisi", t => t.GirisBilgisiId)
                .Index(t => t.GirisBilgisiId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UrunDetay", "FirmaId", "dbo.Firmalar");
            DropForeignKey("dbo.Siparisler", "FirmaId", "dbo.Firmalar");
            DropForeignKey("dbo.Yoneticiler", "GirisBilgisiId", "dbo.GirisBilgisi");
            DropForeignKey("dbo.GirisBilgisi", "RolId", "dbo.Rol");
            DropForeignKey("dbo.Siparisler", "MusteriId", "dbo.Musteriler");
            DropForeignKey("dbo.SiparisDetay", "PF_SiparisId", "dbo.Siparisler");
            DropForeignKey("dbo.SiparisDetay", "KategoriId", "dbo.Kategoriler");
            DropForeignKey("dbo.UrunDetay", "UrunId", "dbo.Urunler");
            DropForeignKey("dbo.Siparisler", "Urunler_UrunId", "dbo.Urunler");
            DropForeignKey("dbo.SiparisDetay", "PF_UrunId", "dbo.Urunler");
            DropForeignKey("dbo.Urunler", "KategoriId", "dbo.Kategoriler");
            DropForeignKey("dbo.UrunDetay", "KategoriId", "dbo.Kategoriler");
            DropForeignKey("dbo.Siparisler", "OdemeId", "dbo.Odemeler");
            DropForeignKey("dbo.Musteriler", "GirisBilgisiId", "dbo.GirisBilgisi");
            DropForeignKey("dbo.Firmalar", "GirisBilgisiId", "dbo.GirisBilgisi");
            DropIndex("dbo.Yoneticiler", new[] { "GirisBilgisiId" });
            DropIndex("dbo.Urunler", new[] { "UrunAdi" });
            DropIndex("dbo.Urunler", new[] { "KategoriId" });
            DropIndex("dbo.UrunDetay", new[] { "FirmaId" });
            DropIndex("dbo.UrunDetay", new[] { "KategoriId" });
            DropIndex("dbo.UrunDetay", new[] { "UrunId" });
            DropIndex("dbo.Kategoriler", new[] { "KategoriAdi" });
            DropIndex("dbo.SiparisDetay", new[] { "KategoriId" });
            DropIndex("dbo.SiparisDetay", new[] { "PF_UrunId" });
            DropIndex("dbo.SiparisDetay", new[] { "PF_SiparisId" });
            DropIndex("dbo.Siparisler", new[] { "Urunler_UrunId" });
            DropIndex("dbo.Siparisler", new[] { "OdemeId" });
            DropIndex("dbo.Siparisler", new[] { "FirmaId" });
            DropIndex("dbo.Siparisler", new[] { "MusteriId" });
            DropIndex("dbo.Musteriler", new[] { "GirisBilgisiId" });
            DropIndex("dbo.GirisBilgisi", "girismail");
            DropIndex("dbo.GirisBilgisi", "giriskullaniciadi");
            DropIndex("dbo.GirisBilgisi", new[] { "RolId" });
            DropIndex("dbo.Firmalar", new[] { "GirisBilgisiId" });
            DropTable("dbo.Yoneticiler");
            DropTable("dbo.Rol");
            DropTable("dbo.Urunler");
            DropTable("dbo.UrunDetay");
            DropTable("dbo.Kategoriler");
            DropTable("dbo.SiparisDetay");
            DropTable("dbo.Odemeler");
            DropTable("dbo.Siparisler");
            DropTable("dbo.Musteriler");
            DropTable("dbo.GirisBilgisi");
            DropTable("dbo.Firmalar");
        }
    }
}
