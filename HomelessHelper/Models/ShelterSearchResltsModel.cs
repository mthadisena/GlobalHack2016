using System;
using System.Collections.Generic;
using System.Linq;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.Domain.Enum;

namespace HomelessHelper.Models
{
    public class ShelterSearchResltsModel
    {
        public Guid ShelterId { get; set; }
        public string ShelterName { get; set; }
        public ShelterType ShelterType { get; set; }
        public int NumberOfBeds => Beds.Count;
        public List<Client> Clients { get; set; } = new List<Client>();
        public List<Bed> Beds { get; set; } = new List<Bed>();
        public Address ShelterAddress { get; set; }
        public int BedsAvailable => Beds.Count - Clients.Count;
        public List<ServicesOffered> ServicesOffered { get; set; } = new List<ServicesOffered>();
        public string ServicesOfferedList => !ServicesOffered.Any()? "": string.Join(", ", ServicesOffered.Select(x=>x.ServiceType));
    }
}