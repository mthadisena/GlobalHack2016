using System.Collections.Generic;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.EntityFramework;
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
        }

        [Test]
        public void Stage()
        { 
            var shelter = new Shelter
            {
                Name = "Really cool shelter",
                Beds = new List<Bed>
                {
                   new Bed
                   {
                       Number = "1A",
                       Description = "Clean",
                       Note = "Very Clean"
                   },

                   new Bed
                   {
                       Number = "1B",
                       Description = "Clean",
                       Note = "Very Clean"
                   },
                   new Bed
                   {
                       Number = "1C",
                       Description = "Clean",
                       Note = "Very Clean"
                   }
                }
                
            };
            _context.Shelters.Add(shelter);
            _context.SaveChanges();
        }
    }
}
