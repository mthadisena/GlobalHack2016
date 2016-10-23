using System;
using System.Collections.Generic;
using System.Linq;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.EntityFramework;

namespace HomelessHelper.Controllers
{
    public class GetClientBedBookings
    {
        private HomelessHelperDbContext _context;
        public List<BedBooking> Query(Guid clientId)
        {
            return _context.BedBookings.Where(x => x.ClientId == clientId).ToList();
        }
    }
}