using SCGPServiceGetDeliveryList.Extension;
using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace SCGPServiceGetDeliveryList.Models
{
    public class ZRETURN
    {
        public ZRETURN(XmlNode deliveryNode)
        {
            DELIVERY_NUMBER = deliveryNode.CheckNode("DELIVERY_NUMBER");
            DELIVERY_ITEM_NO = deliveryNode.CheckNode("DELIVERY_ITEM_NO");
            STATUS_TYPE = (DELIVERY_NUMBER != null && DELIVERY_ITEM_NO != null) ? "S" : "E";
            ERROR_CODE = (STATUS_TYPE == "S") ? "" : "Error";
            ERROR_MESSAGE = (STATUS_TYPE == "S") ? "Received delivery successfully" : "Failed delivery";
        }

        public ZRETURN(string? dELIVERY_NUMBER, string? dELIVERY_ITEM_NO)
        {
            DELIVERY_NUMBER = dELIVERY_NUMBER;
            DELIVERY_ITEM_NO = dELIVERY_ITEM_NO;
            STATUS_TYPE = (DELIVERY_NUMBER != null && DELIVERY_ITEM_NO != null) ? "S" : "E";
            ERROR_CODE = (STATUS_TYPE == "S") ? "" : "Error";
            ERROR_MESSAGE = (STATUS_TYPE == "S") ? "Received delivery successfully" : "Failed delivery";
        }

        public ZRETURN(XmlNode deliveryNode, Exception exception)
        {
            DELIVERY_NUMBER = deliveryNode.CheckNode("DELIVERY_NUMBER");
            DELIVERY_ITEM_NO = deliveryNode.CheckNode("DELIVERY_ITEM_NO");
            ERROR_CODE = (STATUS_TYPE == "S") ? "" : "Error";
            ERROR_MESSAGE = (exception != null) ? exception.ToString() : "Received delivery successfully";
            STATUS_TYPE = (exception != null) ? "E" : "S";
        }

        [Required]
        [StringLength(10)]
        public string? DELIVERY_NUMBER { get; set; }
        [Required]
        [StringLength(6)]
        public string? DELIVERY_ITEM_NO { get; set; }
        [Required]
        [StringLength(1)]
        public string? STATUS_TYPE { get; set; }
        [Required]
        [StringLength(3)]
        public string? ERROR_CODE { get; set; }
        [Required]
        [StringLength(255)]
        public string? ERROR_MESSAGE { get; set; }
    }
}
