using Microsoft.AspNetCore.Mvc;
using SCGP.Models.GoodsTransfer;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SCGP.Controllers
{
    public class GoodsReceiptForPOController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create(IFormCollection form)
        {
            var submitForm = CreateGoodTransferForm(form);
            return RedirectToAction("Index");
        }

        private MOVEMENT_ITEM_IN CreateGoodTransferForm(IFormCollection form)
        {
            var transferForm = new MOVEMENT_ITEM_IN();
            transferForm.MOVEMENTTYPE = form["MOVEMENTTYPE"];
            transferForm.MATERIAL_NUMBER = form["MATERIAL_NUMBER"];
            transferForm.BATCH_NUMBER = form["BATCH_NUMBER"];

            //goodTranferForm.PLANT = form["PLANT"];
            //goodTranferForm.STORAGE = form["STORAGE"];

            transferForm.PO_NUMBER = form["PO_NUMBER"];
            transferForm.PO_ITEM = form["PO_ITEM"];
            transferForm.ENTRY_QTY = form["ENTRY_QNT"];
            transferForm.ENTRY_UOM = form["ENTRY_UOM"];
            transferForm.PI_NUMBER = form["PI_NUMBER"];
            transferForm.EO_Number = form["EO_Number"];
            transferForm.LENGTH = form["LENGTH"];
            transferForm.DIAMETER = form["DIAMETER"];
            transferForm.CONTAINER_ITEM = form["CONTAINER_ITEM"];
            transferForm.ROLL_BATCH = form["ROLL_BATCH"];

            return transferForm;
        }
    }
}

