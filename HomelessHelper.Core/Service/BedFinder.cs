using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using System.Linq;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.EntityFramework;

namespace HomelessHelper.Core.Service
{

    public interface IBedFinder
    {
        Bed Find(Guid shelterID, DateTime checkinDate);
    }
    public class RoomBedFinder: IBedFinder
    {  
        public Bed Find(Guid shelterID, DateTime checkinDate)
        {
            var dbContext = new HomelessHelperDbContext();
            var shelter = dbContext.Shelters.FirstOrDefault(x => x.Id == shelterID);

           return new Bed();
        }
    }
}