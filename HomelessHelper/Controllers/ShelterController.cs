using System;
using System.Linq;
using System.Web.Mvc;
using HomelessHelper.Core.EntityFramework;

namespace HomelessHelper.Controllers
{
    public class ShelterController : Controller
    {
        public PartialViewResult Index(Guid id)
        {
            var dbContext = new HomelessHelperDbContext();

            var model = dbContext.Shelters.FirstOrDefault(x => x.Id == id);

            return PartialView("Index", model);
        }

    }
}