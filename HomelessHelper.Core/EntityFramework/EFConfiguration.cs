using System.Data.Entity.Migrations;

namespace HomelessHelper.Core
{
    internal sealed class EFConfiguration : DbMigrationsConfiguration<HomelessHelperDbContext>
    {
        public EFConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "HomelessHelper.Core.HomelessHelperDbContext";
            ContextType = typeof(HomelessHelperDbContext);
        }       
    }
}
