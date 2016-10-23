using System;
using System.Web.Mvc;
using HomelessHelper.Core.Service;
using HomelessHelper.Models;

namespace HomelessHelper.Controllers
{
    public class ViewClientController : Controller
    {
        public PartialViewResult Index(Guid id)
        {
            var model = new ViewClientModel
            {
                BedBookings = new GetClientBedBookings().Query(id),
                Client = new GetClientQuery().Query(id)
            };
            return PartialView("Index", model);
        }
    }
}