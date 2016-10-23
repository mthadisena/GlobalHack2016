using System;
using System.Data.Entity;
using System.Linq;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.EntityFramework;

namespace HomelessHelper.Controllers
{
    public class GetClientQuery
    {
        private readonly HomelessHelperDbContext _context = new HomelessHelperDbContext();
        public Client Query(Guid id)
        {
            return _context.Clients.Include(x => x.WarServices).FirstOrDefault(x => x.Id == id);
        }
    }
}