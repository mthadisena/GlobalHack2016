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
        public DbSet<Bed> Beds { get; set; }
        public DbSet<BedBooking> BedBookings { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<WarService> WarService { get; set; }
        public DbSet<VetStatus> VetStatus { get; set; }
        public DbSet<LivingSituation> LivingSituation { get; set; }
        public DbSet<ClientLocation> ClientLocation { get; set; }
        public DbSet<IncomeBenefits> IncomeBenefits { get; set; }
        public DbSet<NonCashBenefits> NonCashBenefits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<HomelessHelperDbContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
