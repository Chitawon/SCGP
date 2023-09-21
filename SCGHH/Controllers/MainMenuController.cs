using Microsoft.AspNetCore.Mvc;

namespace SCGHH.Controllers
{
    public class MainMenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ChangePlant()
        {
            return View();
        }
    }
}
