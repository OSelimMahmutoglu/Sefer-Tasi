namespace SeferTasiADO.EntityProject.UI.Model.Entities
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
            Firmalars = new HashSet<Firmalar>();
            Musterilers = new HashSet<Musteriler>();
            Yoneticilers = new HashSet<Yoneticiler>();
        }

        public int GirisBilgisiId { get; set; }

        public int? RolId { get; set; }

        [Required]
        [StringLength(25)]
        public string KullaniciAdi { get; set; }

        [Required]
        [StringLength(25)]
        public string Mail { get; set; }

        [Required]
        [StringLength(15)]
        public string Parola { get; set; }

        public bool? AktifMi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Firmalar> Firmalars { get; set; }

        public virtual Rol Rol { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Musteriler> Musterilers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yoneticiler> Yoneticilers { get; set; }
    }
}
