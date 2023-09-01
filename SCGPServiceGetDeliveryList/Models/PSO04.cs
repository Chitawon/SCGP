using System.ComponentModel.DataAnnotations;

namespace SCGPServiceGetDeliveryList.Models
{
    public class PSO04
    {
        [StringLength(10)]
        public string DOCDATE { get; set; }

        [StringLength(10)]
        public string POSTDATE { get; set; }

        [Required]
        [StringLength(10)]
        public string? BATCH_NUMBER { get; set; }

        [StringLength(3)]
        public string MOVEMENTTYPE { get; set; }

        [StringLength(4)]
        public string PLANT { get; set; }

        [StringLength(4)]
        public string STORAGE { get; set; }

        [StringLength(255)]
        public string SAPMSG { get; set; }

        public DateTime SENTDATETIME { get; set; }

        [StringLength(1)]
        public string POSTCOMPLETED { get; set; }

        [StringLength(1)]
        public string SENT_TO_SAP { get; set; }
    }
}