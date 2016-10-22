using System.Web.Mvc;
using HomelessHelper.Models;
using HomelessHelper.Utility;

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

        [HttpPost]
        public ActionResult Save(InTakeModel model)
        {
            //TODO: business logic here to find shelter and book avaliable bed

            var response = new JsonPartialResult()
            {
                Status = JsonResultStatus.Successful,
                Message = "Successfully Submitted"
            };

            return Json(response, JsonRequestBehavior.AllowGet);
        }
    }
}
