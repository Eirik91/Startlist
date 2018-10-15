using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Startlist
{
    class Program
    {
        static void Main(string[] args)
        {
            var registrations = new List<Registration>();
            using (var reader = new StreamReader("startlist.csv"))
            {
                reader.ReadLine();
                while (true)
                {
                    var line = reader.ReadLine();
                    if (line == null) break;
                    var columns = line.Split(',').Select(n=>n.Trim('"')).ToArray();
                    registrations.Add( new Registration(columns));                    
                }
            }

            foreach (var registration in registrations)
            {
                registration.Show();
            }
        }
    }
}