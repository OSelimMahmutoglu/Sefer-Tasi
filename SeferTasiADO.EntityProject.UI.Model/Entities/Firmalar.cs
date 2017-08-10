namespace SeferTasiADO.EntityProject.UI.Model.Entities
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
            Siparislers = new HashSet<Siparisler>();
            UrunDetays = new HashSet<UrunDetay>();
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
        [StringLength(25)]
        public string Mail { get; set; }

        [Required]
        [StringLength(12)]
        public string Telefon { get; set; }

        [Column(TypeName = "date")]
        public DateTime? KurulusTarihi { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? KayitTarihi { get; set; }

        public bool? AktifMi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MaximumSiparisSuresi { get; set; }

        public virtual GirisBilgisi GirisBilgisi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siparisler> Siparislers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrunDetay> UrunDetays { get; set; }
    }
}
