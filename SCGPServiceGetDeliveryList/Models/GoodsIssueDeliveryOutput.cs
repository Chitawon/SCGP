using System.ComponentModel.DataAnnotations;

namespace SCGPServiceGetDeliveryList.Models
{
    public class GoodsIssueDeliveryOutput
    {
        [Required]
        [StringLength(40)]
        public string? MESSAGE_ID { get; set; }

        [Required]
        public ZRETURN? ZRETURN { get; set; }
    }
}
