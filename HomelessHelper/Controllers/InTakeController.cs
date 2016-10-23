using System;
using System.Linq;
using System.Web.Mvc;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.Domain.Enum;
using HomelessHelper.Core.EntityFramework;
using HomelessHelper.Core.Service;
using HomelessHelper.Models;
using VetStatus = HomelessHelper.Core.Domain.VetStatus;
using HomelessHelper.Utility;

namespace HomelessHelper.Controllers
{
    public class InTakeController : Controller
    {
        private readonly HomelessHelperDbContext _dbContext;

        public InTakeController()
        {
            _dbContext = new HomelessHelperDbContext();
        }
        public ActionResult Index()
        {
            return View(new InTakeModel());
        }

        [HttpPost]
        public ActionResult PostInTakeForm(InTakeModel model)
        { 
            var shelterType = ShelterType.Men;

           
            if (ModelState.IsValid) 
            {
                var clientToAdd = new Client
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    SSN = model.SSN,
                    PhoneNumber = model.PhoneNumber,
                    DateOfBirth = model.DateOfBirth,
                    Race = model.Race,
                    Gender = model.Gender,
                    Ethnicity = model.Ethnicity,
                    Email = model.Email
                };

                if (model.VetStatus != null)
                {
                    clientToAdd.VetStatus = model.VetStatus;
                }

                shelterType = ShelterTypeMapper.Map[model.Gender];
             
                if (model.IsVet)
                {
                    clientToAdd.Veteran = true;
                    shelterType = ShelterType.Veterans;
                    var warService = new WarService
                    {
                        Client = clientToAdd,
                        WarServedIn = model.VetStatus.WarServedIn.Value,
                        YearStarted = model.VetStatus.YearEnteredService.Value,
                        YearEnded = model.VetStatus.YearLeftService.Value
                    };
                    clientToAdd.WarServices.Add(warService);
                }
                 
                var shelterMatcherResult = new ShelterMatcher().Match(clientToAdd, shelterType, _dbContext);

                //clientToAdd.Shelter =  shelterMatcherResult.IsBooked? shelterMatcherResult.Shelter: null;
                if (shelterMatcherResult.IsBooked)
                {
                    //clientToAdd.Shelter = shelterMatcherResult.Shelter;
                    _dbContext.BedBookings.Add(Reserve(clientToAdd, shelterType, shelterMatcherResult.Shelter));
                }

                _dbContext.Clients.Add(clientToAdd);

                _dbContext.SaveChanges();
                return View(shelterMatcherResult);
            }; 
            return Json(false);
        }

        private BedBooking Reserve(Client client, ShelterType shelterType, Shelter shelter)
        {
            var availablebeds = _dbContext.Beds.Where(x => x.Shelter.Type == shelterType && x.BedStatus == BedStatus.Vacant).ToList();
            //var firstAvailableBed = shelter.Beds.Find(x => x.BedStatus == BedStatus.Vacant);
            if (!availablebeds.Any()) return null;
            
            return new BedBooking()
            {
                ClientId = client.Id,
                Bed = availablebeds[0],
                Shelter = availablebeds[0].Shelter,
                CheckInDate = DateTime.Today
            };

        }
    }
}
