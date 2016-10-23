using System;
using System.Collections.Generic;
using System.Linq;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.Domain.Enum;
using HomelessHelper.Core.EntityFramework;

namespace HomelessHelper.Core.Service
{

    public interface IShelterMatcher
    {
        ShelterMatcherResponse Match(Client client, ShelterType shelterType, HomelessHelperDbContext dbContext);
    }
    public class ShelterMatcher : IShelterMatcher
    {
        public ShelterMatcherResponse Match(Client client, ShelterType shelterType, HomelessHelperDbContext dbContext)
        {
            var shelterFinder = new ShelterFinder();
          
            var shelter = shelterFinder.Find(shelterType);
            if (shelter != null && shelter.Any())
            {
                var bedFinder = new RoomBedFinder();

                var availableBeds = bedFinder.Find(shelter[0].Id, DateTime.Today);
                if (availableBeds != null && availableBeds.Any())
                {
                    shelter[0].Bookings.Add(new BedBooking
                    {

                        Bed = availableBeds[0],
                        ClientId = client.Id,
                        CheckInDate = DateTime.Today,
                    });
                    return new ShelterMatcherResponse
                    {
                        IsBooked = true,
                        Shelter = shelter[0],
                        Message = $"Shelter Name : {shelter[0].Name}. Bed Number : {availableBeds[0].Number}",
                        Name = $"{client.FirstName} {client.LastName}",
                        Address = shelter[0].Address

                    };
                }
                return new ShelterMatcherResponse
                {
                    Message = "No shelter available",
                    Name = $"{client.FirstName} {client.LastName}"
                };
            }
            return new ShelterMatcherResponse
            {
                Message = "No shelter available",
                Name = $"{client.FirstName} {client.LastName}"
            };
        }
    }
}

public class ShelterMatcherResponse
{
    public Shelter Shelter { get; set; }
    public string Name { get; set; }
    public bool IsBooked { get; set; }
    public string Message { get; set; }
    public Address Address { get; set; }
}
