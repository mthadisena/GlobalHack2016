using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.Domain.Enum;

namespace HomelessHelper.Core.Service
{
   public class ShelterMatcher: IShelterMatcher
    {
       public string Match(Client client, ShelterType shelterType)
       {
          var shelterFinder = new ShelterFinder();
         var shelter =  shelterFinder.Find(shelterType);
            var bedFinder = new RoomBedFinder();

          var availableBeds = bedFinder.Find(shelter[0].Id, DateTime.Today);
        return string.Format("{0} - {1}", shelter[0].Name, availableBeds[0].Number); 
       }
    }

    public interface IShelterMatcher
    {
        string Match(Client client, ShelterType shelterType);
    }
}
