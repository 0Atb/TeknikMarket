using Microsoft.AspNetCore.Mvc;
using TeknikMarket.CoreMVCUI.Areas.Admin.Filter;

namespace TeknikMarket.CoreMVCUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [RolFilter("Admin")]
    public class UrunController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
