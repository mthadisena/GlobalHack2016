using System;
using System.Collections.Generic;
using System.Linq;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.EntityFramework;
using NUnit.Framework;

namespace HomelessHelper.Test.Shelter
{
    public class ShelterRepositorySpecs
    {
        [TestFixture]
        public class ShouldReturnShelterDetails
        {
            private HomelessHelperDbContext _dbContext;

            [SetUp]
            public void Setup()
            {
                _dbContext = new HomelessHelperDbContext();
            }

            [Test]
            public void ShoudReturnShelterAndClientsAssociatedWithIt()
            {
                var guid = new Guid("4D1D68F4-D8CB-427C-986B-0DCC995F7964");
                var bedsInShelter = _dbContext.Beds.Where(x => x.Shelter.Id == guid).ToList();

                var aaa = _dbContext.BedBookings.Where(x => x.Bed.Shelter.Id == guid).ToList();

                var allClients = new List<Client>();

                bedsInShelter.ForEach(x =>
                {
                    var clientIds =_dbContext.BedBookings.Where(b => b.Bed.Id == x.Id).Select(y => y.ClientId).ToList();

                    allClients.AddRange(_dbContext.Clients.Where(c => clientIds.Contains(c.Id)).ToList());
                });

                var count = allClients.Count;
            }
        }
    }
}