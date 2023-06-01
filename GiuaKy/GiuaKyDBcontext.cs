using Microsoft.EntityFrameworkCore;

namespace GiuaKy
{
    //public class GiuaKyDBcontext : DbContext
    //{
    //    public DbSet<Product> Products { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        // Cấu hình chuỗi kết nối đến cơ sở dữ liệu ở đây
    //        optionsBuilder.UseSqlServer("YourConnectionString");
    //    }
    //}
    public class GiuaKyDBcontext : DbContext
    {
        public GiuaKyDBcontext(DbContextOptions<GiuaKyDBcontext> options)
            : base(options)
        {
        }

        // Định nghĩa các bảng trong cơ sở dữ liệu
        public DbSet<QuocGia> QuocGias { get; set; }
        public DbSet<DongSanPham> DongSanPhams { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<CuaHang> CuaHangs { get; set; }
        public DbSet<PhanHoiKhachHang> PhanHoiKhachHangs { get; set; }
        public DbSet<TaiKhoanQuanTri> TaiKhoanQuanTris { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CuaHang>()
                .HasKey(c => c.MaCuaHang);
            modelBuilder.Entity<DongSanPham>()
            .HasKey(d => d.MaDongSanPham);
            modelBuilder.Entity<PhanHoiKhachHang>()
            .HasKey(e => e.MaPhanHoi);
            modelBuilder.Entity<QuocGia>()
            .HasKey(f => f.MaQuocGia);
            modelBuilder.Entity<SanPham>()
            .HasKey(g => g.MaDongSanPham);
            modelBuilder.Entity<TaiKhoanQuanTri>()
            .HasKey(h => h.MaTaiKhoan);
            base.OnModelCreating(modelBuilder);
        }
    }
}
