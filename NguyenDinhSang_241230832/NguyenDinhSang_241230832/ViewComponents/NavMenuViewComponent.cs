using Microsoft.AspNetCore.Mvc;
using NguyenDinhSang_241230832.Models;

namespace NguyenDinhSang_241230832.ViewComponents
{
    public class NavMenuViewComponent : ViewComponent
    {
        private readonly QlhangHoaContext _context;
        public NavMenuViewComponent(QlhangHoaContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var dsLoai = _context.LoaiHangs.ToList();
            return View(dsLoai);
        }
    }
}
