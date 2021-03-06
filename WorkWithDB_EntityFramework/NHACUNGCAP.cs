namespace WorkWithDB_EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHACUNGCAP")]
    public partial class NHACUNGCAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHACUNGCAP()
        {
            PHIEUCHIs = new HashSet<PHIEUCHI>();
            PHIEUNHAPMUAs = new HashSet<PHIEUNHAPMUA>();
        }

        [Key]
        [StringLength(10)]
        public string MANHACUNGCAP { get; set; }

        [Required]
        [StringLength(50)]
        public string TEN { get; set; }

        [StringLength(100)]
        public string DIACHI { get; set; }

        [StringLength(13)]
        public string SODIENTHOAI { get; set; }

        [StringLength(10)]
        public string MASOTHUE { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYBDHOPTAC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUCHI> PHIEUCHIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUNHAPMUA> PHIEUNHAPMUAs { get; set; }
    }
}
