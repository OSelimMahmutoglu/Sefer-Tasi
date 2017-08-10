using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeferTasiADO.EntityProject.Model.ViewModels
{
   public class FirmaninKategorisininUrunleriWievModel
    {
        public int UrunId { get; set; }
        public int FirmaId { get; set; }
        public int KategoriId { get; set; }
        public string UrunAdi { get; set; }
        public decimal? UrunFiyati { get; set; }
        public int Adet { get; set; }
        public bool SatistaMi { get; set; } 

    }
}
