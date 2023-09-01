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

        // Post Delivery/SDI01
        [HttpPost("SDI01")]
        public IActionResult ReceiveDeliveryLists(List<IFormFile> files)
        {
            if (files.Count <= 0)
            {                
                return BadRequest("Please Upload File.");
            }

            List<SDO02> respondDeli = FilesToDeliveryListModals(files);

            return Ok(respondDeli);
        }

        protected List<SDO02> FilesToDeliveryListModals(List<IFormFile> files)
        {
            List<SDO02> returnList = new List<SDO02>();

            foreach (var file in files)
            {
                XmlDocument document = new XmlDocument();
                var streamFile = FileToString(file);
                document.LoadXml(streamFile);
                AddReturnList(returnList, document);
                AddDeliveryList(document);
            }

            return returnList;
        }

        protected void AddDeliveryList(XmlDocument doc)
        {
            List<SDI01> list = new List<SDI01>();
            List<ZDELIVERY> deliList = new List<ZDELIVERY>();
            SDI01 deliveryList = new SDI01();

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

        protected void ExtractKeyInput(SDI01 delivery, XmlDocument doc)
        {
            foreach (XmlNode inputNode in doc.SelectNodes(_rootNode))
            {
                delivery.ZKEY = inputNode.CheckNode("ZKEY") ?? "";
                delivery.MESSAGE_ID = inputNode.CheckNode("MESSAGE_ID");
            }
        }

        protected void ExtractShipment(SDI01 delivery, XmlDocument doc)
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

        // Get Delivery/GetSDI01/{zkey}
        [HttpGet("GetSDI01/{zkey}")]
        public IActionResult GetDeliveryLists(string zkey)
        {
            if (zkey.Length <= 0)
            {
                return BadRequest("Please Enter A Key.");
            }

            SDI01? respondDeli = _deliveryService.GetDelivery(zkey);

            return Ok(respondDeli);
        }

        #endregion

        #region Post SDO01 GoodsIssue

        // Post Delivery/SDO01
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

        protected List<SDO01Res> FilesToGoodsIssueModals(List<IFormFile> files)
        {
            var goodsList = new List<SDO01Res>();

            foreach (var file in files)
            {
                XmlDocument document = new XmlDocument();
                var streamFile = FileToString(file);
                document.LoadXml(streamFile);
                AddGoodsIssueDeliveryList(goodsList, document);
            }

            return goodsList;
        }

        protected void AddGoodsIssueDeliveryList(List<SDO01Res> goodsList, XmlDocument doc)
        {
            var deliNode = "/ZITEM";

            SDO01Req goodsIssueReq = new SDO01Req();

            SDO01Res goodsIssueRes = new SDO01Res();

            foreach (XmlNode itemNode in doc.SelectNodes(_rootNode + deliNode))
            {
                ZITEM item = new ZITEM(itemNode);
                goodsIssueReq.ZITEM = item;
                break;
            }

            ExtractKeyGoodsIssue(goodsIssueReq, doc);

            goodsIssueRes.ZRETURN = new ZRETURN(
                goodsIssueReq.DELIVERY_NUMBER,
                goodsIssueReq.ZITEM?.DELIVERY_ITEM_NO
            );

            goodsList.Add(goodsIssueRes);
        }

        protected void ExtractKeyGoodsIssue(SDO01Req goodsIssueInput, XmlDocument doc)
        {
            foreach (XmlNode inputNode in doc.SelectNodes(_rootNode))
            {
                goodsIssueInput.IM_VENDOR = inputNode.CheckNode("IM_VENDOR");
                goodsIssueInput.DELIVERY_NUMBER = inputNode.CheckNode("DELIVERY_NUMBER");
                goodsIssueInput.GOODS_ISSUE_DATE = inputNode.CheckNode("GOODS_ISSUE_DATE");
                goodsIssueInput.GOODS_ISSUE_TIME = inputNode.CheckNode("GOODS_ISSUE_TIME");
            }
        }

        #endregion

        #region ResultDeliveryList && ZRETURN

        protected void AddReturnList(List<SDO02> returnList, XmlDocument doc)
        {
            SDO02 resultDeliveryList = new SDO02();
            List<ZRETURN> returnDeli = new List<ZRETURN>();

            ExtractKeyInputReturn(resultDeliveryList, doc);

            bool canSaveDB = _deliveryService.GetDelivery(resultDeliveryList.ZKEY) == null;

            var deliNode = "/ZDELIVERY/item";
            
            foreach (XmlNode deliveryNode in doc.SelectNodes(_rootNode + deliNode))
            {
                ZRETURN? returnItem = null;

                if (!canSaveDB)
                {
                    var catchExp = new SDI01();
                    catchExp.ZKEY = resultDeliveryList.ZKEY;
                    returnItem = new ZRETURN(deliveryNode, _deliveryService.ReceiveDelivery(catchExp));
                    returnDeli.Add(returnItem);
                    break;
                }

                returnItem = new ZRETURN(deliveryNode);
                returnDeli.Add(returnItem);
            }

            resultDeliveryList.ZRETURN = returnDeli;
            returnList.Add(resultDeliveryList);
        }

        protected void ExtractKeyInputReturn(SDO02 result, XmlDocument doc)
        {
            foreach (XmlNode inputNode in doc.SelectNodes(_rootNode))
            {
                result.ZKEY = inputNode.CheckNode("ZKEY");
                result.MESSAGE_ID_SEND = inputNode.CheckNode("MESSAGE_ID") ?? "";
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