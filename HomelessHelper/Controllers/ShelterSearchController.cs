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
            var model = new ShelterSearchModel();

            return View("Index", model);
        }

        public ActionResult Search(string SearchTerm)
        {
            var model = new ShelterSearchModel
            {
                SearchTerm = SearchTerm,
                Results = new List<ShelterSearchResltsModel>
                {
                    new ShelterSearchResltsModel {ShelterName = "Blah", NumberOfBeds = 20}
                }
            };

            return View("Index", model);
        }
    }
}