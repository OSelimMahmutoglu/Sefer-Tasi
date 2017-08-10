select * from GirisBilgisi
select * from Rol
select * from Yoneticiler
Select * from Musteriler
Select * from Firmalar
select * from Kategoriler

INSERT INTO Rol(Rol) VALUES('Yönetici')
INSERT INTO Rol(Rol) VALUES('Müşteri')
INSERT INTO Rol(Rol) VALUES('Firma')

INSERT INTO GirisBilgisi(RolId,KullaniciAdi,Mail,Parola) VALUES(1,'Omer','mahmut@abi.com',123)
insert into GirisBilgisi(RolId,KullaniciAdi,Mail,Parola) VALUES(2,'Tasabi','muhammedtas@outlook.com',123)
insert into GirisBilgisi(RolId,KullaniciAdi,Mail,Parola) VALUES(3,'HunkarRestoran','Hunkar@info.com',123)

insert into Yoneticiler(GirisBilgisiId,Adi,Soyadi) values (1,'Omer','Mahmutoglu')
insert into Musteriler(GirisBilgisiId,Adi,Soyadi,Adres,Telefon,DogumTarihi,KayitTarihi,AktifMi) values (2,'Muhammed','Taş','beşiktaş','05555555','01.01.1989','01.01.1990',1)
insert into Firmalar(GirisBilgisiId,FirmaAdi,Adres,Telefon,KurulusTarihi,MaximumSiparisSuresi) values (3,'Hunkar','Ordu perşembe','04522128654','01.05.1995',30)

insert into Kategoriler(KategoriAdi,Tanimlar,AktifMi) values ('İçecekler','Kola,Fanta,Bira,Su,Ayran vb',1)
insert into Kategoriler(KategoriAdi,Tanimlar,AktifMi) Values ('Tatlılar','Hünkarbeğendi, Şöbiyet, Baklava, vb',1)
insert into Kategoriler(KategoriAdi,Tanimlar,AktifMi) Values ('Yiyecekler','Hamburger,Kebap,Lahmacun,Pizza, Pide, Döner, Ev yemekleri vb',1)

insert into Odemeler(OdemeTuru) values('Nakit')
insert into Odemeler(OdemeTuru) values('Kredi Kartı')
insert into Odemeler(OdemeTuru) values('Ticket')