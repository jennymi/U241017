using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using U241017.DATA;

namespace U241017.MVC.Controllers
{
    public class HomeController : Controller
    {
        Repository _repo = Repository.GetRepo;

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Bookings()
        {
            return View(_repo.Products);
        }

        [HttpGet]
        public ActionResult NewBooking()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewBooking(Class1 p) 
        {
            _repo.Add(p);
            return RedirectToAction("Bookings");
        }

        public ActionResult RemoveProduct(int id)
        {
            _repo.Remove(id);

            return RedirectToAction("Bookings");
        }
    }
}