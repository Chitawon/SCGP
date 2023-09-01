using System.ComponentModel.DataAnnotations;

namespace SCGPServiceGetDeliveryList.Models
{
    public class MMO01Res
    {
        [StringLength(40)]
        public string MESSAGE_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string? MAT_DOC_NO { get; set; }

        [Required]
        [StringLength(4)]
        public string? MAT_DOC_YEAR { get; set; }

        [Required]
        public List<MMO01ZRETURN>? ZRETURN { get; set; }
    }
}
