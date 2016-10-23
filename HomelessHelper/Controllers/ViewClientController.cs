using System;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            return _context.Clients.Include(x => x.WarServices).FirstOrDefault(x => x.Id == id);
        }
    }
}