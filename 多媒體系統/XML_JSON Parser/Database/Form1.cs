using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private const string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PostalDB.MDF;Integrated Security=True";

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
                countyBindingSource.Add(country);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            var connection = new System.Data.SqlClient.SqlConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();
            int count = 0;
            foreach (County country in countyBindingSource)
            {
                var command = new System.Data.SqlClient.SqlCommand("", connection);
                command.CommandText = string.Format(@"
INSERT        INTO    [Postal](ID,PostalCode, Section, English)
VALUES          (N'{0}',N'{1}',N'{2}',N'{3}')
", count++, country.PostalCode, country.Section, country.English);

                command.ExecuteNonQuery();
            }
            var command_find = new System.Data.SqlClient.SqlCommand("", connection);
            command_find.CommandText = string.Format("SELECT COUNT (PostalCode)  FROM [Table] WHERE PostalCode IS NOT NULL");
            command_find.ExecuteNonQuery();
            List<String> strings = ReadSqlData(command_find);
            richTextBox1.AppendText("總數 = " + strings.Count);
            connection.Close();
        }

        private List<String> ReadSqlData(SqlCommand command)
        {
            List<String> strings = new List<string>();
            //4.使用SqlDataReader讀取SqlCommand物件
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    strings.Add(reader[0].ToString());
                }
            }
            finally
            {
                reader.Close();
            }
            return strings;
        }

    }
}
