using System;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.Domain.Enum;
using HomelessHelper.Core.EntityFramework;

namespace HomelessHelper.Core.Service
{
    public class ShelterMatcher : IShelterMatcher
    {
        public string Match(Client client, ShelterType shelterType, HomelessHelperDbContext dbContext)
        {
            var shelterFinder = new ShelterFinder();
            var shelter = shelterFinder.Find(shelterType);
            if (shelter != null)
            {
                var bedFinder = new RoomBedFinder();

                var availableBeds = bedFinder.Find(shelter[0].Id, DateTime.Today);
                if (availableBeds != null)
                {
                    dbContext.BedBookings.Add(new BedBooking
                    {
                        BedNumber = availableBeds[0].Number,
                        ClientId = client.Id,
                        CheckInDate = DateTime.Today
                    });
                    return $"{shelter[0].Name} - {availableBeds[0].Number}";
                }
                return "No shelter available";
            }
            return "No shelter available";
        }
    }

    public interface IShelterMatcher
    {
        string Match(Client client, ShelterType shelterType, HomelessHelperDbContext dbContext);
    }
}
