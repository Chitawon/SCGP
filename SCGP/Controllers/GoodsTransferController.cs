using Microsoft.AspNetCore.Mvc;
using SCGP.Models.GoodsTransfer;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SCGP.Controllers
{
    public class GoodsTransferController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IFormCollection form)
        {
            var submmitModel = CreateGoodTransferForm(form);
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

            transferForm.ENTRY_QTY = form["ENTRY_QNT"];
            transferForm.ENTRY_UOM = form["ENTRY_UOM"];
            transferForm.ITEM_TEXT = form["ITEM_TEXT"];
            transferForm.MOV_PLANT = form["MOV_PLANT"];
            transferForm.MOV_STORAGE = form["MOV_STORAGE"];
            transferForm.COSTCENTER = form["COSTCENTER"];
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

