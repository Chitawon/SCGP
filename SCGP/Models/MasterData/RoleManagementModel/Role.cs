namespace SCGP.Models.MasterData.RoleManagementModel
{
    public class Role
    {
        public string Name { get; set; }

        public AssignPC AssignPC { get; set; }

        public AssignPDA AssignPDA { get; set; }
    }
}
