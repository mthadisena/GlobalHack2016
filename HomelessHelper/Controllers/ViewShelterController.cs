using System;
using System.Linq;
using System.Web.Mvc;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.EntityFramework;

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
            return _context.Shelters.FirstOrDefault(x => x.Id == id);
        }
    }
}