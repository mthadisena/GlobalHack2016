using System;

namespace HomelessHelper.Core.Domain
{
    public class Visit
    {
        public Shelter Shelter { get; set; }
        public Client Client { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
