using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;

namespace HomelessHelper.Core.EntityFramework
{
    public class DatabaseManager
    {
        private readonly DbContext _context;
        
        public DatabaseManager(DbContext context)
        {
            _context = context;
        }

        public void Migrate()
        {
            var migratorConfiguration = new EFConfiguration()
            {
                TargetDatabase = new DbConnectionInfo(
                    _context.Database.Connection.ConnectionString, "System.Data.SqlClient")
            };
            var migrator = new DbMigrator(migratorConfiguration);
            migrator.Update();
        }

        public void DropAndCreate()
        {
            var initalizer = new DbContextInitializer();
            initalizer.InitializeDatabase(_context);
        }

        internal class DbContextInitializer : DropCreateDatabaseAlways<DbContext>
        {
            public override void InitializeDatabase(DbContext context)
            {
                var manager = new DatabaseManager(context);
                manager.Migrate();
                context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction
                    , $"ALTER DATABASE [{context.Database.Connection.Database}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                base.InitializeDatabase(context);
            }
        }
    }
}
