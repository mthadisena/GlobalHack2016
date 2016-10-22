using System;
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
            var client = new Client
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                SSN = model.SSN,
                DateOfBirth = model.DateOfBirth,
                Race = model.Race,
                Gender = model.Gender,
                VetStatus = new VetStatus
                {
                    YearEnteredService = model.VetStatus.YearEnteredService,
                    YearLeftService = model.VetStatus.YearLeftService,
                    MilitaryBranch = model.VetStatus.MilitaryBranch,
                    DischargeStatus = model.VetStatus.DischargeStatus
                },
                LivingSituation = new LivingSituation
                {
                    DateStarted = DateTime.Today
                }
            };
            dbContext.Clients.Add(client);
             
            var shelterMatcherResponse = new ShelterMatcher().Match(client, ShelterType.Men, dbContext);

            dbContext.SaveChanges();

            return View(shelterMatcherResponse);
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
