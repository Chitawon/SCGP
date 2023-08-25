﻿using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace SCGPServiceGetDeliveryList.Models
{
    public class GoodsIssueDeliveryInput
    {

        [Required]
        [StringLength(20)]
        public string? IM_VENDOR { get; set; }

        [Required]
        [StringLength(10)]
        public string? DELIVERY_NUMBER { get; set; }

        [Required]
        [StringLength(10)]
        public string? GOODS_ISSUE_DATE { get; set; }

        [Required]
        [StringLength(8)]
        public string? GOODS_ISSUE_TIME { get; set; }

        [Required]
        public ZITEM? ZITEM { get; set; }

    }
}
