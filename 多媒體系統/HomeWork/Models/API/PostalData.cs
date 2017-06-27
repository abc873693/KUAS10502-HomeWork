using Models;
using Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace RV.API
{
    class PostalData
    {
        public static List<Postal> Get()
        {
            PostalService.XML info;
            XmlDocument doc = new XmlDocument();
            string url = @"http://download.post.gov.tw/post/download/county_h_10603.xml";
            var serializer = new XmlSerializer(typeof(PostalService.XML));
            using (var reader = XmlReader.Create(url))
            {
                info = (PostalService.XML)serializer.Deserialize(reader);
            }
            return info.Postals.ToList();
        }
    }
}
