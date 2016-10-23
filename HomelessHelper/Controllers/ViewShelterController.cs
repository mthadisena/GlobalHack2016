using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.EntityFramework;
using HomelessHelper.Core.Infrastructure;

namespace HomelessHelper.Controllers
{
    public class ViewShelterController : Controller
    {
        public PartialViewResult Index(Guid id)
        {
            return PartialView("Index", new GetShelterQuery().Query(id));
        }

        [HttpPost]
        public ActionResult CheckOut(Client client)
        {
            var dbContext = new HomelessHelperDbContext();
            dbContext.Clients.Attach(client);
            client.Shelter = null;
            client.Bed = null;
            client.BedNumber = -1;
            dbContext.SaveChanges();
            return Json(true);
        }
    }

    public class GetShelterQuery
    {
        private readonly HomelessHelperDbContext _context = new HomelessHelperDbContext();
        public Shelter Query(Guid id)
        {
            var clientIds = _context.BedBookings.Where(x => x.Shelter.Id == id).Select(y => y.ClientId).ToList();
            var clients = _context.Clients.Where(x => clientIds.Contains(x.Id)).ToList();
            var shelter = _context.Shelters.FirstOrDefault(x => x.Id == id);
            if (shelter == null) return null;
            shelter.Clients = clients;
            return shelter;
        }
    }
}