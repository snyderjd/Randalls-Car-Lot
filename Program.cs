using System;
using System.Collections.Generic;

namespace RandallsCarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create List
            List<Dictionary<string, Dictionary<string, string>>> vehicles = new List<Dictionary<string, Dictionary<string, string>>>();

            // Create vehicle1
            Dictionary<string, Dictionary<string, string>> vehicle1 = new Dictionary<string, Dictionary<string, string>>();
            
            Dictionary<string, string> vehicle1Vehicle = new Dictionary<string, string>();
            vehicle1Vehicle.Add("year", "2008");
            vehicle1Vehicle.Add("model", "Damfresh");
            vehicle1Vehicle.Add("make", "Biotraxquote");
            vehicle1Vehicle.Add("color", "sky magenta");

            vehicle1.Add("vehicle", vehicle1Vehicle);

            Dictionary<string, string> vehicle1SalesAgent = new Dictionary<string, string>();
            vehicle1SalesAgent.Add("mobile", "(896) 478-6975");
            vehicle1SalesAgent.Add("lastName", "Botsford");
            vehicle1SalesAgent.Add("firstName", "Shaina");

            vehicle1.Add("salesAgent", vehicle1SalesAgent);

            Dictionary<string, string> vehicle1Credit = new Dictionary<string, string>();

            vehicle1Credit.Add("creditProvider", "J.P. Morgan Chase & Co");
            vehicle1Credit.Add("account", "601109582720302");

            vehicle1.Add("credit", vehicle1Credit);

            // Create vehicle2
            Dictionary<string, Dictionary<string, string>> vehicle2 = new Dictionary<string, Dictionary<string, string>>();

            Dictionary<string, string> vehicle2Vehicle = new Dictionary<string, string>();
            vehicle2Vehicle.Add("year", "2010");
            vehicle2Vehicle.Add("model", "Hotquadtrax");
            vehicle2Vehicle.Add("make", "Transtintechno");
            vehicle2Vehicle.Add("color", "robin egg blue");

            vehicle2.Add("vehicle", vehicle2Vehicle);

            Dictionary<string, string> vehicle2SalesAgent = new Dictionary<string, string>();
            vehicle2SalesAgent.Add("mobile", "562.300.2912");
            vehicle2SalesAgent.Add("lastName", "Davis");
            vehicle2SalesAgent.Add("firstName", "Gerardo");

            vehicle2.Add("salesAgent", vehicle2SalesAgent);

            Dictionary<string, string> vehicle2Credit = new Dictionary<string, string>();
            vehicle2Credit.Add("creditProvider", "PNC Financial Services");
            vehicle2Credit.Add("account", "34578280562836");

            vehicle2.Add("credit", vehicle2Credit);

            // Add vehicles to List
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            // Print out the list to the console
            foreach (Dictionary<string, Dictionary<string, string>> vehicle in vehicles)
            {
                Console.WriteLine("--------------------");

                foreach (KeyValuePair<string, Dictionary<string, string>> kvp in vehicle)
                {
                    Console.WriteLine($"{kvp.Key}: ");
                    foreach (KeyValuePair<string, string> kvp2 in kvp.Value)
                    {
                        Console.WriteLine($"{kvp2.Key}: {kvp2.Value}");
                    }

                    Console.WriteLine("----------");
                }
            
            }

        }
    }
}

// Take the following JavaScript data structure that represents car sales and convert it to C# Lists and Dictionaries. Make sure that all of your variable names conform to the C# standard of Camel Case instead of Snake Case.

// "vehicles": [
//     {
//         "vehicle": {
//             "year": "2010",
//             "model": "Hotquadtrax",
//             "make": "Transtintechno",
//             "color": "robin egg blue"
//         },
//         "sales_agent": {
//             "mobile": "562.300.2912",
//             "last_name": "Davis",
//             "first_name": "Gerardo"
//         },
//         "credit": {
//             "credit_provider": "PNC Financial Services",
//             "account": "34578280562836"
//         }
//     }
// ]
