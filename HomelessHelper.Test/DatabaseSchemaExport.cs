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
                    Address = new Address() { AddressLine1 = "1001 st", City = "St Louis", State = "MO", Zip = "63103" }
                };

                shelterForMen.ServicesOffered = new List<ServicesOffered>()
                {
                    new ServicesOffered() {ServiceType = ServiceType.PermanentHousing, Shelter = shelterForMen},
                    new ServicesOffered() {ServiceType = ServiceType.TemporaryHousing, Shelter = shelterForMen},
                    new ServicesOffered() {ServiceType = ServiceType.JobTraining, Shelter = shelterForMen}
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
                    Address = new Address() { AddressLine1 = "2001 st", City = "St Louis", State = "MO", Zip = "63104" }
                };
                shelterForFamilty.ServicesOffered = new List<ServicesOffered>()
                {
                    new ServicesOffered() {ServiceType = ServiceType.PermanentHousing, Shelter = shelterForFamilty},
                    new ServicesOffered() {ServiceType = ServiceType.TemporaryHousing, Shelter = shelterForFamilty},
                    new ServicesOffered() {ServiceType = ServiceType.JobTraining, Shelter = shelterForFamilty}
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
                    Address = new Address() { AddressLine1 = "3001 st", City = "St Louis", State = "MO", Zip = "63105" }
                };
                shelterForLGBT.ServicesOffered = new List<ServicesOffered>()
                {
                    new ServicesOffered() {ServiceType = ServiceType.TemporaryHousing, Shelter = shelterForLGBT},
                    new ServicesOffered() {ServiceType = ServiceType.JobTraining, Shelter = shelterForLGBT}
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
                    Address = new Address() { AddressLine1 = "4001 st", City = "St Louis", State = "MO", Zip = "63106" }
                };
                shelterForWomen.ServicesOffered = new List<ServicesOffered>()
                {
                    new ServicesOffered() {ServiceType = ServiceType.Employment, Shelter = shelterForWomen},
                    new ServicesOffered() {ServiceType = ServiceType.MedicalServic, Shelter = shelterForWomen},
                    new ServicesOffered() {ServiceType = ServiceType.TemporaryHousing, Shelter = shelterForWomen},
                    new ServicesOffered() {ServiceType = ServiceType.JobTraining, Shelter = shelterForWomen}
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
                    Address = new Address() { AddressLine1 = "5001 st", City = "St Louis", State = "MO", Zip = "63107" }
                };
                shelterForWomenAndChild.ServicesOffered = new List<ServicesOffered>()
                {
                    new ServicesOffered() {ServiceType = ServiceType.Employment, Shelter = shelterForWomenAndChild},
                    new ServicesOffered() {ServiceType = ServiceType.TemporaryHousing, Shelter = shelterForWomenAndChild},
                    new ServicesOffered() {ServiceType = ServiceType.JobTraining, Shelter = shelterForWomenAndChild}
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
                    Address = new Address() { AddressLine1 = "6001 st", City = "St Louis", State = "MO", Zip = "63108" }
                };
                shelter6.ServicesOffered = new List<ServicesOffered>()
                {
                    new ServicesOffered() {ServiceType = ServiceType.Employment, Shelter = shelter6},
                    new ServicesOffered() {ServiceType = ServiceType.TemporaryHousing, Shelter = shelter6},
                    new ServicesOffered() {ServiceType = ServiceType.JobTraining, Shelter = shelter6}
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
                    Address = new Address() { AddressLine1 = "6001 st", City = "St Louis", State = "MO", Zip = "63108" }
                };
                veteransShelter.ServicesOffered = new List<ServicesOffered>()
                {
                    new ServicesOffered() {ServiceType = ServiceType.Employment, Shelter = veteransShelter},
                    new ServicesOffered() {ServiceType = ServiceType.TemporaryHousing, Shelter = veteransShelter},
                    new ServicesOffered() {ServiceType = ServiceType.JobTraining, Shelter = veteransShelter}
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
