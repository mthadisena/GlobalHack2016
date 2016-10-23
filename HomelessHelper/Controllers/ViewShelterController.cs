using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.EntityFramework;
using HomelessHelper.Models;
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
        public ShelterDetailsModel Query(Guid guid)
        {
                        var model = new ShelterDetailsModel();
                        var Clients = new List<Client>();
            
                        model.Shelter = _context.Shelters.FirstOrDefault(x => x.Id == guid);
            
                        //var bedsInShelter = _context.Beds.Where(x => x.Shelter.Id == guid).ToList();
            
                        var clientIdsFromBB = _context.BedBookings.Where(x => x.Bed.Shelter.Id == guid).Select(b=>b.ClientId).ToList();
                        Clients.AddRange(_context.Clients.Where(c => clientIdsFromBB.Contains(c.Id)).ToList());
            
//                        bedsInShelter.ForEach(x =>
//                        {
//                            var clientIds = _context.BedBookings.Where(b => b.Bed.Id == x.Id).Select(y => y.ClientId).ToList();
//            
//                            Clients.AddRange(_context.Clients.Where(c => clientIds.Contains(c.Id)).ToList());
//                        });
            
                        model.Clients = Clients;
                        return model;
        }
    }
}