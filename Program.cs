using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingPractices
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //create dictionary and Add elements
            Dictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            //The following throws run-time exception: key already added.
            //numberNames.Add(3, "Three");

            foreach(KeyValuePair<int,string> kvp in numberNames)
            {
                Console.WriteLine($"Key : {kvp.Key} , Value : {kvp.Value}");
            }

            //creating a dictionary using collection-initializer syntax
            var cities = new Dictionary<string, string>()
            {
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };
            foreach(var kvp in cities)
            {
                Console.WriteLine($"Key : {kvp.Key} , Value : {kvp.Value}");
            }

            Console.WriteLine(cities["UK"]); //prints value of UK key
            Console.WriteLine(cities["USA"]); //prints value of USA key
            //Console.WriteLine(cities["France"]); // run-time exception: Key does not exist

            //use ContainsKey() to check for an unknown key
            if(cities.ContainsKey("France"))
            {
                Console.WriteLine(cities["France"]);
            }

            //use TryGetValue() to get a value of unknown key
            string result;
            if (cities.TryGetValue("France", out result))
            {
                Console.WriteLine(result);
            }

            //use ElementAt() to retrieve key-value pair using index
            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                                                        cities.ElementAt(i).Key,
                                                        cities.ElementAt(i).Value);
            }


            //Update Dictionary Elements
            var city = new Dictionary<string, string>()
            {
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            city["UK"] = "Liverpool, Bristol"; // update value of UK key
            city["USA"] = "Los Angeles, Boston"; // update value of USA key
                                                 //city["France"] = "Paris"; //throws run-time exception: KeyNotFoundException

            if (city.ContainsKey("France"))
            {
                city["France"] = "Paris";
            }

            //Remove Elements in Dictionary
            //The Remove() method deletes an existing key-value pair from a dictionary.
            //The Clear() method deletes all the elements of the dictionary.
            var town = new Dictionary<string, string>()
            {
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            town.Remove("UK"); // removes UK 
                               //town.Remove("France"); //throws run-time exception: KeyNotFoundException

            if (town.ContainsKey("France"))
            { // check key before removing it
                cities.Remove("France");
            }

            town.Clear(); //removes all elements
        }
    }
}
