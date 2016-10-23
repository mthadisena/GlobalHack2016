using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.EntityFramework;
using HomelessHelper.Models;

namespace HomelessHelper.Controllers
{
    public class ShelterController: Controller
    {
        private HomelessHelperDbContext _dbContext;

        public ShelterController()
        {
            _dbContext = new HomelessHelperDbContext();
        }

        public PartialViewResult Index(Guid id)
        {
            var model = GetClientsByShelterId(id);

            return PartialView("Index",model);
        }

        private ShelterDetailsModel GetClientsByShelterId(Guid guid)
        {
            var model = new ShelterDetailsModel();

            model.Shelter = _dbContext.Shelters.FirstOrDefault(x => x.Id == guid);

            //var guid = new Guid("4D1D68F4-D8CB-427C-986B-0DCC995F7964");
            var bedsInShelter = _dbContext.Beds.Where(x => x.Shelter.Id == guid).ToList();

            var aaa = _dbContext.BedBookings.Where(x => x.Bed.Shelter.Id == guid).ToList();

            var Clients = new List<Client>();

            bedsInShelter.ForEach(x =>
            {
                var clientIds = _dbContext.BedBookings.Where(b => b.Bed.Id == x.Id).Select(y => y.ClientId).ToList();

                Clients.AddRange(_dbContext.Clients.Where(c => clientIds.Contains(c.Id)).ToList());
            });

            model.Clients = Clients;
            return model;
        }
         
    }
}