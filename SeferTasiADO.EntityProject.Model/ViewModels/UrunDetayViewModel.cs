using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeferTasiADO.EntityProject.Model.Entities;

namespace SeferTasiADO.EntityProject.Model.ViewModels
{
    public class UrunDetayViewModel
    {
        public int? Adet { get; set; }
        public int FirmaId { get; set; }
        public string KategoriAdi { get; set; }
        public int KategoriId { get; set; }
        public bool SatistaMi { get; set; }
        public string UrunAdi { get; set; }
        public int UrunDetayId { get; set; }
        public decimal? UrunFiyati { get; set; }
        public int UrunId { get; set; }
    }
}
