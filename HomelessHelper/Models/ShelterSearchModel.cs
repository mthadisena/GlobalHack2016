﻿using System.Collections.Generic;
using HomelessHelper.Core.Domain;

namespace HomelessHelper.Models
{
    public class ShelterSearchModel
    {
        public string SearchTerm { get; set; }
        public IEnumerable<ShelterSearchResltsModel> Results { get; set; }

        public ShelterSearchModel()
        {
            Results = new List<ShelterSearchResltsModel>();
        }
            
    }
}