namespace SeferTasiADO.EntityProject.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yoneticiler")]
    public partial class Yoneticiler
    {
        [Key]
        public int YoneticiId { get; set; }

        public int? GirisBilgisiId { get; set; }

        [Required]
        [StringLength(25)]
        public string Adi { get; set; }

        [Required]
        [StringLength(25)]
        public string SoyAdi { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? KayitTarihi { get; set; } = DateTime.Now;

        public virtual GirisBilgisi GirisBilgisi { get; set; }
    }
}
