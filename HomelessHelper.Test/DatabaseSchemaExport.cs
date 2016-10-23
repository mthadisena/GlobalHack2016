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
            for (int i = 0; i < 100; i++)
            {

                var shelterForMen = new Shelter
                {
                    Name = $"Shelter for men {i}",
                    Type = ShelterType.Men,
                    ServicesOffered = new List<ServicesOffered>() { ServicesOffered.PermanentHousing, ServicesOffered.TemporaryHousing, ServicesOffered.JobTraining },
                    Address = new Address() { AddressLine1 = "1001 st", City = "St Louis", State = "MO", Zip = "63103" }
                };

                var beds = new List<Bed>
            {
                new Bed
                {
                    Number = "1A",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelterForMen
                },

                new Bed
                {
                    Number = "1B",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelterForMen
                },
                new Bed
                {
                    Number = "1C",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelterForMen
                }
            };
                shelterForMen.Beds = beds;

                _context.Shelters.Add(shelterForMen);
            }

            for (int i = 0; i < 100; i++)
            {

                var shelterForFamilty = new Shelter
                {
                    Name = $"Family shelter {i}",
                    Type = ShelterType.Family,
                    ServicesOffered = new List<ServicesOffered>() { ServicesOffered.PermanentHousing, ServicesOffered.TemporaryHousing, ServicesOffered.JobTraining },
                    Address = new Address() { AddressLine1 = "2001 st", City = "St Louis", State = "MO", Zip = "63104" }
                };

                var beds = new List<Bed>
            {
                new Bed
                {
                    Number = "1A",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelterForFamilty
                },

                new Bed
                {
                    Number = "1B",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelterForFamilty
                },
                new Bed
                {
                    Number = "1C",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelterForFamilty
                }
            };
                shelterForFamilty.Beds = beds;
                _context.Shelters.Add(shelterForFamilty);

            }

            for (int i = 0; i < 100; i++)
            {
                var shelterForLGBT = new Shelter
                {
                    Name = $"LGBT shelter {i}",
                    Type = ShelterType.LGBT,
                    ServicesOffered = new List<ServicesOffered>() { ServicesOffered.TemporaryHousing, ServicesOffered.JobTraining },
                    Address = new Address() { AddressLine1 = "3001 st", City = "St Louis", State = "MO", Zip = "63105" }
                };
                var beds = new List<Bed>
            {
                new Bed
                {
                    Number = "1A",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelterForLGBT
                },

                new Bed
                {
                    Number = "1B",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelterForLGBT
                },
                new Bed
                {
                    Number = "1C",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelterForLGBT
                }
            };
                shelterForLGBT.Beds = beds;
                _context.Shelters.Add(shelterForLGBT);

            }

            for (int i = 0; i < 100; i++)
            {
                var shelterForWomen = new Shelter
                {
                    Name = $" Shelter for Women {i}",
                    Type = ShelterType.Women,
                    ServicesOffered = new List<ServicesOffered>() { ServicesOffered.TemporaryHousing, ServicesOffered.JobTraining, ServicesOffered.Employment, ServicesOffered.MedicalServic },
                    Address = new Address() { AddressLine1 = "4001 st", City = "St Louis", State = "MO", Zip = "63106" }
                };
                var beds = new List<Bed>
            {
                new Bed
                {
                    Number = "1A",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelterForWomen
                },

                new Bed
                {
                    Number = "1B",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelterForWomen
                },
                new Bed
                {
                    Number = "1C",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelterForWomen
                }
            };
                shelterForWomen.Beds = beds;
                _context.Shelters.Add(shelterForWomen);

            }
            for (int i = 0; i < 100; i++)
            {

                var shelterForWomenAndChild = new Shelter
                {
                    Name = $"Shelter for Women with children {i}",
                    Type = ShelterType.WomenWithChildren,
                    ServicesOffered = new List<ServicesOffered>() { ServicesOffered.TemporaryHousing, ServicesOffered.JobTraining, ServicesOffered.Employment },
                    Address = new Address() { AddressLine1 = "5001 st", City = "St Louis", State = "MO", Zip = "63107" }
                };
                var beds = new List<Bed>
            {
                new Bed
                {
                    Number = "1A",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelterForWomenAndChild
                },

                new Bed
                {
                    Number = "1B",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelterForWomenAndChild
                },
                new Bed
                {
                    Number = "1C",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelterForWomenAndChild
                }
            };
                shelterForWomenAndChild.Beds = beds;
                _context.Shelters.Add(shelterForWomenAndChild);

            }
            for (int i = 0; i < 100; i++)
            {


                var shelter6 = new Shelter
                {
                    Name = $"Shelter for youth {i} ",
                    Type = ShelterType.Youth,
                    ServicesOffered = new List<ServicesOffered>() { ServicesOffered.TemporaryHousing, ServicesOffered.JobTraining, ServicesOffered.Employment },
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


            }
            for (int i = 0; i < 100; i++)
            {
                var veteransShelter = new Shelter
                {
                    Name = $"Shelter for veterans {i}",
                    Type = ShelterType.Veterans,
                    ServicesOffered = new List<ServicesOffered>() { ServicesOffered.TemporaryHousing, ServicesOffered.JobTraining, ServicesOffered.Employment },
                    Address = new Address() { AddressLine1 = "6001 st", City = "St Louis", State = "MO", Zip = "63108" }
                };
                var beds = new List<Bed>
            {
                new Bed
                {
                    Number = "1A",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = veteransShelter
                },

                new Bed
                {
                    Number = "1B",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = veteransShelter
                },
                new Bed
                {
                    Number = "1C",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = veteransShelter
                }
            };
                veteransShelter.Beds = beds;
                _context.Shelters.Add(veteransShelter);

            }
            _context.SaveChanges();
        }
    }
}
