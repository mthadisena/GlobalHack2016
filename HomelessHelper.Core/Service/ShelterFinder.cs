using System.Collections.Generic;
using System.Linq;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.Domain.Enum;
using HomelessHelper.Core.EntityFramework;

namespace HomelessHelper.Core.Service
{

    public interface IShelterFinder
    {
        List<Shelter> Find(ShelterType shelterType);
    }
    public class ShelterFinder: IShelterFinder
   {
       public List<Shelter> Find( ShelterType shelterType)
       {
            var dbContext = new HomelessHelperDbContext();
            return dbContext.Shelters.Where(x => x.Type == shelterType).ToList();
       }
   }
}
