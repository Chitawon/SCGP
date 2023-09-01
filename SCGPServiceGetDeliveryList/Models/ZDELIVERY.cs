using SCGPServiceGetDeliveryList.Extension;
using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace SCGPServiceGetDeliveryList.Models
{
    public class ZDELIVERY
    {
        public ZDELIVERY(XmlNode deliveryNode)
        {
            DELIVERY_NUMBER = deliveryNode.CheckNode("DELIVERY_NUMBER");
            DELIVERY_DATE = deliveryNode.CheckNode("DELIVERY_DATE");
            DELIVERY_CREATE = deliveryNode.CheckNode("DELIVERY_CREATE");
            DELIVERY_TIME = deliveryNode.CheckNode("DELIVERY_TIME");
            DELIVERY_ITEM_NO = deliveryNode.CheckNode("DELIVERY_ITEM_NO");
            SHIPTO_ID = deliveryNode.CheckNode("SHIPTO_ID");
            SOLDTO_ID = deliveryNode.CheckNode("SOLDTO_ID");
            SHIPTO_NAME = deliveryNode.CheckNode("SHIPTO_NAME");
            SOLDTO_NAME = deliveryNode.CheckNode("SOLDTO_NAME");
            MATERIAL_NUMBER = deliveryNode.CheckNode("MATERIAL_NUMBER");
            MATERIAL_DES = deliveryNode.CheckNode("MATERIAL_DES");
            STORAGE = deliveryNode.CheckNode("STORAGE");
            GRADE = deliveryNode.CheckNode("GRADE");
            NET_WEIGHT = deliveryNode.CheckNode("NET_WEIGHT");
            GROSS_WEIGHT = deliveryNode.CheckNode("GROSS_WEIGHT");
            WEIGHT_UNIT = deliveryNode.CheckNode("WEIGHT_UNIT");
            PLANT = deliveryNode.CheckNode("PLANT");
            SHIPPING_POINT = deliveryNode.CheckNode("SHIPPING_POINT");
            DN_ITEM_QTY = deliveryNode.CheckNode("DN_ITEM_QTY");
            PI_NUMBER = deliveryNode.CheckNode("PI_NUMBER");
            SALES_DOCUMENT_NO = deliveryNode.CheckNode("SALES_DOCUMENT_NO");
            PO_NUMBER = deliveryNode.CheckNode("PO_NUMBER");
            SALES_ITEM_NO = deliveryNode.CheckNode("SALES_ITEM_NO");
            BASE_UNIT = deliveryNode.CheckNode("BASE_UNIT");
            SALES_UNIT = deliveryNode.CheckNode("SALES_UNIT");
            NUM_OF_PALLET = deliveryNode.CheckNode("NUM_OF_PALLET") ?? "";
            WMS_DELIVERY_NO = deliveryNode.CheckNode("WMS_DELIVERY_NO") ?? "";
            IC_TO_LOGISTIC = deliveryNode.CheckNode("IC_TO_LOGISTIC") ?? "";
            IC_TO_WAREHOUSE = deliveryNode.CheckNode("IC_TO_WAREHOUSE") ?? "";
        }

        [Required]
        [StringLength(10)]
        public string? DELIVERY_NUMBER { get; set; }

        [Required]
        [StringLength(10)]
        public string? DELIVERY_DATE { get; set; }

        [Required]
        [StringLength(10)]
        public string? DELIVERY_CREATE { get; set; }

        [Required]
        [StringLength(8)]
        public string? DELIVERY_TIME { get; set; }

        [Required]
        [StringLength(6)]
        public string? DELIVERY_ITEM_NO { get; set; }

        [Required]
        [StringLength(10)]
        public string? SHIPTO_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string? SOLDTO_ID { get; set; }

        [Required]
        [StringLength(40)]
        public string? SHIPTO_NAME { get; set; }

        [Required]
        [StringLength(40)]
        public string? SOLDTO_NAME { get; set; }

        [Required]
        [StringLength(18)]
        public string? MATERIAL_NUMBER { get; set; }

        [Required]
        [StringLength(40)]
        public string? MATERIAL_DES { get; set; }

        [Required]
        [StringLength(4)]
        public string? STORAGE { get; set; }

        [Required]
        [StringLength(6)]
        public string? GRADE { get; set; }

        [Required]
        [StringLength(19)]
        public string? NET_WEIGHT { get; set; }

        [Required]
        [StringLength(19)]
        public string? GROSS_WEIGHT { get; set; }

        [Required]
        [StringLength(3)]
        public string? WEIGHT_UNIT { get; set; }

        [Required]
        [StringLength(4)]
        public string? PLANT { get; set; }

        [Required]
        [StringLength(4)]
        public string? SHIPPING_POINT { get; set; }

        [Required]
        [StringLength(17)]
        public string? DN_ITEM_QTY { get; set; }

        [Required]
        [StringLength(10)]
        public string? PI_NUMBER { get; set; }

        [Required]
        [StringLength(10)]
        public string? SALES_DOCUMENT_NO { get; set; }

        [StringLength(35)]
        public string? PO_NUMBER { get; set; }

        [Required]
        [StringLength(6)]
        public string? SALES_ITEM_NO { get; set; }

        [Required]
        [StringLength(3)]
        public string? BASE_UNIT { get; set; }

        [Required]
        [StringLength(3)]
        public string? SALES_UNIT { get; set; }


        [StringLength(50)]
        public string NUM_OF_PALLET { get; set; }

        [StringLength(10)]
        public string WMS_DELIVERY_NO { get; set; }

        [StringLength(100)]
        public string IC_TO_LOGISTIC { get; set; }

        [StringLength(100)]
        public string IC_TO_WAREHOUSE { get; set; }

    }
}