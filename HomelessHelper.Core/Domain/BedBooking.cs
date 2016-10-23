using System;
using System.ComponentModel.DataAnnotations.Schema;
using HomelessHelper.Core.EntityFramework;

namespace HomelessHelper.Core.Domain
{
    [Table("BedBooking")]
    public class BedBooking : Entity
    {
        public Guid ClientId { get; set; }
        public Bed Bed { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public Shelter Shelter { get; set; }
       
    }
}