using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace XML_JSON_Parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_get_data_Click(object sender, EventArgs e)
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
                countyBindingSource.Add(country);
            }
        }

        private void ShowRand()
        {
            List<String> members = new List<String>();
            members.Add("1103105345  房志剛");
            members.Add("1103105328  丁宣文");
            members.Add("1103105325  劉俊瑋");
            members.Add("1103105356  方建任");
            members.Add("1103105305  廖華聖");
            members.Add("1103105341  陳政穎");
            members.Add("1103105331  許庭章");
            members.Add("1103137142  李淑燕");
            members.Add("1103137146  李翊銘");
            Random X = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int x = X.Next(members.Count);
                int y = X.Next(members.Count);
                String tmp = members[y];
                members[y] = members[x];
                members[x] = tmp;
            }
            String msg = "";
            for (int i = 0; i < members.Count; i++)
            {
                msg += members[i] + Environment.NewLine;
            }
            MessageBox.Show(msg);
        }
    }
}
