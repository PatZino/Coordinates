using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;

namespace Coordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            var okay = FetchCoord.FetchCoordinates();
            Console.WriteLine(okay);
        }

    }


}
