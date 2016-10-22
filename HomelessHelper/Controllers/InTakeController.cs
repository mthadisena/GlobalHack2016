using System;
using System.Web.Mvc;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.EntityFramework;
using HomelessHelper.Models;
using VetStatus = HomelessHelper.Core.Domain.VetStatus;
using HomelessHelper.Utility;

namespace HomelessHelper.Controllers
{
    public class InTakeController : Controller
    {
        private HomelessHelperDbContext dbContext;

        public InTakeController()
        {
            dbContext = new HomelessHelperDbContext();
        }
        public ActionResult Index()
        {
            return View(new InTakeModel());
        }

        [HttpPost]
        public ActionResult PostInTakeForm(InTakeModel model)
        {
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
            	dbContext.Clients.Add(clientToAdd);
            	var shelterMatcherResponse = new ShelterMatcher().Match(client, ShelterType.Men, dbContext);
            	dbContext.SaveChanges();

            	return View(shelterMatcherResponse);
            }
            return Json(false);
        }

        [HttpPost]
        public ActionResult Save(InTakeModel model)
        {
            //TODO: business logic here to find shelter and book avaliable bed

            var response = new JsonPartialResult()
            {
                Status = JsonResultStatus.Successful,
                Message = "Successfully Submitted"
            };

            return Json(response, JsonRequestBehavior.AllowGet);
        }
    }
}
