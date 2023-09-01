using System.ComponentModel.DataAnnotations;

namespace SCGPServiceGetDeliveryList.Models
{
    public class MMO01Req
    {
        [Required]
        [StringLength(10)]
        public string? DOCDATE { get; set; }

        [Required]
        [StringLength(10)]
        public string? POSTDATE { get; set; }

        [StringLength(25)]
        public string HEADER_TXT { get; set; }

        [Required]
        [StringLength(20)]
        public string? IM_VENDOR { get; set; }

        [Required]
        [StringLength(40)]
        public string? GT_LOG_ID { get; set; }

        [Required]
        [StringLength(2)]
        public string? GM_CODE { get; set; }

        [Required]
        public List<MOVEMENT_ITEM_IN>? MOVEMENT_ITEM_IN { get; set; }
    }
}
