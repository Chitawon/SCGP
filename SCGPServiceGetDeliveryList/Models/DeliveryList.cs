using System.ComponentModel.DataAnnotations;

namespace SCGPServiceGetDeliveryList.Models
{
    public class DeliveryList
    {
        [StringLength(24)]
        public string ZKEY { get; set; }

        [Required]
        [StringLength(40)]
        public string? MESSAGE_ID { get; set; }

        [Required]
        public ZSHIPMENT? ZSHIPMENT { get; set; }

        [Required]
        public List<ZDELIVERY>? ZDELIVERY { get; set; }
    }
}
