namespace WorkWithDB_EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETXUATKHO")]
    public partial class CHITIETXUATKHO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MAPHIEUXUATKHO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MAVATTU { get; set; }

        public double SOLUONG { get; set; }

        public virtual PHIEUXUATKHO PHIEUXUATKHO { get; set; }

        public virtual VATTU VATTU { get; set; }
    }
}
