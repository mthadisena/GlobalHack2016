using System;
using System.ComponentModel.DataAnnotations.Schema;
using HomelessHelper.Core.EntityFramework;

namespace HomelessHelper.Core.Domain
{
    [Table("Visit")]
    public class Visit : Entity
    {
        public Shelter Shelter { get; set; }
        public Client Client { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
