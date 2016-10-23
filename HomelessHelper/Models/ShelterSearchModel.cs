using System.Collections.Generic;

namespace HomelessHelper.Models
{
    public class ShelterSearchModel
    {
        public string SearchTerm { get; set; }
        public List<ShelterSearchResltsModel> Results { get; set; }

        public ShelterSearchModel()
        {
            Results = new List<ShelterSearchResltsModel>();
        }
            
    }
}