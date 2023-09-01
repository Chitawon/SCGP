using System.ComponentModel.DataAnnotations;

namespace SCGPServiceGetDeliveryList.Models
{
    public class POI03
    {
        [StringLength(10)]
        public string DOCDATE { get; set; }

        [StringLength(10)]
        public string POSTDATE { get; set; }

        [Required]
        [StringLength(10)]
        public string? BATCH_NUMBER { get; set; }

        [StringLength(18)]
        public string MATERIAL_NUMBER { get; set; }

        [StringLength(3)]
        public string MOVEMENTTYPE { get; set; }

        [StringLength(4)]
        public string PLANT { get; set; }

        [StringLength(4)]
        public string STORAGE { get; set; }

        [StringLength(10)]
        public string COSTCENTER { get; set; }

        [StringLength(10)]
        public string QTY { get; set; }

        [StringLength(255)]
        public string SAPMSG { get; set; }

        [StringLength(1)]
        public string SENT_TO_SAP { get; set; }

        public DateTime SENTDATETIME { get; set; }

        [StringLength(20)]
        public string PI_NUMBER { get; set; }

        [StringLength(20)]
        public string EO_NUMBER { get; set; }

        [StringLength(10)]
        public string PO_NUMBER { get; set; }

        public decimal LENGTH
        {
            get => LENGTH;
            set => decimal.Round(value, 3);
        }

        public decimal DIAMETER
        {
            get => DIAMETER;
            set => decimal.Round(value, 3);
        }

        [StringLength(10)]
        public string ROLL_BATCH { get; set; }

        [StringLength(10)]
        public string ROLL_PRODDATE { get; set; }

        [StringLength(1)]
        public string UPDATESHORTTEXT { get; set; }

        [StringLength(255)]
        public string UPDATESHORTTEXTMSG { get; set; }
    }
}