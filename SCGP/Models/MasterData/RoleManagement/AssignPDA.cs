namespace SCGP.Models.MasterData.RoleManagement
{
    public class AssignPDA
    {
        public RoleMasterData MasterData { get; set; }
        public RoleGoodsReceipt GoodsReceipt { get; set; }
        public RoleGoodsTransfer GoodsTransfer { get; set; }
        public RoleGoodsIssue GoodsIssue { get; set; }
        public RoleDPRewind DPRewind { get; set; }
        public RoleReport Report { get; set; }
    }
}
