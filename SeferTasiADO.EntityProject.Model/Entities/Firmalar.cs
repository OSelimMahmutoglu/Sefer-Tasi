namespace SeferTasiADO.EntityProject.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firmalar")]
    public partial class Firmalar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Firmalar()
        {
            Siparisler = new HashSet<Siparisler>();
            UrunDetay = new HashSet<UrunDetay>();
        }

        [Key]
        public int FirmaId { get; set; }

        public int? GirisBilgisiId { get; set; }

        [Required]
        [StringLength(25)]
        public string FirmaAdi { get; set; }

        [Required]
        [StringLength(25)]
        public string Adres { get; set; }

    
        [Required]
        [StringLength(12)]
        public string Telefon { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime KurulusTarihi { get; set; } 

        [Column(TypeName = "smalldatetime")]
        public DateTime? KayitTarihi { get; set; } = DateTime.Now;

        public bool? AktifMi { get; set; } = false;

        [Column(TypeName = "int")]
        public int MaximumSiparisSuresi { get; set; } = 30;

        public virtual GirisBilgisi GirisBilgisi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siparisler> Siparisler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrunDetay> UrunDetay { get; set; }
    }
}
