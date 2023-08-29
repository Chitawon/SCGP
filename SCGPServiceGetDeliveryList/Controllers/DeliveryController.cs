using Microsoft.AspNetCore.Mvc;
using SCGPServiceGetDeliveryList.Extension;
using SCGPServiceGetDeliveryList.Models;
using SCGPServiceGetDeliveryList.Services.Delivery;
using System.Xml;

namespace SCGPServiceGetDeliveryList.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeliveryController : ControllerBase
    {
        private readonly ILogger<DeliveryController> _logger;

        private readonly IDeliveryService _deliveryService;

        private static readonly string _rootNode = "/root";

        public DeliveryController(ILogger<DeliveryController> logger, IDeliveryService deliveryService)
        {
            _logger = logger;
            _deliveryService = deliveryService;
        }

        #region Post SDI01 Delivery List

        [HttpPost("SDI01")]
        public IActionResult ReceiveDeliveryLists(List<IFormFile> files)
        {
            if (files.Count <= 0)
            {                
                return BadRequest("Please Upload File.");
            }

            List<ResultDeliveryList> respondDeli = FilesToDeliveryListModals(files);

            return Ok(respondDeli);
        }

        protected List<ResultDeliveryList> FilesToDeliveryListModals(List<IFormFile> files)
        {
            List<ResultDeliveryList> returnList = new List<ResultDeliveryList>();

            foreach (var file in files)
            {
                XmlDocument document = new XmlDocument();
                var streamFile = FileToString(file);
                document.LoadXml(streamFile);
                AddReturnList(returnList, document, false);
                AddDeliveryList(document);
            }

            return returnList;
        }

        protected void AddDeliveryList(XmlDocument doc)
        {
            List<DeliveryList> list = new List<DeliveryList>();
            List<ZDELIVERY> deliList = new List<ZDELIVERY>();
            DeliveryList deliveryList = new DeliveryList();

            var deliNode = "/ZDELIVERY/item";

            ExtractKeyInput(deliveryList, doc);

            if (_deliveryService.GetDelivery(deliveryList.ZKEY) != null)
            {
                return;
            }

            ExtractShipment(deliveryList, doc);

            foreach (XmlNode deliveryNode in doc.SelectNodes(_rootNode + deliNode))
            {
                ZDELIVERY deliveryItem = new ZDELIVERY(deliveryNode);
                deliList.Add(deliveryItem);
            }

            deliveryList.ZDELIVERY = deliList;

            _deliveryService.ReceiveDelivery(deliveryList);

            list.Add(deliveryList);
        }

        protected void ExtractKeyInput(DeliveryList delivery, XmlDocument doc)
        {
            foreach (XmlNode inputNode in doc.SelectNodes(_rootNode))
            {
                delivery.ZKEY = inputNode.CheckNode("ZKEY") ?? "";
                delivery.MESSAGE_ID = inputNode.CheckNode("MESSAGE_ID");
            }
        }

        protected void ExtractShipment(DeliveryList delivery, XmlDocument doc)
        {
            var shipNode = "/ZSHIPMENT/item";

            foreach (XmlNode shipmentNode in doc.SelectNodes(_rootNode + shipNode))
            {
                ZSHIPMENT deliveryShipment = new ZSHIPMENT(shipmentNode);
                delivery.ZSHIPMENT = deliveryShipment;
            }
        }

        #endregion

        #region Get SDI01 Delivery List

        [HttpGet("GetSDI01/{zkey}")]
        public IActionResult GetDeliveryLists(string zkey)
        {
            if (zkey.Length <= 0)
            {
                return BadRequest("Please Enter A Key.");
            }

            DeliveryList? respondDeli = _deliveryService.GetDelivery(zkey);

            return Ok(respondDeli);
        }

        #endregion

        /*#region Post SDO02 Result for Delivery List

        [HttpPost("SDO02")]
        public IActionResult RespondDeliveryLists(List<IFormFile> files)
        {
            if (files.Count <= 0)
            {
                return BadRequest("Please Upload File.");
            }

            var respondDeli = FilesToResultDeliveryModals(files);

            return Ok(respondDeli);
        }

        protected List<ResultDeliveryList> FilesToResultDeliveryModals(List<IFormFile> files)
        {
            List<ResultDeliveryList> returnList = new List<ResultDeliveryList>();

            foreach (var file in files)
            {
                XmlDocument document = new XmlDocument();
                var streamFile = FileToString(file);
                document.LoadXml(streamFile);
                AddReturnList(returnList, document, true);
            }

            return returnList;
        }

        #endregion*/

        /*#region Post SDO01 GoodsIssue

        [HttpPost("SDO01")]
        public IActionResult PostGoodsIssueDelivery(List<IFormFile> files)
        {
            if (files.Count <= 0)
            {
                return BadRequest("Please Upload File.");
            }

            var goodsIssueDeliveryList = FilesToGoodsIssueModals(files);

            return Ok(goodsIssueDeliveryList);
        }

        protected List<GoodsIssueDeliveryOutput> FilesToGoodsIssueModals(List<IFormFile> files)
        {
            var goodsList = new List<GoodsIssueDeliveryOutput>();

            foreach (var file in files)
            {
                XmlDocument document = new XmlDocument();
                var streamFile = FileToString(file);
                document.LoadXml(streamFile);
                AddGoodsIssueDeliveryList(goodsList, document);
            }

            return goodsList;
        }

        protected void AddGoodsIssueDeliveryList(List<GoodsIssueDeliveryOutput> goodsList, XmlDocument doc)
        {
            var deliNode = "/ZITEM";

            GoodsIssueDeliveryInput goodsIssueInput = new GoodsIssueDeliveryInput();

            GoodsIssueDeliveryOutput goodsIssueOutput = new GoodsIssueDeliveryOutput();

            foreach (XmlNode itemNode in doc.SelectNodes(_rootNode + deliNode))
            {
                ZITEM item = new ZITEM(itemNode);
                goodsIssueInput.ZITEM = item;
                break;
            }

            ExtractKeyGoodsIssue(goodsIssueInput, doc);

            goodsIssueOutput.ZRETURN = new ZRETURN(
                goodsIssueInput.DELIVERY_NUMBER,
                goodsIssueInput.ZITEM?.DELIVERY_ITEM_NO
                );

            goodsList.Add(goodsIssueOutput);
        }

        protected void ExtractKeyGoodsIssue(GoodsIssueDeliveryInput goodsIssueInput, XmlDocument doc)
        {
            foreach (XmlNode inputNode in doc.SelectNodes(_rootNode))
            {
                goodsIssueInput.IM_VENDOR = inputNode.CheckNode("IM_VENDOR");
                goodsIssueInput.DELIVERY_NUMBER = inputNode.CheckNode("DELIVERY_NUMBER");
                goodsIssueInput.GOODS_ISSUE_DATE = inputNode.CheckNode("GOODS_ISSUE_DATE");
                goodsIssueInput.GOODS_ISSUE_TIME = inputNode.CheckNode("GOODS_ISSUE_TIME");
            }
        }

        #endregion*/

        #region ResultDeliveryList && ZRETURN

        protected void AddReturnList(List<ResultDeliveryList> returnList, XmlDocument doc, bool returnDoc)
        {

            ResultDeliveryList resultDeliveryList = new ResultDeliveryList();
            List<ZRETURN> returnDeli = new List<ZRETURN>();

            ExtractKeyInputReturn(resultDeliveryList, doc);

            bool canSaveDB = _deliveryService.GetDelivery(resultDeliveryList.ZKEY) == null;

            var deliNode = (returnDoc) ? "/ZRETURN/item" : "/ZDELIVERY/item";
            
            foreach (XmlNode deliveryNode in doc.SelectNodes(_rootNode + deliNode))
            {
                ZRETURN? returnItem = null;

                if (!returnDoc && canSaveDB)
                {
                    returnItem = new ZRETURN(deliveryNode);
                    returnDeli.Add(returnItem);
                    break;
                }

                if (!returnDoc && !canSaveDB)
                {
                    var catchExp = new DeliveryList();
                    catchExp.ZKEY = resultDeliveryList.ZKEY;
                    returnItem = new ZRETURN(deliveryNode, _deliveryService.ReceiveDelivery(catchExp));
                    returnDeli.Add(returnItem);
                    break;
                }

                returnItem = new ZRETURN(deliveryNode, doc);
                returnDeli.Add(returnItem);
            }

            resultDeliveryList.ZRETURN = returnDeli;
            returnList.Add(resultDeliveryList);
        }

        protected void ExtractKeyInputReturn(ResultDeliveryList result, XmlDocument doc)
        {
            foreach (XmlNode inputNode in doc.SelectNodes(_rootNode))
            {
                result.ZKEY = inputNode.CheckNode("ZKEY");
                result.MESSAGE_ID_SEND = inputNode.CheckNode("MESSAGE_ID_SEND") ?? "";
                result.MESSAGE_ID_BACK = inputNode.CheckNode("MESSAGE_ID_BACK") ?? "";
            }
        }

        #endregion

        protected string FileToString(IFormFile file)
        {
            var result = "<root>";

            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                    result += reader.ReadLine();
            }

            result += "</root>";

            return result;
        }
    }
}