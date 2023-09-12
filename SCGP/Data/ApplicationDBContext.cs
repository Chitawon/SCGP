using Microsoft.EntityFrameworkCore;
using SCGP.Models.MasterData.PlantModel;
using SCGP.Models.MasterData.RoleManagementModel;
using SCGP.Models.MasterData.ServerModel;
using SCGP.Models.MasterData.StorageModel;
using SCGP.Models.MasterData.UserModel;

namespace SCGP.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        {

        }

        public DbSet<Storage> Storages { get; set; }

        public DbSet<Plant> Plants { get; set; }

        public DbSet<Server> Servers { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }
    }
}
