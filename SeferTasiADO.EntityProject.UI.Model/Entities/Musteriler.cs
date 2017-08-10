namespace SeferTasiADO.EntityProject.UI.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Musteriler")]
    public partial class Musteriler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Musteriler()
        {
            Siparislers = new HashSet<Siparisler>();
        }

        [Key]
        public int MusteriId { get; set; }

        public int? GirisBilgisiId { get; set; }

        [Required]
        [StringLength(25)]
        public string Adi { get; set; }

        [Required]
        [StringLength(25)]
        public string SoyAdi { get; set; }

        [Required]
        [StringLength(25)]
        public string Mail { get; set; }

        [Required]
        [StringLength(25)]
        public string Adres { get; set; }

        [Required]
        [StringLength(12)]
        public string Telefon { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DogumTarihi { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? KayitTarihi { get; set; }

        public bool? AktifMi { get; set; }

        public virtual GirisBilgisi GirisBilgisi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siparisler> Siparislers { get; set; }
    }
}
