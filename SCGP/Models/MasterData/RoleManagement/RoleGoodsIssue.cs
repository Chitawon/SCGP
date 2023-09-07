namespace SCGP.Models.MasterData.RoleManagement
{
    public class RoleGoodsIssue
    {
        public bool LoadDPNo { get; set; }
        public bool DisplayDPNo { get; set; }
        public bool ScanDPComplete { get; set; }
        public bool SendToSapComplete { get; set; }
        public bool SendToSapError { get; set; }
        public bool ViewWeightByDP { get; set; }
    }
}
