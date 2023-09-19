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

            CheckPO(transferForm, form);
            CheckMOMaternial(transferForm, form);
            CheckMOStorage(transferForm, form);
            CheckCostCenter(transferForm, form);
            CheckGLNo(transferForm, form);
            CheckSQM(transferForm, form);
            CheckExport(transferForm, form);

            return transferForm;
        }

        private void CheckPO(MOVEMENT_ITEM_IN transferForm, IFormCollection form)
        {
            if (transferForm.MOVEMENTTYPE == "101" || transferForm.MOVEMENTTYPE == "102") 
            {
                transferForm.MOVE_INDICATOR = form["MOVE_INDICATOR"];
                transferForm.PO_NUMBER = form["PO_NUMBER"];
                transferForm.PO_ITEM = form["PO_ITEM"];
            }
            else
            {
                transferForm.ITEM_TEXT = form["ITEM_TEXT"];
            }
        }

        private void CheckMOMaternial(MOVEMENT_ITEM_IN transferForm, IFormCollection form)
        {
            if (transferForm.MOVEMENTTYPE == "301" || transferForm.MOVEMENTTYPE == "302" 
                || transferForm.MOVEMENTTYPE == "309" || transferForm.MOVEMENTTYPE == "310")
            {
                transferForm.MOV_MATERIAL = form["MOV_MATERIAL"];
                transferForm.MOV_PLANT = form["MOV_PLANT"];
            }
        }

        private void CheckMOStorage(MOVEMENT_ITEM_IN transferForm, IFormCollection form)
        {
            if (transferForm.MOVEMENTTYPE == "301" || transferForm.MOVEMENTTYPE == "302"
                || transferForm.MOVEMENTTYPE == "309" || transferForm.MOVEMENTTYPE == "310"
                || transferForm.MOVEMENTTYPE == "311" || transferForm.MOVEMENTTYPE == "312" 
                || transferForm.MOVEMENTTYPE == "321" || transferForm.MOVEMENTTYPE == "322"
                || transferForm.MOVEMENTTYPE == "323" || transferForm.MOVEMENTTYPE == "324" 
                || transferForm.MOVEMENTTYPE == "343" || transferForm.MOVEMENTTYPE == "344")
            {
                transferForm.MOV_BATCH = form["MOV_BATCH"];
                transferForm.MOV_STORAGE = form["MOV_STORAGE"];
            }
        }

        private void CheckCostCenter(MOVEMENT_ITEM_IN transferForm, IFormCollection form)
        {
            if (transferForm.MOVEMENTTYPE == "521" || transferForm.MOVEMENTTYPE == "522" 
                || transferForm.MOVEMENTTYPE == "201" || transferForm.MOVEMENTTYPE == "202")
            {
                transferForm.COSTCENTER = form["COSTCENTER"];
            }
        }

        private void CheckGLNo(MOVEMENT_ITEM_IN transferForm, IFormCollection form)
        {
            if(transferForm.MOVEMENTTYPE == "909" || transferForm.MOVEMENTTYPE == "910")
            {
                transferForm.GLACCOUNT = form["GLACCOUNT"];
            }
        }

        private void CheckSQM(MOVEMENT_ITEM_IN transferForm, IFormCollection form)
        {
            if (transferForm.MOVEMENTTYPE == "521" || transferForm.MOVEMENTTYPE == "522")
            {
                //transferForm.PD_TIME = form["PD_TIME"];
                transferForm.CONVERSION_FACT_SQM = decimal.Parse(form["CONVERSION_FACT_SQM"]);
            }
        }

        private void CheckExport(MOVEMENT_ITEM_IN transferForm, IFormCollection form)
        {
            if (transferForm.MOVEMENTTYPE == "101" || transferForm.MOVEMENTTYPE == "102" 
                || transferForm.MOVEMENTTYPE == "521" || transferForm.MOVEMENTTYPE == "522"
                || transferForm.MOVEMENTTYPE == "201" || transferForm.MOVEMENTTYPE == "202" 
                || transferForm.MOVEMENTTYPE == "909" || transferForm.MOVEMENTTYPE == "910"
                || transferForm.MOVEMENTTYPE == "309" || transferForm.MOVEMENTTYPE == "310")
            {
                transferForm.PI_NUMBER = form["PI_NUMBER"];
                transferForm.EO_Number = form["EO_Number"];
                transferForm.LENGTH = form["LENGTH"];
                transferForm.DIAMETER = form["DIAMETER"];
                transferForm.CONTAINER_ITEM = form["CONTAINER_ITEM"];
                transferForm.ROLL_BATCH = form["ROLL_BATCH"];
            }
        }
    }
}

