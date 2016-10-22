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
    }
}