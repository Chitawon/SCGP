namespace SCGP.Models.MasterData.RoleManagementModel
{
    public class AssignPC
    {
        public RoleMasterData MasterData { get; set; }
        public RoleGoodsTransfer GoodsTransfer { get; set; }
        public RoleGoodsIssue GoodsIssue { get; set; }
        public RoleDPRewind DPRewind { get; set; }
        public RoleReport Report { get; set; }
    }
}
