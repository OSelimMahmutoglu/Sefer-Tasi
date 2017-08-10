namespace SeferTasiADO.EntityProject.UI.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Siparisler")]
    public partial class Siparisler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Siparisler()
        {
            SiparisDetays = new HashSet<SiparisDetay>();
        }

        [Key]
        public int SiparisId { get; set; }

        public int MusteriId { get; set; }

        public int FirmaId { get; set; }

        public int UrunId { get; set; }

        public int OdemeId { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SiparisTarihi { get; set; }

        [StringLength(200)]
        public string Adres { get; set; }

        public bool OnaylandiMi { get; set; }

        public short? Puan { get; set; }

        public virtual Firmalar Firmalar { get; set; }

        public virtual Musteriler Musteriler { get; set; }

        public virtual Odemeler Odemeler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SiparisDetay> SiparisDetays { get; set; }

        public virtual Urunler Urunler { get; set; }
    }
}
