using System.Collections.Generic;
using HomelessHelper.Core.Domain;

namespace HomelessHelper.Models
{
    public class ViewClientModel
    {
        public Client Client { get; set; }
        public List<BedBooking> BedBookings { get; set; }
    }
}