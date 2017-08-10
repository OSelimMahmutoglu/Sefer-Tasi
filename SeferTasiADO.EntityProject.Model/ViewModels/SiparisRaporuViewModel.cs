
using System;

public class SiparisRaporuViewModel
{
    public int SiparisId { get; set; }
    public string MusteriAdi { get; set; }
    public string FirmaAdi { get; set; }
    public DateTime? SiparisTarihi { get; set; }
    public bool Onay { get; set; } = false;
    public decimal ToplamFiyat { get; set; }

    public override string ToString()
    {
        return $"Firma Adı:{this.FirmaAdi} SiparisTarihi:{this.SiparisTarihi} Toplam Fiyat:{ToplamFiyat:c2}  ";

    }
}
