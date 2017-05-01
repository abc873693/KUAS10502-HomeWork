using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Databases
{
    public class PostalDatabase
    {
        private static string _connectionString= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PostalDB.mdf;Integrated Security=True";
 


        public static void Create(List<Postal> postals)
        {
            var connection = new System.Data.SqlClient.SqlConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();
            int count = 0;

            foreach (var postal in postals)
            {
                var command = new System.Data.SqlClient.SqlCommand("", connection);
                command.CommandText = string.Format(@"
                INSERT        INTO    [Table](ID,PostalCode, Section, English)
                VALUES          (N'{0}',N'{1}',N'{2}',N'{3}')
                ", count++, postal.PostalCode, postal.Section, postal.English);

                command.ExecuteNonQuery();
            }
            connection.Close();
        }


        public List<Postal> FindAllStations()
        {
            var result = new List<Postal>();
            var connection = new System.Data.SqlClient.SqlConnection(_connectionString);
            connection.Open();
            var command = new System.Data.SqlClient.SqlCommand("", connection);
            command.CommandText = @"
            Select * from [Table]";
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                Postal item = new Postal();
                //item.ID = reader["ID"].ToString();
                item.PostalCode = Convert.ToInt32(reader["PostalCode"]);
                item.Section = reader["Section"].ToString();
                item.English = reader["English"].ToString();
                result.Add(item);
            }
            connection.Close();


            return result;
        }



    }
}
