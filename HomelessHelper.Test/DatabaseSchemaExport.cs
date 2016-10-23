using System;
using System.Collections.Generic;
using System.Linq;
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

                var shelterForMen = new Core.Domain.Shelter
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
                    Shelter = shelterForMen,
                    BedStatus = BedStatus.Vacant
                },

                new Bed
                {
                    Number = "1B",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelterForMen,
                    BedStatus = BedStatus.Vacant
                },
                new Bed
                {
                    Number = "1C",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelterForMen,
                    BedStatus = BedStatus.Vacant
                }
            };
                shelterForMen.Beds = beds;

                _context.Shelters.Add(shelterForMen);
            }

            for (int i = 0; i < 100; i++)
            {

                var shelterForFamilty = new Core.Domain.Shelter
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
                    Shelter = shelterForFamilty,
                    BedStatus = BedStatus.Vacant
                },

                new Bed
                {
                    Number = "1B",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelterForFamilty,
                    BedStatus = BedStatus.Vacant
                },
                new Bed
                {
                    Number = "1C",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelterForFamilty,
                    BedStatus = BedStatus.Vacant
                }
            };
                shelterForFamilty.Beds = beds;
                _context.Shelters.Add(shelterForFamilty);

            }

            for (int i = 0; i < 100; i++)
            {
                var shelterForLGBT = new Core.Domain.Shelter
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
                    Shelter = shelterForLGBT,
                    BedStatus = BedStatus.Vacant
                },

                new Bed
                {
                    Number = "1B",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelterForLGBT,
                    BedStatus = BedStatus.Vacant
                },
                new Bed
                {
                    Number = "1C",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelterForLGBT,
                    BedStatus = BedStatus.Vacant
                }
            };
                shelterForLGBT.Beds = beds;
                _context.Shelters.Add(shelterForLGBT);

            }

            for (int i = 0; i < 100; i++)
            {
                var shelterForWomen = new Core.Domain.Shelter
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
                    Shelter = shelterForWomen,
                    BedStatus = BedStatus.Vacant
                },

                new Bed
                {
                    Number = "1B",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelterForWomen,
                    BedStatus = BedStatus.Vacant
                },
                new Bed
                {
                    Number = "1C",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelterForWomen,
                    BedStatus = BedStatus.Vacant
                }
            };
                shelterForWomen.Beds = beds;
                _context.Shelters.Add(shelterForWomen);

            }
            for (int i = 0; i < 100; i++)
            {

                var shelterForWomenAndChild = new Core.Domain.Shelter
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
                    Shelter = shelterForWomenAndChild,
                    BedStatus = BedStatus.Vacant
                },

                new Bed
                {
                    Number = "1B",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelterForWomenAndChild,
                    BedStatus = BedStatus.Vacant
                },
                new Bed
                {
                    Number = "1C",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelterForWomenAndChild,
                    BedStatus = BedStatus.Vacant
                }
            };
                shelterForWomenAndChild.Beds = beds;
                _context.Shelters.Add(shelterForWomenAndChild);

            }
            for (int i = 0; i < 100; i++)
            {


                var shelter6 = new Core.Domain.Shelter
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
                    Shelter = shelter6,
                    BedStatus = BedStatus.Vacant
                },

                new Bed
                {
                    Number = "1B",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelter6,
                    BedStatus = BedStatus.Vacant
                },
                new Bed
                {
                    Number = "1C",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = shelter6,
                    BedStatus = BedStatus.Vacant
                }
            };
                shelter6.Beds = shelter6Beds;
                _context.Shelters.Add(shelter6);


            }
            for (int i = 0; i < 100; i++)
            {
                var veteransShelter = new Core.Domain.Shelter
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
                    Shelter = veteransShelter,
                    BedStatus = BedStatus.Vacant
                },

                new Bed
                {
                    Number = "1B",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = veteransShelter,
                    BedStatus = BedStatus.Vacant
                },
                new Bed
                {
                    Number = "1C",
                    Description = "Clean",
                    Note = "Very Clean",
                    Shelter = veteransShelter,
                    BedStatus = BedStatus.Vacant
                }
            };
                veteransShelter.Beds = beds;
                _context.Shelters.Add(veteransShelter);

            }
            _context.SaveChanges();

            var clients = _context.Clients.Where(x => !string.IsNullOrEmpty(x.FirstName)).ToList();
            var shetler = _context.Shelters.FirstOrDefault();           

            foreach (var client in clients)
            {
                var booking = new BedBooking
                {
                    Bed = new Bed
                    {
                        BedStatus = BedStatus.Occupied,
                        Description = "very beautiful bed, luxurious",
                        Note = "gross",
                        Number = "123",
                        Shelter = shetler
                    },
                    CheckInDate = new DateTime(2016, 4, 15),
                    CheckOutDate = new DateTime(2016, 5, 15),
                    ClientId = client.Id,
                    Shelter = shetler
                };

                var booking2 = new BedBooking
                {
                    Bed = new Bed
                    {
                        BedStatus = BedStatus.Occupied,
                        Description = "its a bed",
                        Note = "soft",
                        Number = "567",
                        Shelter = shetler
                    },
                    CheckInDate = new DateTime(2016, 10, 1),
                    CheckOutDate = null,
                    ClientId = client.Id,
                    Shelter = shetler
                };

                _context.BedBookings.Add(booking);
                _context.BedBookings.Add(booking2);
            }

            _context.SaveChanges();
        }
    }
}
