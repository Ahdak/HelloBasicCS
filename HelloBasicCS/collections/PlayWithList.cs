using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloBasicCS.collections
{
    public class PlayWithList
    {
        public PlayWithList()
        {
        }

        public void Play()
        {
            string[] cities = new string[3] { "Mumbai", "London", "New York" };

            var popularCities = new List<string>();

            // adding an array in a List
            popularCities.AddRange(cities);

            var favouriteCities = new List<string>();
            favouriteCities.Add("Milan");

            // adding a List 
            favouriteCities.AddRange(popularCities);

            // Linq
            var selected = (from s in favouriteCities
            where s.StartsWith("M")
            select s).ToList();

            selected.ForEach(e => Console.WriteLine(e));
        }
    }
}
