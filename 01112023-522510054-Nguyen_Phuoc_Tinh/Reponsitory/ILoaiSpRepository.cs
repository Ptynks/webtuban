using _01112023_522510054_Nguyen_Phuoc_Tinh.Models;

namespace _01112023_522510054_Nguyen_Phuoc_Tinh.Repository
{
    public interface ILoaiSpRepository
    {
           TLoaiSp Add(TLoaiSp loaiSP);
            TLoaiSp Update(TLoaiSp loaiSP);

            TLoaiSp Delete(String maLoaiSP);
            TLoaiSp GetLoaiSP(String maLoaiSP);
            IEnumerable<TLoaiSp> GetAllLoaiSP();
    }
}
