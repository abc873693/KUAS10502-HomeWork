using System;
using System.Collections.Generic;

namespace RV.Databases
{
    public  class PostalLocationDatabase
    {
        private static string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PostalDB.mdf;Integrated Security=True";



        public static void Create(List<PostalLocation> postalLocations)
        {
            var connection = new System.Data.SqlClient.SqlConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();
            int count = 0;

            foreach (var postallocation in postalLocations)
            {
                var command = new System.Data.SqlClient.SqlCommand("", connection);
                command.CommandText = string.Format(@"
                INSERT        INTO    [PostalLocation](ID,PostalCode, Section, Longitude,Latitude)
                VALUES          (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')
                ", count++, postallocation.PostalCode, postallocation.Section, postallocation.Longitude, postallocation.Latitude);

                command.ExecuteNonQuery();
            }
            connection.Close();
        }


        public static List<PostalLocation> FindAllPostalLocation()
        {
            var result = new List<PostalLocation>();
            var connection = new System.Data.SqlClient.SqlConnection(_connectionString);
            connection.Open();
            var command = new System.Data.SqlClient.SqlCommand("", connection);
            command.CommandText = @"
            Select * from [PostalLocation]";
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                PostalLocation item = new PostalLocation();
                //item.ID = reader["ID"].ToString();
                item.PostalCode = (UInt16)Convert.ToInt16(reader["PostalCode"]);
                item.Section = reader["Section"].ToString();
                item.Longitude = Convert.ToInt32(reader["Longitude"]);
                item.Latitude = Convert.ToInt32(reader["Latitude"]);
                result.Add(item);
            }
            connection.Close();


            return result;
        }
    }
}