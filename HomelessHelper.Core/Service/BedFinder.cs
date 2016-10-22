using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using System.Linq;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.EntityFramework;

namespace HomelessHelper.Core.Service
{

    public interface IBedFinder
    {
        List<Bed> Find(Guid shelterID, DateTime checkinDate);
    }
    public class RoomBedFinder: IBedFinder
    {  
        public List<Bed> Find(Guid shelterID, DateTime checkinDate)
        {
            var dbContext = new HomelessHelperDbContext();
            var shelter = dbContext.Shelters.FirstOrDefault(x => x.Id == shelterID);

            var beds = new List<Bed>();
            foreach (var bed in shelter.Beds)
            {
                var availableBeds = shelter.Bookings.FirstOrDefault(x => x.BedNumber == bed.Number);
                beds.Add(bed);
            }
           return beds;
        }
    }
}