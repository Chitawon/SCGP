using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SCGP.Controllers
{
    public class ReportController : Controller
    {
        // GET: /<controller>/
        public IActionResult ImportStock()
        {
            return View();
        }
        public IActionResult CheckStock()
        {
            return View();
        }
        public IActionResult InputStock()
        {
            return View();
        }
    }
}

