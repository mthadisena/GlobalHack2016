using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using HomelessHelper.Core.Domain.Enum;
using HomelessHelper.Core.EntityFramework;

namespace HomelessHelper.Core.Domain
{
    [Table("Shelter")]
    public class Shelter : Entity
    {
        public string Name { get; set; }
        public ShelterType Type { get; set; }
        public int NumberOfBeds => Beds.Count;
        public List<Client> Clients { get; set; } = new List<Client>();
        public List<Bed> Beds { get; set; } = new List<Bed>();
        public List<BedBooking> Bookings { get; set; } = new List<BedBooking>();
        public Address Address { get; set; }
        public int BedsAvailable => Beds.Count - Clients.Count;
        public List<ServicesOffered> ServicesOffered { get; set; }

        public void AddBed(Bed bed)
        {
            if (bed != null)
            {
                Beds.Add(bed);
            }
        }


    }
}