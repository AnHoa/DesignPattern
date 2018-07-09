namespace WorkWithDB_EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelVLXD1 : DbContext
    {
        public ModelVLXD1()
            : base("name=ModelVLXD1")
        {
        }

        public virtual DbSet<CHITIETHOADONBAN> CHITIETHOADONBANs { get; set; }
        public virtual DbSet<CHITIETNHAPKHO> CHITIETNHAPKHOes { get; set; }
        public virtual DbSet<CHITIETNHAPMUA> CHITIETNHAPMUAs { get; set; }
        public virtual DbSet<CHITIETQUYEN> CHITIETQUYENs { get; set; }
        public virtual DbSet<CHITIETXUATKHO> CHITIETXUATKHOes { get; set; }
        public virtual DbSet<HOADONBANHANG> HOADONBANHANGs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LOAIVATTU> LOAIVATTUs { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEUCHI> PHIEUCHIs { get; set; }
        public virtual DbSet<PHIEUNHAPKHO> PHIEUNHAPKHOes { get; set; }
        public virtual DbSet<PHIEUNHAPMUA> PHIEUNHAPMUAs { get; set; }
        public virtual DbSet<PHIEUTHU> PHIEUTHUs { get; set; }
        public virtual DbSet<PHIEUXUATKHO> PHIEUXUATKHOes { get; set; }
        public virtual DbSet<QUYEN> QUYENs { get; set; }
        public virtual DbSet<VATTU> VATTUs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHITIETHOADONBAN>()
                .Property(e => e.DONGIABAN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CHITIETNHAPMUA>()
                .Property(e => e.DONGIAMUA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOADONBANHANG>()
                .Property(e => e.TONGTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOADONBANHANG>()
                .HasMany(e => e.CHITIETHOADONBANs)
                .WithRequired(e => e.HOADONBANHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADONBANHANG>()
                .HasMany(e => e.PHIEUXUATKHOes)
                .WithRequired(e => e.HOADONBANHANG)
                .HasForeignKey(e => e.SOHOADONBANHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.HOADONBANHANGs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.PHIEUTHUs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIVATTU>()
                .HasMany(e => e.VATTUs)
                .WithRequired(e => e.LOAIVATTU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .HasMany(e => e.PHIEUCHIs)
                .WithRequired(e => e.NHACUNGCAP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .HasMany(e => e.PHIEUNHAPMUAs)
                .WithRequired(e => e.NHACUNGCAP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.LUONG)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.CHITIETQUYENs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.HOADONBANHANGs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUCHIs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUNHAPMUAs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUNHAPKHOes)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUTHUs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUXUATKHOes)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUCHI>()
                .Property(e => e.TONGTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PHIEUNHAPKHO>()
                .HasMany(e => e.CHITIETNHAPKHOes)
                .WithRequired(e => e.PHIEUNHAPKHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUNHAPMUA>()
                .Property(e => e.TONGTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PHIEUNHAPMUA>()
                .HasMany(e => e.CHITIETNHAPMUAs)
                .WithRequired(e => e.PHIEUNHAPMUA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUNHAPMUA>()
                .HasMany(e => e.PHIEUNHAPKHOes)
                .WithRequired(e => e.PHIEUNHAPMUA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUTHU>()
                .Property(e => e.TONGTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PHIEUXUATKHO>()
                .HasMany(e => e.CHITIETXUATKHOes)
                .WithRequired(e => e.PHIEUXUATKHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QUYEN>()
                .HasMany(e => e.CHITIETQUYENs)
                .WithRequired(e => e.QUYEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VATTU>()
                .Property(e => e.GIA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<VATTU>()
                .HasMany(e => e.CHITIETHOADONBANs)
                .WithRequired(e => e.VATTU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VATTU>()
                .HasMany(e => e.CHITIETNHAPKHOes)
                .WithRequired(e => e.VATTU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VATTU>()
                .HasMany(e => e.CHITIETNHAPMUAs)
                .WithRequired(e => e.VATTU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VATTU>()
                .HasMany(e => e.CHITIETXUATKHOes)
                .WithRequired(e => e.VATTU)
                .WillCascadeOnDelete(false);
        }
    }
}
