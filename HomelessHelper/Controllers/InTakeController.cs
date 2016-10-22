using System.Web.Mvc;
using HomelessHelper.Models;

namespace HomelessHelper.Controllers
{
    public class InTakeController : Controller
    {
        public ActionResult Index()
        {
            return View(new InTakeModel());
        }

        [HttpPost]
        public ActionResult PostInTakeForm(InTakeModel model)
        {
            //TODO: business logic here to find shelter and book avaliable bed
            if(ModelState.IsValid) return RedirectToAction("Index", "Home");
            return Json(false);
        }
    }
}
