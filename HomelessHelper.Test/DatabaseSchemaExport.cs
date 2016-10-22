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
            var importer = new DataImporter(_context);
            importer.Import();

            var shelter1 = new Shelter
            {
                Name = "Really cool shelter",
                Type = ShelterType.Men,
                Address = new Address() { AddressLine1 = "1001 st", City = "St Louis", State = "MO", Zip = "63103"}
            };

            var shelter1Beds = new List<Bed>
            {
                new Bed
                {
                    Number = "1A",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelter1
                },

                new Bed
                {
                    Number = "1B",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelter1
                },
                new Bed
                {
                    Number = "1C",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelter1
                }
            };
            shelter1.Beds = shelter1Beds;

            _context.Shelters.Add(shelter1);

            var shelter2 = new Shelter
            {
                Name = "Family shelter",
                Type = ShelterType.Family,
                Address = new Address() { AddressLine1 = "2001 st", City = "St Louis", State = "MO", Zip = "63104" }
            };

            var shelter2Beds = new List<Bed>
            {
                new Bed
                {
                    Number = "1A",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelter2
                },

                new Bed
                {
                    Number = "1B",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelter2
                },
                new Bed
                {
                    Number = "1C",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelter2
                }
            };
            shelter2.Beds = shelter2Beds;
            _context.Shelters.Add(shelter2);

            var shelter3 = new Shelter
            {
                Name = "LGBT shelter",
                Type = ShelterType.LGBT,
                Address = new Address() { AddressLine1 = "3001 st", City = "St Louis", State = "MO", Zip = "63105" }
            };
            var shelter3Beds = new List<Bed>
            {
                new Bed
                {
                    Number = "1A",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelter3
                },

                new Bed
                {
                    Number = "1B",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelter3
                },
                new Bed
                {
                    Number = "1C",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelter3
                }
            };
            shelter3.Beds = shelter3Beds;
            _context.Shelters.Add(shelter3);

            _context.SaveChanges();
        }
    }
}
