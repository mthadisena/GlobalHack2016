using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using HomelessHelper.Core.Domain;
using HomelessHelper.Core.EntityFramework;
using HomelessHelper.Models;

namespace HomelessHelper.Controllers
{
    public class SearchController : Controller
    {
        private readonly HomelessHelperDbContext _dbContext;

        public SearchController()
        {
            _dbContext = new HomelessHelperDbContext();
        }

        public ActionResult Index()
        {
            return View(new SearchModel { Clients = GetHomeless() });
        }
           
        public ActionResult Search(SearchModel model)
        {
            return View("Index", new SearchModel { Clients = GetHomeless(model.SearchTerm) });
        }

        private List<Client> GetHomeless(string searchTerm = null)
        {
            return new GetClientsQuery(_dbContext).Query(searchTerm).ToList();
        }
    }

    public class GetClientsQuery
    {
        private readonly HomelessHelperDbContext _context;

        public GetClientsQuery(HomelessHelperDbContext context)
        {
            _context = context;
        }

        public List<Client> Query(string searchTerm)
        {
            var result  = new List<Client>();
            DateTime date;
            var tryDate = DateTime.TryParse(searchTerm, out date);
            long ssn;
            var trySSN = long.TryParse(searchTerm, out ssn);
            if (string.IsNullOrEmpty(searchTerm))
            {
                result = _context.Clients.ToList();
            }
            else if (tryDate)
            {
                result = _context.Clients.Where(x => x.DateOfBirth == date).ToList();
            }
            else if (searchTerm.Length == 4 && trySSN)
            {
                result = _context.Clients.Where(x => x.SSN.Contains(ssn.ToString())).ToList();
            }
            else
            {
                result = _context.Clients
               .Where(x => x.FirstName.Contains(searchTerm)
                   || x.MiddleName.Contains(searchTerm)
                   || x.LastName.Contains(searchTerm)).ToList();
            }
            return result.OrderBy(x => string.IsNullOrEmpty(x.LastName)).ThenBy(x => x.LastName).Take(50).ToList();
        }
    }
}