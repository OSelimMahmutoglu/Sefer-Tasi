namespace SeferTasiADO.EntityProject.UI.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rol")]
    public partial class Rol
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rol()
        {
            GirisBilgisis = new HashSet<GirisBilgisi>();
        }

        public int RolId { get; set; }

        [Column("Rol")]
        [Required]
        [StringLength(8)]
        public string Rol1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GirisBilgisi> GirisBilgisis { get; set; }
    }
}
