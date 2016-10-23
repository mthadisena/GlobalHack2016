using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.EntityFramework;

namespace HomelessHelper.Controllers
{
    public class ViewClientController : Controller
    {
        public ActionResult Index(Guid id)
        {           
            return View(new GetClientQuery().Query(id));
        }
    }

    public class GetClientQuery
    {
        private readonly HomelessHelperDbContext _context = new HomelessHelperDbContext();
        public Client Query(Guid id)
        {
            return _context.Clients.FirstOrDefault(x => x.Id == id);
        }
    }
}