using Models;
using Models.Databases;
using Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;

namespace Web.Controllers
{
    public class DemoContentController : Controller
    {
        // GET: DemoContent
        public ActionResult Index()
        {
           // GetData();
            var postalsDatabase = new Models.Databases.PostalDatabase();

            var postals = postalsDatabase.FindAllStations();
            var message = string.Format("共收到{0}筆郵遞區號的資料<br/>", postals.Count);
            postals.ForEach(x =>
            {
                message += string.Format("郵遞區號：{0},名稱:{1},英文名稱:{2}<br/>", x.PostalCode, x.Section, x.English);


            });
            return Content(message);
        }

        public void GetData()
        {
            var message = "";
            PostalService.XML info;
            XmlDocument doc = new XmlDocument();
            string url = @"http://download.post.gov.tw/post/download/county_h_10603.xml";
            var serializer = new XmlSerializer(typeof(PostalService.XML));
            using (var reader = XmlReader.Create(url))
            {
                info = (PostalService.XML)serializer.Deserialize(reader);
            }
            foreach (Postal postal in info.Postals)
            {
                message += string.Format("郵遞區號：{0},名稱:{1},英文名稱:{2}<br/>", postal.PostalCode, postal.Section, postal.English);
            }
            PostalDatabase.Create(info.Postals.ToList());
            //return message;
        }
    }
}