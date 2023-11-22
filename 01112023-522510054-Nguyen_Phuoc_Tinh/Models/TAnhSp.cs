using System;
using System.Collections.Generic;

namespace _01112023_522510054_Nguyen_Phuoc_Tinh.Models
{
    public partial class TAnhSp
    {
        public string MaSp { get; set; } = null!;
        public string TenFileAnh { get; set; } = null!;
        public short? ViTri { get; set; }

        public virtual TDanhMucSp MaSpNavigation { get; set; } = null!;
    }
}
