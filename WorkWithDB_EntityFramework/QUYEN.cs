namespace WorkWithDB_EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QUYEN")]
    public partial class QUYEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QUYEN()
        {
            CHITIETQUYENs = new HashSet<CHITIETQUYEN>();
        }

        [Key]
        [StringLength(5)]
        public string MAQUYEN { get; set; }

        [Required]
        [StringLength(100)]
        public string NOIDUNG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETQUYEN> CHITIETQUYENs { get; set; }
    }
}
