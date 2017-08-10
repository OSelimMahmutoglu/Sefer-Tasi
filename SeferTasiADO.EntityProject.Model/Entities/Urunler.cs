namespace SeferTasiADO.EntityProject.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Urunler")]
    public partial class Urunler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urunler()
        {
            SiparisDetay = new HashSet<SiparisDetay>();
            Siparisler = new HashSet<Siparisler>();
            UrunDetay = new HashSet<UrunDetay>();
        }

        [Key]
        public int UrunId { get; set; }

        public int? KategoriId { get; set; }

        [Index(IsUnique = true)]
        [Required]
        [StringLength(40)]
        public string UrunAdi { get; set; }

        [Column(TypeName = "varbinary(max)")]
        public byte[] Resim { get; set; } 

        public bool SatistaMi { get; set; } = true;

        public virtual Kategoriler Kategoriler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SiparisDetay> SiparisDetay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siparisler> Siparisler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrunDetay> UrunDetay { get; set; }
    }
}
