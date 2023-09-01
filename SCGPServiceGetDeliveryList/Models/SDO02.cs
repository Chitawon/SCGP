using System.ComponentModel.DataAnnotations;

namespace SCGPServiceGetDeliveryList.Models
{
    public class SDO02
    {
        [StringLength(24)]
        public string? ZKEY { get; set; }
        [StringLength(40)]
        public string MESSAGE_ID_SEND { get; set; }
        [StringLength(40)]
        public string MESSAGE_ID_BACK { get; set; }

        [Required]
        public List<ZRETURN>? ZRETURN { get; set; }
    }
}