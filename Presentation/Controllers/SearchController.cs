
using Presentation.Models;
using Presentation.Repository;
using Presentation.SearchService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class SearchController : Controller
    {
        private readonly ISearchRepository _searchRepository;

        public SearchController() : this ( new SearchRepository())
        {
        }
        public SearchController(ISearchRepository searchRepository)
        {
            _searchRepository = searchRepository;
        }

        // GET: Search
        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(SearchViewModel model)
        {
            if (ModelState.IsValid)
            {
                bool result = _searchRepository.Search(model); 
                return result == true ? View("Success") : View("Failure");
            }
            return View(model);
        }

        [Authorize]
        public ActionResult Success()
        {
            return View("Success");
        }

        [Authorize]
        public ActionResult Failure()
        {
            return View("Failure");
        }
    }
}