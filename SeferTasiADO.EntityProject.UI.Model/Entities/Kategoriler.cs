namespace SeferTasiADO.EntityProject.UI.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kategoriler")]
    public partial class Kategoriler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kategoriler()
        {
            Urunlers = new HashSet<Urunler>();
        }

        [Key]
        public int KategoriId { get; set; }

        [Required]
        [StringLength(50)]
        public string KategoriAdi { get; set; }

        [Column(TypeName = "ntext")]
        public string Tanimlar { get; set; }

        public bool AktifMi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Urunler> Urunlers { get; set; }
    }
}
