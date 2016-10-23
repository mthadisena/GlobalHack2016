using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
    }
}