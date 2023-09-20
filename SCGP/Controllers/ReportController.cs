using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public IActionResult ReportStockSapBarcode()
        {
            return View();
        }
        public IActionResult ReportStockCountDiff()
        {
            return View();
        }
        public IActionResult ReportStockCountByGradeSize()
        {
            return View();
        }
        public IActionResult ReportStockCountSection()
        {
            return View();
        }
        public IActionResult ReportGoodsReceiptByBatch()
        {
            return View();
        }
        public IActionResult ReportGoodsReceiptByMaterial()
        {
            return View();
        }
        public IActionResult ReportGoodsIssueByBatch()
        {
            return View();
        }
        public IActionResult ReportGoodsIssueByMaterial()
        {
            return View();
        }
        public IActionResult ReportGoodsTransferByBatch()
        {
            return View();
        }
    }
}

