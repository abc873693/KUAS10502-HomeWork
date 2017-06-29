using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_ASP.Controllers
{
    public class PostalController : Controller
    {
        // GET: Postal
        public ActionResult Index(string search = "")
        {

            var stations = RV.Databases.PostalDatabase.FindAllStations();
            if (!string.IsNullOrEmpty(search))
                stations = stations
                    .Where(x =>
                    x.PostalCode.ToString().Contains(search) ||
                    x.Section.Contains(search))
                    .ToList();
            ViewBag.Search = search;
            //ViewBag.Stations = stations;

            return View(stations);
        }
    }
}