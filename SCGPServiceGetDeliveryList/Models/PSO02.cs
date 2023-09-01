using System.ComponentModel.DataAnnotations;

namespace SCGPServiceGetDeliveryList.Models
{
    public class PSO02
    {
        [Required]
        [StringLength(10)]
        public string? BATCH_NUMBER { get; set; }

        [StringLength(1)]
        public string SENT_TO_WMS { get; set; }

        public DateTime SENT_TO_WMS_DATETIME { get; set; }
    }
}