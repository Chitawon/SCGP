using System.ComponentModel.DataAnnotations;

namespace SCGPServiceGetDeliveryList.Models
{
    public class PSI04
    {
        [Key]
        [Required]
        [StringLength(10)]
        public string? BATCH_NUMBER { get; set; }

        [StringLength(18)]
        public string MATERIAL_NUMBER { get; set; }

        public DateTime PRODUCTION_DATE { get; set; }

        public decimal WIDTH_PALLET
        {
            get => WIDTH_PALLET;
            set => decimal.Round(value, 3);
        }

        public decimal LENGTH_PALLET
        {
            get => LENGTH_PALLET;
            set => decimal.Round(value, 3);
        }

        [StringLength(4)]
        public string PLANT { get; set; }

        [StringLength(4)]
        public string STORAGE { get; set; }

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
            set => decimal.Round(value, 3);
        }

        [StringLength(10)]
        public string PO_NUMBER { get; set; }

        public decimal DIAMETER
        {
            get => DIAMETER;
            set => decimal.Round(value, 3);
        }

        [StringLength(10)]
        public string ROLL_BATCH { get; set; }

        [StringLength(10)]
        public string ROLL_PRODDATE { get; set; }

        [StringLength(4)]
        public string SORTER_NUMBER { get; set; }

        [StringLength(1)]
        public string DEPARTMENT_NUMBER { get; set; }

        [StringLength(3)]
        public string CONTAINER_ITEM { get; set; }
    }
}