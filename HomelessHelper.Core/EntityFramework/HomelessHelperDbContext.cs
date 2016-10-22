using System.Data.Entity;
using HomelessHelper.Core.Domain;

namespace HomelessHelper.Core.EntityFramework
{
    public class HomelessHelperDbContext : DbContext
    {
        public HomelessHelperDbContext() : base("HomelessHelper") { }

        public DbSet<Shelter> Shelters { get; set; }
        public DbSet<ServicePerson> ServicePersons { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<HomelessHelperDbContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
