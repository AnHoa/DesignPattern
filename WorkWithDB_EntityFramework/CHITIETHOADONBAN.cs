namespace WorkWithDB_EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETHOADONBAN")]
    public partial class CHITIETHOADONBAN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string SOHOADON { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MAVATTU { get; set; }

        public double SOLUONG { get; set; }

        [Column(TypeName = "money")]
        public decimal DONGIABAN { get; set; }

        public virtual VATTU VATTU { get; set; }

        public virtual HOADONBANHANG HOADONBANHANG { get; set; }
    }
}
