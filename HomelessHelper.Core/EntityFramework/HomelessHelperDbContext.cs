using System;
using System.Data.Entity;

namespace HomelessHelper.Core.EntityFramework
{
    public class HomelessHelperDbContext : DbContext
    {
        public HomelessHelperDbContext() : base("HomelessHelper") { }
        public DbSet<Form> Form { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<HomelessHelperDbContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
