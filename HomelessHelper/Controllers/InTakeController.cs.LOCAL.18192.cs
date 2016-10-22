using System;
using System.Web.Mvc;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.EntityFramework;
using HomelessHelper.Models;
using VetStatus = HomelessHelper.Core.Domain.VetStatus;

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
            dbContext.Clients.Add(new Client
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
                }

            });
            dbContext.SaveChanges();
            return View();
        }
    }
}
