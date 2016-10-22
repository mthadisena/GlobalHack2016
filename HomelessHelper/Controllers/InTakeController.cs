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
        public ActionResult Index(InTakeModel model)
        {
            //TODO: business logic here to find shelter and book avaliable bed
            return View(model);
        }
    }
}
