using System.Collections.Generic;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.Domain.Enum;
using HomelessHelper.Core.EntityFramework;
using HomelessHelper.Core.Staging;
using NUnit.Framework;

namespace HomelessHelper.Test
{
    [TestFixture]
    public class DatabaseSchemaExport
    {
        private readonly HomelessHelperDbContext _context = new HomelessHelperDbContext();

        [Test]
        public void Export()
        {
            var manager = new DatabaseManager(_context);
            manager.DropAndCreate();
            Stage();
        }

        private void Stage()
        {
            var sampleImporter = new DataImporter(_context);
            sampleImporter.Import();

            var shelter = new Shelter
            {
                Name = "Really cool shelter"
            };
            _context.Shelters.Add(shelter);
            _context.SaveChanges();
        }
    }
}
