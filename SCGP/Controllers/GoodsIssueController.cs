using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SCGP.Controllers
{
    public class GoodsIssueController : Controller
    {
        // GET: /<controller>/
        public IActionResult LoadDP()
        {
            return View();
        }
        public IActionResult DisplayDP()
        {
            return View();
        }
        public IActionResult ScanDPComplete()
        {
            return View();
        }
        public IActionResult SendToSAPComplete()
        {
            return View();
        }
        public IActionResult SendToSAPError()
        {
            return View();
        }
        public IActionResult ViewWeight()
        {
            return View();
        }
    }
}

