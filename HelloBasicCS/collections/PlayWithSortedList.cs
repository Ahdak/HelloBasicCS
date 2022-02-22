using System;
using System.Collections.Generic;

namespace HelloBasicCS.collections
{
    public class PlayWithSortedList
    {
        public PlayWithSortedList()
        {
        }

        public void Play()
        {
            SortedList<int, string> numberNames = new SortedList<int, string>();
            numberNames.Add(3, "Three");
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(4, null);
            numberNames.Add(10, "Ten");
            numberNames.Add(5, "Five");

            // Iterate on keyValue
            foreach (var kv in numberNames)
            {
                Console.WriteLine($"Key ={kv.Key} Value={kv.Value}");
            }

            // Try get
            try
            {
                Console.WriteLine(numberNames[12]);
            } catch (Exception e)
            {
                Console.WriteLine("Key not found");
            }
            String result;
            var isResultFound = numberNames.TryGetValue(2, out result);
            Console.WriteLine(isResultFound ? "found " + result : "Not Found");
        }
    }
}
