using System;
using System.Linq;
using HelloBasicCS.poo;
using HelloBasicCS.types;

namespace HelloBasicCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Playing with enums
            PlayWithEnum.CheckEnumContent();

            // I lost many code here ... bug of git

            // Static variable
            new Data();
            new Data();
            new Data();
            Enumerable.Range(0, 10).Select((i) => new Data()); // No Exec 
            Console.WriteLine("Number of data created {0}",Data.GetCounter()) ;
            // Static class
            //new NonInstanciedCalculator(); // Cannot instanciate static class
            Console.WriteLine(NonInstanciedCalculator.sum(1,2));

            // Arryas
            Console.WriteLine("-----Hello Arrays");
            new PlayWithArrays().Play();
            new PlayWithArrays().PlayWithJaggedArray();

            // Indexer
            Console.WriteLine("-----Hello Indexers");
            var indexer = new GenericIndexer<string>();
            indexer[0] = "AE";
            Console.WriteLine(indexer[0]);
            Console.WriteLine(indexer["AE"]);
            Console.WriteLine(indexer["AEZ"]);

        }
    }
}
