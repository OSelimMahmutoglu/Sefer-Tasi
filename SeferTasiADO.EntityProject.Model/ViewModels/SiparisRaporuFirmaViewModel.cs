using SeferTasiADO.EntityProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeferTasiADO.EntityProject.Model.ViewModels
{
 public   class SiparisRaporuFirmaViewModel
    {
        public int SiparisId { get; set; }
        public string MusteriAdi { get; set; }
        public string FirmaAdi { get; set; }
        public DateTime? SiparisTarihi { get; set; }
        public bool Onay { get; set; } = false;
        public decimal ToplamFiyat { get; set; }
        public override string ToString()
        {
            return $"Müşteri Adı:{this.MusteriAdi} SiparisTarihi:{this.SiparisTarihi} Toplam Fiyat:{ToplamFiyat:c2} Onay:{this.Onay} ";

        }
    }
}
