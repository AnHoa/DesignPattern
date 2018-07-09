namespace WorkWithDB_EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VATTU")]
    public partial class VATTU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VATTU()
        {
            CHITIETHOADONBANs = new HashSet<CHITIETHOADONBAN>();
            CHITIETNHAPKHOes = new HashSet<CHITIETNHAPKHO>();
            CHITIETNHAPMUAs = new HashSet<CHITIETNHAPMUA>();
            CHITIETXUATKHOes = new HashSet<CHITIETXUATKHO>();
        }

        [Key]
        [StringLength(10)]
        public string MAVATTU { get; set; }

        [Required]
        [StringLength(5)]
        public string MALOAI { get; set; }

        [Required]
        [StringLength(20)]
        public string TENVATTU { get; set; }

        [Required]
        [StringLength(10)]
        public string DONVITINH { get; set; }

        public double SOLUONGTON { get; set; }

        [Column(TypeName = "money")]
        public decimal? GIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADONBAN> CHITIETHOADONBANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETNHAPKHO> CHITIETNHAPKHOes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETNHAPMUA> CHITIETNHAPMUAs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETXUATKHO> CHITIETXUATKHOes { get; set; }

        public virtual LOAIVATTU LOAIVATTU { get; set; }
    }
}
