using SCGPServiceGetDeliveryList.Extension;
using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace SCGPServiceGetDeliveryList.Models
{
    public class ZITEM
    {
        public ZITEM(XmlNode itemNode)
        {
            DELIVERY_ITEM_NO = itemNode.CheckNode("DELIVERY_ITEM_NO");
            MATERIAL_NUMBER = itemNode.CheckNode("MATERIAL_NUMBER");
            BATCH_NUMBER = itemNode.CheckNode("BATCH_NUMBER");
            DELIVERY_QTY = itemNode.CheckNode("DELIVERY_QTY");
            DELIVERY_UNIT = itemNode.CheckNode("DELIVERY_UNIT");
        }

        [Required]
        [StringLength(20)]
        public string? DELIVERY_ITEM_NO { get; set; }

        [Required]
        [StringLength(20)]
        public string? MATERIAL_NUMBER { get; set; }

        [Required]
        [StringLength(20)]
        public string? BATCH_NUMBER { get; set; }

        [Required]
        [StringLength(20)]
        public string? DELIVERY_QTY { get; set; }

        [Required]
        [StringLength(20)]
        public string? DELIVERY_UNIT { get; set; }

    }
}
