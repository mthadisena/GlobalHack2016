using HomelessHelper.Core.Domain;

namespace HomelessHelper.Core.Service
{

    public interface IShelterFinder
    {
        Shelter Find(string input);
    }
    public class ShelterFinder: IShelterFinder
   {
       public Shelter Find(string input)
       {
     
            return new Shelter();
       }
   }
}
