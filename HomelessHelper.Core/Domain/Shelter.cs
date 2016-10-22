using System.Collections.Generic;
using HomelessHelper.Core.Domain.Enum;

namespace HomelessHelper.Core.Domain
{
    public class Shelter
    {
        public string Name { get; set; }
        public long Id { get; set; }
        public ShelterType Type { get; set; }
        public int NumberOfBeds { get; set; }
        public List<Client> Clients { get; set; }
    }
}