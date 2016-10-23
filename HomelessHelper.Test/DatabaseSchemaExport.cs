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
                Name = "Shelter for men",
                Type = ShelterType.Men,
                ServicesOffered = new List<ServicesOffered>() {ServicesOffered.PermanentHousing, ServicesOffered.TemporaryHousing, ServicesOffered.JobTraining},
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
                ServicesOffered = new List<ServicesOffered>() { ServicesOffered.PermanentHousing, ServicesOffered.TemporaryHousing, ServicesOffered.JobTraining },
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
                ServicesOffered = new List<ServicesOffered>() { ServicesOffered.TemporaryHousing, ServicesOffered.JobTraining },
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

            var shelter4 = new Shelter
            {
                Name = "Shelter for Women",
                Type = ShelterType.Women,
                ServicesOffered = new List<ServicesOffered>() {ServicesOffered.TemporaryHousing, ServicesOffered.JobTraining, ServicesOffered.Employment, ServicesOffered.MedicalServic},
                Address = new Address() { AddressLine1 = "4001 st", City = "St Louis", State = "MO", Zip = "63106" }
            };
            var shelter4Beds = new List<Bed>
            {
                new Bed
                {
                    Number = "1A",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelter4
                },

                new Bed
                {
                    Number = "1B",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelter4
                },
                new Bed
                {
                    Number = "1C",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelter4
                }
            };
            shelter4.Beds = shelter4Beds;
            _context.Shelters.Add(shelter4);

            var shelter5 = new Shelter
            {
                Name = "Shelter for Women with children",
                Type = ShelterType.WomenWithChildren,
                ServicesOffered = new List<ServicesOffered>() {ServicesOffered.TemporaryHousing, ServicesOffered.JobTraining, ServicesOffered.Employment },
                Address = new Address() { AddressLine1 = "5001 st", City = "St Louis", State = "MO", Zip = "63107" }
            };
            var shelter5Beds = new List<Bed>
            {
                new Bed
                {
                    Number = "1A",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelter5
                },

                new Bed
                {
                    Number = "1B",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelter5
                },
                new Bed
                {
                    Number = "1C",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelter5
                }
            };
            shelter5.Beds = shelter5Beds;
            _context.Shelters.Add(shelter5);

            var shelter6 = new Shelter
            {
                Name = "Shelter for youth",
                Type = ShelterType.Youth,
                ServicesOffered = new List<ServicesOffered>() {ServicesOffered.TemporaryHousing, ServicesOffered.JobTraining, ServicesOffered.Employment },
                Address = new Address() { AddressLine1 = "6001 st", City = "St Louis", State = "MO", Zip = "63108" }
            };
            var shelter6Beds = new List<Bed>
            {
                new Bed
                {
                    Number = "1A",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelter6
                },

                new Bed
                {
                    Number = "1B",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelter6
                },
                new Bed
                {
                    Number = "1C",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelter6
                }
            };
            shelter6.Beds = shelter6Beds;
            _context.Shelters.Add(shelter6);
            
            var shelter7 = new Shelter
            {
                Name = "Shelter for veterans",
                Type = ShelterType.Veterans,
                ServicesOffered = new List<ServicesOffered>() { ServicesOffered.TemporaryHousing, ServicesOffered.JobTraining, ServicesOffered.Employment },
                Address = new Address() { AddressLine1 = "6001 st", City = "St Louis", State = "MO", Zip = "63108" }
            };
            var shelter7Beds = new List<Bed>
            {
                new Bed
                {
                    Number = "1A",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelter7
                },

                new Bed
                {
                    Number = "1B",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelter7
                },
                new Bed
                {
                    Number = "1C",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelter7
                }
            };
            shelter7.Beds = shelter7Beds;
            _context.Shelters.Add(shelter7);

            _context.SaveChanges();
        }
    }
}
