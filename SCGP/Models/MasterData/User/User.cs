using Microsoft.AspNetCore.Identity;
using SCGP.Models.MasterData.RoleManagement;
using System.ComponentModel.DataAnnotations;

namespace SCGP.Models.MasterData.User
{
    public class User : IdentityUser
    {
        [ProtectedPersonalData]
        public override string UserName { get; set; }
        public string Company { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Sex { get; set; }

        [RegularExpression("^[a-zA-Z0-9]", ErrorMessage = "Password is not valid")]
        [ProtectedPersonalData]
        public override string PasswordHash { get; set; }
        public string AuthorizeType { get; set; }
        public Role Role { get; set; }

    }
}
