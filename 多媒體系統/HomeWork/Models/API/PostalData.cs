using RV;
using RV.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using RV.Services;
using System.Reflection;
using System.IO;

namespace RV.API
{
    public class PostalData
    {
        public static List<Postal> GetPostal()
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
        public static List<DetailPostalCode> GetDetailPostal()
        {
            DetailPostalCodeService.XML info;
            XmlDocument doc = new XmlDocument();
            string url = "~\\Models\\Resource\\DetailPostalCode.xml";
            var serializer = new XmlSerializer(typeof(DetailPostalCodeService.XML));
            Assembly a = Assembly.GetExecutingAssembly();
            Stream stream = a.GetManifestResourceStream("DetailPostalCode.xml");
            using (var reader = XmlReader.Create("http://download.post.gov.tw/post/download/Xml_10510.xml"))
            {
                info = (DetailPostalCodeService.XML)serializer.Deserialize(reader);
            }
            return info.detailPostalCodes.ToList();
        }
        public static List<PostalLocation> GetPostalLocation()
        {
            PostalLocationService.XML info;
            XmlDocument doc = new XmlDocument();
            string url = @"http://download.post.gov.tw/post/download/1050812_%E8%A1%8C%E6%94%BF%E5%8D%80%E7%B6%93%E7%B7%AF%E5%BA%A6%28toPost%29.xml";
            var serializer = new XmlSerializer(typeof(PostalLocationService.XML));
            using (var reader = XmlReader.Create(url))
            {
                info = (PostalLocationService.XML)serializer.Deserialize(reader);
            }
            return info.Item1050429_行政區經緯度toPost.ToList();
        }
    }



}
