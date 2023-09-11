using Microsoft.EntityFrameworkCore;
using SCGP.Models.MasterData;
using SCGP.Models.MasterData.RoleManagement;
using SCGP.Models.MasterData.Storage;
using SCGP.Models.MasterData.User;

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
