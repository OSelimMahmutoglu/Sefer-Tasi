namespace SeferTasiADO.EntityProject.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GirisBilgisi")]
    public partial class GirisBilgisi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GirisBilgisi()
        {
            Firmalar = new HashSet<Firmalar>();
            Musteriler = new HashSet<Musteriler>();
            Yoneticiler = new HashSet<Yoneticiler>();
        }

        public int GirisBilgisiId { get; set; }

        public int? RolId { get; set; }

        [Index("giriskullaniciadi",IsUnique = true)]
        [Required]
        [StringLength(25)]
        public string KullaniciAdi { get; set; }

        [Index("girismail",IsUnique =true)]
        [Required]
        [StringLength(25)]
        
        public string Mail { get; set; }

        [Required]
        [StringLength(15)]
        public string Parola { get; set; }

        public bool? AktifMi { get; set; } = true;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Firmalar> Firmalar { get; set; }

        public virtual Rol Rol { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Musteriler> Musteriler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yoneticiler> Yoneticiler { get; set; }
    }
}
