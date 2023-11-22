using System;
using System.Collections.Generic;

namespace _01112023_522510054_Nguyen_Phuoc_Tinh.Models
{
    public partial class TChiTietHdb
    {
        public string MaHoaDon { get; set; } = null!;
        public string MaChiTietSp { get; set; } = null!;
        public int? SoLuongBan { get; set; }
        public decimal? DonGiaBan { get; set; }
        public double? GiamGia { get; set; }
        public string? GhiChu { get; set; }

        public virtual TChiTietSanPham MaChiTietSpNavigation { get; set; } = null!;
        public virtual THoaDonBan MaHoaDonNavigation { get; set; } = null!;
    }
}
