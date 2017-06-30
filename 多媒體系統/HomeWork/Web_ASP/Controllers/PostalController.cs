using RV;
using RV.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_ASP.Controllers
{
    public class PostalController : Controller
    {
        private static Postal postal = null;
        private static PostalLocation postallocation = null;
        // GET: Postal
        public ActionResult Index(string search = "", int PostalCode = -1)
        {
            var postallocations = RV.Databases.PostalLocationDatabase.FindAllPostalLocation();
            var postals = RV.Databases.PostalDatabase.FindAllPostals();
            if (postallocations.Count == 0)
            {
                postallocations = PostalData.GetPostalLocation();
                RV.Databases.PostalLocationDatabase.Create(postallocations);
            }
            if (postals.Count == 0)
            {
                postals = PostalData.GetPostal();
                RV.Databases.PostalDatabase.Create(postals);
            }
            if (!string.IsNullOrEmpty(search))
                postals = postals
                    .Where(x =>
                    x.PostalCode.ToString().Contains(search) ||
                    x.Section.Contains(search))
                    .ToList();
            ViewBag.Search = search;

            if (PostalCode != -1)
            {
                foreach (var postallocation in postallocations)
                {
                    if (postallocation.PostalCode == PostalCode)
                    {
                        PostalController.postallocation = postallocation;
                    }
                }
                foreach (var postal in postals)
                {
                    if (postal.PostalCode == PostalCode)
                    {
                        PostalController.postal = postal;
                    }
                }
            }
            //ViewBag.Stations = stations;

            return View(postals);
        }

        public ActionResult Map()
        {
            if (postallocation != null && postal != null)
            {
                ViewBag.Lat = postallocation.Latitude;
                ViewBag.lng = postallocation.Longitude;
                ViewBag.PostalCode = postallocation.PostalCode;
                ViewBag.Section = postallocation.Section;
                ViewBag.English = postal.English;

            }

            return View();
        }

    }
}