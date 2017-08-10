using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeferTasiADO.EntityProject.Model.ViewModels
{
    public class SepetViewModel
    {
        public int Adet { get; set; }
        public int KategoriId { get; set; }
        public int PF_UrunId { get; set; }
        public decimal SepetFiyati { get; set; }
        public string UrunAdi { get; set; }

        public override string ToString()
        {
            return $"{this.Adet} x {this.UrunAdi} - {this.Adet} * {this.SepetFiyati:c2}";
        }
    }
}
