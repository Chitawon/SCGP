namespace SCGP.Models.MasterData.RoleManagementModel
{
    public class Role
    {
        public string Name { get; set; }

        public Assign AssignPC { get; set; }

        public Assign AssignPDA { get; set; }
    }
}
