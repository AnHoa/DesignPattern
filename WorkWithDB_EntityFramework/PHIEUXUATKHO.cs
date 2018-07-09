namespace WorkWithDB_EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUXUATKHO")]
    public partial class PHIEUXUATKHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUXUATKHO()
        {
            CHITIETXUATKHOes = new HashSet<CHITIETXUATKHO>();
        }

        [Key]
        [StringLength(10)]
        public string MAPHIEUXUATKHO { get; set; }

        [Required]
        [StringLength(10)]
        public string SOHOADONBANHANG { get; set; }

        [Required]
        [StringLength(50)]
        public string TENNGUOINHAN { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYLAP { get; set; }

        [Required]
        [StringLength(100)]
        public string NOIDUNG { get; set; }

        [Required]
        [StringLength(10)]
        public string MANHANVIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETXUATKHO> CHITIETXUATKHOes { get; set; }

        public virtual HOADONBANHANG HOADONBANHANG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
