using System.Collections.Generic;
using HomelessHelper.Core.Domain;

namespace HomelessHelper.Models
{
    public class ShelterDetailsModel
    {
        public Shelter Shelter { get; set; }
        public List<Client> Clients { get; set; }
    }
}