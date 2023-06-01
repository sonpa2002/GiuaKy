namespace GiuaKy
{
    public class GiuaKyAllClass
    {
    }
    public class QuocGia
    {
        public int MaQuocGia { get; set; }
        public string TenQuocGia { get; set; }
    }

    public class DongSanPham
    {
        public int MaDongSanPham { get; set; }
        public string TenDongSanPham { get; set; }
        public int MaQuocGia { get; set; }
        public QuocGia QuocGia { get; set; }
    }

    public class SanPham
    {
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int MaDongSanPham { get; set; }
        public string ThongTinGioiThieu { get; set; }
        public DongSanPham DongSanPham { get; set; }
    }

    public class CuaHang
    {
        public int MaCuaHang { get; set; }
        public string TenCuaHang { get; set; }
        public string ThongTinLienHe { get; set; }
    }

    public class PhanHoiKhachHang
    {
        public int MaPhanHoi { get; set; }
        public int MaSanPham { get; set; }
        public string NoiDungPhanHoi { get; set; }
        public SanPham SanPham { get; set; }
    }

    public class TaiKhoanQuanTri
    {
        public int MaTaiKhoan { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
    }
}
