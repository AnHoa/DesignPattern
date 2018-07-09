namespace WorkWithDB_EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUCHI")]
    public partial class PHIEUCHI
    {
        [Key]
        [StringLength(10)]
        public string MAPHIEUCHI { get; set; }

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

        public int TAIKHOANKT { get; set; }

        [Required]
        [StringLength(10)]
        public string MANHANVIEN { get; set; }

        public virtual NHACUNGCAP NHACUNGCAP { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
