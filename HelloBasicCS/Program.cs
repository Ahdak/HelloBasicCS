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
        }
    }
}
