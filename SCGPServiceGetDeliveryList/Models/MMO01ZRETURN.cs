using System.ComponentModel.DataAnnotations;

namespace SCGPServiceGetDeliveryList.Models
{
    public class MMO01ZRETURN
    {
        [Required]
        [StringLength(1)]
        public string? STATUS_TYPE { get; set; }

        [Required]
        [StringLength(20)]
        public string? MM_MESSAGE_ID { get; set; }

        [Required]
        [StringLength(3)]
        public string? MESSAGE_NO { get; set; }

        [Required]
        [StringLength(220)]
        public string? ERROR_MESSAGE { get; set; }
    }
}
