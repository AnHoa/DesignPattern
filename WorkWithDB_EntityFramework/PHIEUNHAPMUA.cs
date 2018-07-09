namespace WorkWithDB_EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUNHAPMUA")]
    public partial class PHIEUNHAPMUA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUNHAPMUA()
        {
            CHITIETNHAPMUAs = new HashSet<CHITIETNHAPMUA>();
            PHIEUNHAPKHOes = new HashSet<PHIEUNHAPKHO>();
        }

        [Key]
        [StringLength(10)]
        public string MAPHIEUNHAPMUA { get; set; }

        [Required]
        [StringLength(10)]
        public string MANHACUNGCAP { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYLAP { get; set; }

        [Column(TypeName = "money")]
        public decimal TONGTIEN { get; set; }

        [Required]
        [StringLength(100)]
        public string NOIDUNG { get; set; }

        public int? TAIKHOANKT { get; set; }

        [Required]
        [StringLength(10)]
        public string MANHANVIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETNHAPMUA> CHITIETNHAPMUAs { get; set; }

        public virtual NHACUNGCAP NHACUNGCAP { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUNHAPKHO> PHIEUNHAPKHOes { get; set; }
    }
}
