namespace WorkWithDB_EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETNHAPKHO")]
    public partial class CHITIETNHAPKHO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MAPHIEUNHAPKHO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MAVATTU { get; set; }

        public double SOLUONG { get; set; }

        public virtual PHIEUNHAPKHO PHIEUNHAPKHO { get; set; }

        public virtual VATTU VATTU { get; set; }
    }
}
