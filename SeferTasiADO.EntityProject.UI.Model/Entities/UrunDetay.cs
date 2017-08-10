namespace SeferTasiADO.EntityProject.UI.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UrunDetay")]
    public partial class UrunDetay
    {
        public int UrunDetayId { get; set; }

        public int UrunId { get; set; }

        public int FirmaId { get; set; }

        [Column(TypeName = "money")]
        public decimal? UrunFiyati { get; set; }

        public virtual Firmalar Firmalar { get; set; }

        public virtual Urunler Urunler { get; set; }
    }
}
