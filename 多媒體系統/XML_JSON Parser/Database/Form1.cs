using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using XML_JSON_Parser;

namespace Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_get_data_Click(object sender, EventArgs e)
        {
            Data info;
            XmlDocument doc = new XmlDocument();
            string url = @"http://download.post.gov.tw/post/download/county_h_10603.xml";
            var serializer = new XmlSerializer(typeof(Data));
            using (var reader = XmlReader.Create(url))
            {
                info = (Data)serializer.Deserialize(reader);
            }
            foreach (County country in info.Countrys)
            {
                DataGridView1.Add(country);
            }
        }
    }
}
