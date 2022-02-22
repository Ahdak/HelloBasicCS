using System;
using System.Collections.Generic;

namespace HelloBasicCS.collections
{
    public class PlayWithDisctionary
    {
        public PlayWithDisctionary()
        {
        }

        public void Play()
        {
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            //The following throws run-time exception: key already added.
            //numberNames.Add(3, "Three"); 

            foreach (KeyValuePair<int, string> kvp in numberNames)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            //creating a dictionary using collection-initializer syntax
            var cities = new Dictionary<string, string>(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            Console.WriteLine(cities["UK"]);

            // Console.WriteLine(cities["EU"]); // Throws KeyNotFoundException
            String result;
            cities.TryGetValue("EUR", out result);
            Console.WriteLine($"Result for Eur is -->{result}<--");

            // Override Element
            Console.WriteLine(cities["UK"]);
            cities["UK"] = "AZE";
            Console.WriteLine(cities["UK"]);

        }
    }
}
