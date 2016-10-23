using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.EntityFramework;
using HomelessHelper.Models;

namespace HomelessHelper.Controllers
{
    public class ShelterSearchController: Controller
    {
        public ActionResult Index()
        {

            var model = new ShelterSearchResltsModel();

            return View("Index");
        }

        public PartialViewResult Search(string searchValue)
        {
            var model = new List<ShelterSearchResltsModel>()
            {
                new ShelterSearchResltsModel() {ShelterName = "Family Shelter", NumberOfBeds = 14}
            };

            return PartialView("ShelterSearchResults", model);
        }


        private IEnumerable<Shelter> GetShelters(string searchInput)
        {
            var dbContext = new HomelessHelperDbContext();

            if (string.IsNullOrEmpty(searchInput))
            {
               return dbContext.Shelters.ToList();
            }

            var results = dbContext.Shelters.Where(x =>
                                                    x.Name == searchInput ||
                                                    x.Type.ToString().Equals(searchInput, StringComparison.InvariantCultureIgnoreCase) ||
                                                    x.Address.City == searchInput || x.Address.Zip == searchInput).ToList();
            
            return results;
        }
    }
}