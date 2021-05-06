using ProjectFishing.Infrastructure;
using ProjectFishing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectFishing.Controllers
{
    public class HomeController : Controller
    {
        public static Context _db = new Context();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddLakes(Lakes model)
        {
            using (_db = new Context())
            {
                if (ModelState.IsValid)
                {
                    _db.Lakes.Add(model);
                    _db.SaveChanges();
                }
            }
            return RedirectToAction("Index", "Home");
        }
        public ActionResult AddLakes()
        {
            var model = new Lakes();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddFish(Fish model)
        {
            using (_db = new Context())
            {
                if (ModelState.IsValid)
                {
                    _db.Fishies.Add(model);
                    _db.SaveChanges();
                }
            }
            return RedirectToAction("Index", "Home");
        }
        public ActionResult AddFish()
        {
            var model = new Fish();
            return View(model);
        }
    }
}