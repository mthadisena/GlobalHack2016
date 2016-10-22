using System;
using System.ComponentModel.DataAnnotations.Schema;
using HomelessHelper.Core.EntityFramework;

namespace HomelessHelper.Core.Domain
{
    [Table("BedBooking")]
    public class BedBooking : Entity
    {
        public Guid ClientId { get; set; }
        public string BedNumber { get; set; }
       
    }
}