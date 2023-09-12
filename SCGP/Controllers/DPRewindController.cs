using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SCGP.Controllers
{
    public class DPRewindController : Controller
    {
        // GET: /<controller>/
        public IActionResult LoadRewind()
        {
            return View();
        }
        public IActionResult CreateRewind()
        {
            return View();
        }
        public IActionResult ViewDP()
        {
            return View();
        }
        public IActionResult PrintDP()
        {
            return View();
        }
        public IActionResult DPRewindReport()
        {
            return View();
        }
        public IActionResult DPRewindReciept()
        {
            return View();
        }
    }
}

