namespace SeferTasiADO.EntityProject.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SiparisDetay")]
    public partial class SiparisDetay
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PF_SiparisId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PF_UrunId { get; set; }

        [Column(TypeName = "money")]
        public decimal SepetFiyati { get; set; }

        
        public int Adet { get; set; }
     
        public int KategoriId { get; set; }
        public virtual Siparisler Siparisler { get; set; }

        public virtual Urunler Urunler { get; set; }

        
        [ForeignKey("KategoriId")]
        public virtual Kategoriler kategori { get; set; }

    }
}
