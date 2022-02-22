using System;
using System.Collections;

namespace HelloBasicCS.collections
{
    public class PlayWithArrayList
    {
        public PlayWithArrayList()
        {
        }

        public void Play()
        {
            var arlist = new ArrayList()
                {
                    1,
                    "Bill",
                    300,
                    4.5f
                };

            //Access individual item using indexer
            int firstElement = (int)arlist[0]; //returns 1
            Console.WriteLine(firstElement);

            foreach (var item in arlist)
            {
                Console.Write(item + ", "); //output: 1, Bill, 300, 4.5, 
            }
            Console.WriteLine();
            for (int i = 0; i < arlist.Count; i++)
            {
                Console.Write(arlist[i] + ", "); //output: 1, Bill, 300, 4.5, 
            }
            Console.WriteLine();
        }
    }
}
