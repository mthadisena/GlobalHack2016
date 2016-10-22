﻿using System;
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
            ShelterType shelterType = ShelterType.Men;

           
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

                if (model.Gender == Gender.Male)
                {
                    shelterType = ShelterType.Men;
                }
                else if (model.Gender == Gender.Female)
                {
                    shelterType = ShelterType.Women;
                }
                else if (model.Gender == Gender.ClientDoesNotKnow)
                {
                    shelterType = ShelterType.Family;
                }
                else if (model.Gender == Gender.TransgenderFemaleToMale)
                {
                    shelterType = ShelterType.LGBT;
                }
                else if (model.Gender == Gender.TransgenderMaleToFemale)
                {
                    shelterType = ShelterType.LGBT;
                }
                if (model.IsVet)
                {
                    shelterType = ShelterType.Veterans;
                }


                dbContext.Clients.Add(clientToAdd);
                var shelterMatcherResponse = new ShelterMatcher().Match(clientToAdd, shelterType, dbContext);
                dbContext.SaveChanges();
                return View(shelterMatcherResponse);
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
