using System;
using System.Linq;
using System.Web.Mvc;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.EntityFramework;

namespace HomelessHelper.Controllers
{
    public class ViewClientController : Controller
    {
        public PartialViewResult Index(Guid id)
        {
            return PartialView("Index", new GetClientQuery().Query(id));
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