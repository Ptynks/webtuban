using System;
using System.Collections.Generic;

namespace _01112023_522510054_Nguyen_Phuoc_Tinh.Models
{
    public partial class TQuocGium
    {
        public TQuocGium()
        {
            TDanhMucSps = new HashSet<TDanhMucSp>();
        }

        public string MaNuoc { get; set; } = null!;
        public string? TenNuoc { get; set; }

        public virtual ICollection<TDanhMucSp> TDanhMucSps { get; set; }
    }
}
