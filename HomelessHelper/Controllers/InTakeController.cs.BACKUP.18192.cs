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
<<<<<<< HEAD
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
=======
            //TODO: business logic here to find shelter and book avaliable bed
            return RedirectToAction("Index", "Home");
>>>>>>> 536e44e8cd3ce1ad29da60e216e8747e4d8c28d0
        }
    }
}
