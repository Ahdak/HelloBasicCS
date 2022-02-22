using System;
using System.Collections;

namespace HelloBasicCS.collections
{
    public class PlayWithHashTable
    {
        public PlayWithHashTable()
        {
        }

        public void Play()
        {
            Hashtable numberNames = new Hashtable();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            foreach(DictionaryEntry e in numberNames)
            {
                Console.WriteLine($"Key={e.Key} Value={e.Value}");
            }

            var cities = new Hashtable(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            Console.WriteLine(cities["UK"]);
            Console.WriteLine(cities["EUR"]); // Null
        }
    }
}
