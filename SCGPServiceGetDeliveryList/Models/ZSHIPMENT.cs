using SCGPServiceGetDeliveryList.Extension;
using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace SCGPServiceGetDeliveryList.Models
{
    public class ZSHIPMENT
    {
        public ZSHIPMENT(XmlNode shipmentNode) 
        {
            SHIPMENT_NUMBER = shipmentNode.CheckNode("SHIPMENT_NUMBER");
            SHIPMENT_TYPE = shipmentNode.CheckNode("SHIPMENT_TYPE");
            SHIPPING_TYPE = shipmentNode.CheckNode("SHIPPING_TYPE");
            FWD_ID = shipmentNode.CheckNode("FWD_ID");
            VEHICLE_ID = shipmentNode.CheckNode("VEHICLE_ID");
            END_PLAN_DATE = shipmentNode.CheckNode("END_PLAN_DATE");
            END_PLAN_TIME = shipmentNode.CheckNode("END_PLAN_TIME");
        }

        [Required]
        [StringLength(10)]
        public string? SHIPMENT_NUMBER { get; set; }

        [Required]
        [StringLength(4)]
        public string? SHIPMENT_TYPE { get; set; }

        [Required]
        [StringLength(2)]
        public string? SHIPPING_TYPE { get; set; }

        [Required]
        [StringLength(10)]
        public string? FWD_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string? VEHICLE_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string? END_PLAN_DATE { get; set; }

        [Required]
        [StringLength(8)]
        public string? END_PLAN_TIME { get; set; }
    }
}