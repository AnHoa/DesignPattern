namespace WorkWithDB_EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADONBANHANG")]
    public partial class HOADONBANHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADONBANHANG()
        {
            CHITIETHOADONBANs = new HashSet<CHITIETHOADONBAN>();
            PHIEUXUATKHOes = new HashSet<PHIEUXUATKHO>();
        }

        [Key]
        [StringLength(10)]
        public string SOHOADON { get; set; }

        [Required]
        [StringLength(10)]
        public string MAKHACHHANG { get; set; }

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
        public virtual ICollection<CHITIETHOADONBAN> CHITIETHOADONBANs { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUXUATKHO> PHIEUXUATKHOes { get; set; }
    }
}
