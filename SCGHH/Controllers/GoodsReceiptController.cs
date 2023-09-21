using Microsoft.AspNetCore.Mvc;

namespace SCGHH.Controllers
{
    public class GoodsReceiptController : Controller
    {
        public IActionResult MainMenu()
        {
            return View();
        }

        public IActionResult Mvt()
        {
            return View();
        }
        public IActionResult Products()
        {
            return View();
        }
    }
}
