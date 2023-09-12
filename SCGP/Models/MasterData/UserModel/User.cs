using Microsoft.AspNetCore.Identity;
using SCGP.Models.MasterData.PlantModel;
using SCGP.Models.MasterData.RoleManagementModel;
using SCGP.Models.MasterData.ServerModel;
using System.ComponentModel.DataAnnotations;

namespace SCGP.Models.MasterData.UserModel
{
    public class User : IdentityUser
    {
        [ProtectedPersonalData]
        public override string UserName { get; set; }
        public string Company { get; set; } //Change to Enum or something
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Sex { get; set; } //Change to Enum or something
        public string Status { get; set; } //Change to Enum or something

        [RegularExpression("^[a-zA-Z0-9]", ErrorMessage = "Password is not valid")]
        [ProtectedPersonalData]
        public override string PasswordHash { get; set; }
        public string AuthorizeType { get; set; } //Change to Enum or something
        public Role UserRole { get; set; }

        public List<Server> accessibleServer;

        /*public List<Storage> accessibleStorage;
        public List<Plant> accessiblePlant;*/ // Need more Detail Esp. Shipping Point data
    }
}
