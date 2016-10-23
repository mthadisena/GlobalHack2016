using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.EntityFramework;

namespace HomelessHelper.Core.Service
{
    public class GetClientBedBookings
    {
        private readonly HomelessHelperDbContext _context = new HomelessHelperDbContext();
        public List<BedBooking> Query(Guid clientId)
        {
            return _context.BedBookings
                .Include(x => x.Shelter)
                .Include(x => x.Bed)
                .Where(x => x.ClientId == clientId).ToList();
        }
    }
}