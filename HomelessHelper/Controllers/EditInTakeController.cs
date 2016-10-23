using System;
using System.Linq;
using System.Web.Mvc;
using HomelessHelper.Core.EntityFramework;
using HomelessHelper.Models;

namespace HomelessHelper.Controllers
{
    public class EditInTakeController : Controller
    {
        private readonly HomelessHelperDbContext _dbContext;

        public EditInTakeController()
        {
            _dbContext = new HomelessHelperDbContext();
        }

        public ActionResult Index(Guid id)
        {
            var model = _dbContext.Shelter.FirstOrDefault(x => x.Id == id);

            return View(model);
        }

        public ActionResult Save(InTakeModel model)
        {
            return RedirectToAction("Index", "Search");
        }

        public ActionResult CheckOut(Guid id)
        {
            var model = _dbContext.Clients.FirstOrDefault(x => x.Id == id);

            return RedirectToAction("Index", "Search");
        }
    }
}