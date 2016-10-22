using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
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
            var shelter = dbContext.Shelters.Where(x => x.Id == shelterID).Include(x => x.Beds).FirstOrDefault();

            var beds = new List<Bed>();
            foreach (var bed in shelter.Beds)
            {
                
                if (shelter.Bookings == null)
                {
                    beds.Add(bed);
                }
                else
                {
                    if (!shelter.Bookings.Any(x => x.BedNumber == bed.Number && x.CheckOutDate == null))
                    { 
                        beds.Add(bed);
                    }
                }
            }
           return beds;
        }
    }
}