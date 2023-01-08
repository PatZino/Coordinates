using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using Coordinates.Models;
using System.Linq;

namespace Coordinates
{
    public static class FetchCoord
    {
        public static string FetchCoordinates()
        { 
            var conn = DatabaseConnection.Connection();
            var filePath = @"C:\PProjects\Coordinates\Utilities\coord.json";
            var myJsonString = File.ReadAllText(filePath);
            var myJObject = JObject.Parse(myJsonString).ToString();
            var obj = JsonConvert.DeserializeObject<Rootobject>(myJObject);

            foreach (var item in obj.features)
            {
                Console.WriteLine(item.properties.name);
                var lga = item.properties.name;

                foreach (var a in item.geometry.coordinates)
                {
                    foreach (var b in a)
                    {
                        foreach (var c in b)
                        {
                            SqlCommand insertCommand = new SqlCommand("INSERT INTO Boundaries (Longitude, Latitude, LGA) VALUES (@0, @1, @2)", conn);
                            insertCommand.Parameters.Add(new SqlParameter("0", c[0]));
                            insertCommand.Parameters.Add(new SqlParameter("1", c[1]));
                            insertCommand.Parameters.Add(new SqlParameter("2", lga));
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
            return "done";
        }
    }
}
