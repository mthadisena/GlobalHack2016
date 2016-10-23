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
                    shelterType = ShelterType.Veterans;
                }
                 
                _dbContext.Clients.Add(clientToAdd);

                var shelterMatcherResult = new ShelterMatcher().Match(clientToAdd, shelterType, _dbContext);

                //clientToAdd.Shelter =  shelterMatcherResult.IsBooked? shelterMatcherResult.Shelter: null;

                _dbContext.SaveChanges();
                return View(shelterMatcherResult);
            }; 
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
