namespace WorkWithDB_EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETQUYEN")]
    public partial class CHITIETQUYEN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MAQUYEN { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MANHANVIEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYXACNHAN { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual QUYEN QUYEN { get; set; }
    }
}
