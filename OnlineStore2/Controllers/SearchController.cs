using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using OnlineStore2.Models;
using OnlineStore2.ViewModels;

namespace OnlineStore2.Controllers
{
    public class SearchController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public SearchController()
        {

        }

        // GET: Search
        public async Task<ActionResult> Index(string search)
        {
            var searchMotorcycle = db.Motorcycles.Where(m => m.Model.Contains(search) || search == null).ToList();
            return View(searchMotorcycle);
        }
    }
}