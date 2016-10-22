using System.Web.Mvc;
using HomelessHelper.Core.EntityFramework;
using HomelessHelper.Models;

namespace HomelessHelper.Controllers
{
    public class SearchController : Controller
    {
        private HomelessHelperDbContext dbContext;

        public SearchController()
        {
            dbContext = new HomelessHelperDbContext();
        }

        public void FindHomeless(SearchModel search)
        {
            
        }
    }
}