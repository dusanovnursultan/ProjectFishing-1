using ProjectFishing.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectFishing.Controllers
{
    public class FishesController : Controller
    {
        public static Context _db = new Context();
        // GET: Fishes
        public ActionResult ShowFishes()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Fish()
        {
            var ListFishes = _db.Fishies;
            return Json(new { ListFishes }, JsonRequestBehavior.AllowGet);
        }
    }
}