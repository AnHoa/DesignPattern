namespace WorkWithDB_EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            CHITIETQUYENs = new HashSet<CHITIETQUYEN>();
            HOADONBANHANGs = new HashSet<HOADONBANHANG>();
            PHIEUCHIs = new HashSet<PHIEUCHI>();
            PHIEUNHAPMUAs = new HashSet<PHIEUNHAPMUA>();
            PHIEUNHAPKHOes = new HashSet<PHIEUNHAPKHO>();
            PHIEUTHUs = new HashSet<PHIEUTHU>();
            PHIEUXUATKHOes = new HashSet<PHIEUXUATKHO>();
        }

        [Key]
        [StringLength(10)]
        public string MANHANVIEN { get; set; }

        [Required]
        [StringLength(30)]
        public string TEN { get; set; }

        public bool GIOITINH { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYSINH { get; set; }

        [Required]
        [StringLength(50)]
        public string EMAIL { get; set; }

        [Required]
        [StringLength(13)]
        public string PASS { get; set; }

        [Column(TypeName = "image")]
        public byte[] HINHANH { get; set; }

        [Column(TypeName = "money")]
        public decimal LUONG { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYVAOLAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETQUYEN> CHITIETQUYENs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONBANHANG> HOADONBANHANGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUCHI> PHIEUCHIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUNHAPMUA> PHIEUNHAPMUAs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUNHAPKHO> PHIEUNHAPKHOes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHU> PHIEUTHUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUXUATKHO> PHIEUXUATKHOes { get; set; }
    }
}
