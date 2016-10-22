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

            return View("~/Views/Shelter/Index.cshtml");
        }

        public PartialViewResult Search(string searchValue)
        {
            var model = new ShelterSearchResltsModel() {ShelterName = "Family Shelter", NumberOfBeds = 14};

            return PartialView("~/Views/Shelter/ShelterSearchResults.cshtml");
        }
    }
}