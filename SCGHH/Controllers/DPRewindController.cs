using Microsoft.AspNetCore.Mvc;

namespace SCGHH.Controllers
{
    public class DPRewindController : Controller
    {
        public IActionResult MainMenu()
        {
            return View();
        }
        public IActionResult BatchInSAP()
        {
            return View();
        }
        public IActionResult BatchNotInSAP()
        {
            return View();
        }
        public IActionResult DPDetail()
        {
            return View();
        }
    }
}
