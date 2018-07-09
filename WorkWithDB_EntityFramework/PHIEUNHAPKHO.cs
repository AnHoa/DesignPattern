namespace WorkWithDB_EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUNHAPKHO")]
    public partial class PHIEUNHAPKHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUNHAPKHO()
        {
            CHITIETNHAPKHOes = new HashSet<CHITIETNHAPKHO>();
        }

        [Key]
        [StringLength(10)]
        public string MAPHIEUNHAPKHO { get; set; }

        [Required]
        [StringLength(10)]
        public string MAPHIEUNHAPMUA { get; set; }

        [Required]
        [StringLength(50)]
        public string TENNGUOIGIAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYLAP { get; set; }

        [Required]
        [StringLength(100)]
        public string NOIDUNG { get; set; }

        [Required]
        [StringLength(10)]
        public string MANHANVIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETNHAPKHO> CHITIETNHAPKHOes { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual PHIEUNHAPMUA PHIEUNHAPMUA { get; set; }
    }
}
