using System.ComponentModel.DataAnnotations;

namespace SCGPServiceGetDeliveryList.Models
{
    public class PSI03
    {
        [StringLength(3)]
        public string MOVEMENTTYPE { get; set; }

        [StringLength(4)]
        public string PLANT { get; set; }

        [StringLength(4)]
        public string STORAGE { get; set; }

        [StringLength(10)]
        public string COSTCENTER { get; set; }

        [StringLength(10)]
        public string GLACCOUNT { get; set; }

        [StringLength(10)]
        public string MATERIAL_NUMBER { get; set; }

        [StringLength(10)]
        public string BATCH_NUMBER { get; set; }

        public decimal QTY
        {
            get => QTY;
            set => decimal.Round(value, 3);
        }

        [StringLength(20)]
        public string PI_NUMBER { get; set; }

        [StringLength(20)]
        public string EO_NUMBER { get; set; }

        public decimal LENGTH
        {
            get => LENGTH;
            set => decimal.Round(value, 0);
        }

        [StringLength(20)]
        public string ITEMTEXT { get; set; }

        public decimal DIAMETER
        {
            get => LENGTH;
            set => decimal.Round(value, 0);
        }

        [StringLength(1)]
        public string SENT_TO_WMS { get; set; }

        public DateTime SENT_TO_WMS_DATETIME { get; set; }

        [StringLength(3)]
        public string CONTAINER_ITEM { get; set; }
    }
}