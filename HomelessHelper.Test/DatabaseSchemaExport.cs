using HomelessHelper.Core.Domain;
using HomelessHelper.Core.EntityFramework;
using NUnit.Framework;

namespace HomelessHelper.Test
{
    [TestFixture]
    public class DatabaseSchemaExport
    {
        private HomelessHelperDbContext _context = new HomelessHelperDbContext();

        [Test]
        public void Export()
        {
            var manager = new DatabaseManager(_context);
            manager.DropAndCreate();
        }

        [Test]
        public void Stage()
        {
            //example
            var shelter = new Shelter
            {
                Name = "Really cool shelter"
            };
            _context.Shelters.Add(shelter);
            _context.SaveChanges();
        }
    }
}
