using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using HomelessHelper.Core.Domain.Enum;
using HomelessHelper.Core.EntityFramework;

namespace HomelessHelper.Core.Domain
{
    [Table("Shelter")]
    public class Shelter : Entity
    {
        public Shelter()
        {
            Clients = new List<Client>();
            Beds = new List<Bed>();

        }

        public string Name { get; set; }
        public ShelterType Type { get; set; }
        public int NumberOfBeds => Beds.Count;
        public List<Client> Clients { get; set; }
        public List<Bed> Beds { get; set; }
        public List<BedBooking> Bookings { get; set; }
        public Address Address { get; set; }

        public void AddBed(Bed bed)
        {
            if (bed != null)
            {
                Beds.Add(bed);
            }
        }


    }
}