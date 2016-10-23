using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.EntityFramework;
using HomelessHelper.Models;
using Microsoft.Ajax.Utilities;

namespace HomelessHelper.Controllers
{
    public class ShelterSearchController: Controller
    {
        public ActionResult Index()
        {
            var results = GetShelters(null);
            var model = new ShelterSearchModel() {Results = results};

            return View("Index", model);
        }

        public ActionResult Search(string searchTerm)
        {
            var results = GetShelters(searchTerm);

            var model = new ShelterSearchModel
            {
                SearchTerm = searchTerm,
                Results = results
            };

            return View("Index", model);
        }


        private IEnumerable<ShelterSearchResltsModel> GetShelters(string searchInput)
        {
            var dbContext = new HomelessHelperDbContext();

            if (string.IsNullOrEmpty(searchInput))
            {
                return dbContext.Shelters.Join(dbContext.Beds, shelter => shelter.Id, bed => bed.Shelter.Id,
                    (shelter, bed) => new ShelterSearchResltsModel()
                    {
                        ShelterId = shelter.Id,
                        ShelterName = shelter.Name,
                        ShelterType = shelter.Type,
                        Beds = shelter.Beds,
                        ShelterAddress = shelter.Address 
                    }).ToList().Take(15);
            }

            var results = dbContext.Shelters.Join(dbContext.Beds, shelter => shelter.Id, bed => bed.Shelter.Id,
                    (shelter, bed) => new ShelterSearchResltsModel()
                    {
                        ShelterId = shelter.Id,
                        ShelterName = shelter.Name,
                        ShelterType = shelter.Type,
                        Beds = shelter.Beds,
                        ShelterAddress = shelter.Address
                    }).Where(x=>x.ShelterName.Contains(searchInput) || x.ShelterType.ToString().Equals(searchInput, StringComparison.InvariantCultureIgnoreCase) || 
                    x.ShelterAddress.City.Equals(searchInput, StringComparison.InvariantCultureIgnoreCase) || x.ShelterAddress.Zip == searchInput).ToList().Take(15);
            
            return results;
        }
    }
}