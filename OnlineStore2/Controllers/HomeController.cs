﻿using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using OnlineStore2.ViewModels;
using OnlineStore2.Models;
using OnlineStore2.ViewModels;

namespace OnlineStore2.Controllers
{
    public class HomeController : Controller
    {
        private NavEcommerceDBfirstEntities_Model2OnlineStore2 db = new NavEcommerceDBfirstEntities_Model2OnlineStore2();

        public HomeController()
        {

        }

        public async Task<ActionResult> Index()
        {
            var motorcycle = db.Motorcycles.ToList();
            var brand = db.Brands.ToList();
            var streetBikes = db.Motorcycles.Where(m => m.Category.MotoCategory == "Street").ToList();
            var sportBikes = db.Motorcycles.Where(m => m.Category.MotoCategory == "Sport").ToList();
            var adventureBikes = db.Motorcycles.Where(m => m.Category.MotoCategory == "Adventure").ToList();
            var scooterBikes = db.Motorcycles.Where(m => m.Category.MotoCategory == "Scooter").ToList();
            //var categories = db.Motorcycles.Where(m => m.Category.MotoCategory == "Street" 
            //                                       || m.Category.MotoCategory == "Sport"
            //                                       || m.Category.MotoCategory == "Adventure"
            //                                       || m.Category.MotoCategory == "Scooter").ToList();

            var homeVM = new HomeVM
            {
                MotorcyclesHomeVM = motorcycle,
                BrandsHomeVM = brand,
                StreetBikesHomeVM = streetBikes,
                SportBikesHomeVM = sportBikes,
                AdventureBikesHomeVM = adventureBikes,
                ScooterBikesHomeVM = scooterBikes,
                //CategoriesHomeVM = categories
            };
            return View(homeVM);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}