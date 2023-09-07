using System.ComponentModel.DataAnnotations;

namespace SCGP.Models.GoodsTransfer;

public class MOVEMENT_ITEM_IN
{
    [Required]
    [StringLength(18)]
    public string? MATERIAL_NUMBER { get; set; }

    [Required]
    [StringLength(10)]
    public string? BATCH_NUMBER { get; set; }

    [Required]
    [StringLength(4)]
    public string? PLANT { get; set; }

    [Required]
    [StringLength(4)]
    public string? STORAGE { get; set; }

    [StringLength(50)]
    public string ITEM_TEXT { get; set; }

    [Required]
    [StringLength(3)]
    public string? MOVEMENTTYPE { get; set; }

    [StringLength(1)]
    public string MOVE_INDICATOR { get; set; }

    [StringLength(10)]
    public string PO_NUMBER { get; set; }

    [StringLength(5)]
    public string PO_ITEM { get; set; }

    [StringLength(18)]
    public string MOV_MATERIAL { get; set; }

    [StringLength(10)]
    public string MOV_BATCH { get; set; }

    [StringLength(4)]
    public string MOV_PLANT { get; set; }

    [StringLength(4)]
    public string MOV_STORAGE { get; set; }

    [Required]
    [StringLength(13)]
    public string? ENTRY_QTY { get; set; }

    [Required]
    [StringLength(3)]
    public string? ENTRY_UOM { get; set; }

    [StringLength(10)]
    public string COSTCENTER { get; set; }

    [StringLength(10)]
    public string GLACCOUNT { get; set; }

    [StringLength(20)]
    public string PI_NUMBER { get; set; }

    [StringLength(20)]
    public string EO_Number { get; set; }

    [StringLength(8)]
    public string LENGTH { get; set; }

    [StringLength(8)]
    public string DIAMETER { get; set; }

    [StringLength(3)]
    public string CONTAINER_ITEM { get; set; }

    [StringLength(10)]
    public string ROLL_BATCH { get; set; }

    /*[StringLength(8)]
    public DateTime PD_TIME 
    {
        get => PD_TIME.Date;
        set => PD_TIME = value; 
    }
*/
    public decimal CONVERSION_FACT_SQM { get; set; }
}
