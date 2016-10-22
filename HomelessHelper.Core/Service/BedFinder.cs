using System;
using HomelessHelper.Core.Domain;

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
           return new Bed();
        }
    }
}