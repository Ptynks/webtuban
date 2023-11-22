using _01112023_522510054_Nguyen_Phuoc_Tinh.Models;

namespace _01112023_522510054_Nguyen_Phuoc_Tinh.Repository
{
    public class LoaiSpRepository : ILoaiSpRepository
    {
        private readonly QLBanVaLiContext _context;

        public LoaiSpRepository(QLBanVaLiContext context)
        {
            _context = context;
        }
        public TLoaiSp Add(TLoaiSp loaiSP)
        {
            _context.TLoaiSps.Add(loaiSP);
            _context.SaveChanges();
            return loaiSP;
        }

        public TLoaiSp Delete(string maLoaiSP)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TLoaiSp> GetAllLoaiSP()
        {
            return _context.TLoaiSps;
        }

        public TLoaiSp GetLoaiSP(string maLoaiSP)
        {
            return _context.TLoaiSps.Find(maLoaiSP);
        }

        public TLoaiSp Update(TLoaiSp loaiSP)
        {
            _context.Update(loaiSP);
            _context.SaveChanges();
            return loaiSP;
        }
    }
}
