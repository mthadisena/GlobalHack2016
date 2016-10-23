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