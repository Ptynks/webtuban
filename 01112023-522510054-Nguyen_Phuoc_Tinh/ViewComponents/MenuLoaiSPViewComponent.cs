using Microsoft.AspNetCore.Mvc;
using _01112023_522510054_Nguyen_Phuoc_Tinh.Repository;

namespace _01112023_522510054_Nguyen_Phuoc_Tinh.ViewComponents
{
    public class MenuLoaiSPViewComponent:ViewComponent
    {
        private readonly ILoaiSpRepository _loaiSp;
        public MenuLoaiSPViewComponent (ILoaiSpRepository loaiSpRepository)
        {
            _loaiSp = loaiSpRepository;
        }

        public IViewComponentResult Invoke()
        {
            var loaiSP = _loaiSp.GetAllLoaiSP().OrderBy(x => x.Loai);
            return View(loaiSP);
        }
    }
}
