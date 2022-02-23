using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HelloBasicCS.collections;
using HelloBasicCS.@delegate;
using HelloBasicCS.exception;
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

            // Generic
            Console.WriteLine("-----Hello Generic");
            var gen = new KeyValuePairGeneric<int, string>();
            gen.Key = 1;
            gen.Value = "V";
            Console.WriteLine(gen.Key + " " + gen.Value);

            // constrains
            new GenericWithConstraint<MySubType>();
            // new GenericWithConstraint<string>(); => Not compile
            new GenericWithConstraintWithNew<ArrayList>();

            // ArrayList
            Console.WriteLine("-----Hello ArrayList");
            new PlayWithArrayList().Play();

            // List
            Console.WriteLine("-----Hello List");
            new PlayWithList().Play();

            // SortedList
            Console.WriteLine("-----Hello SortedList");
            new PlayWithSortedList().Play();

            // Dico
            Console.WriteLine("-----Hello Dico");
            new PlayWithDisctionary().Play();

            // HashTable
            new PlayWithHashTable().Play();
            Console.WriteLine("-----Hello HashTable");

            // HashTable
            new PlayWithTuples().Play();
            Console.WriteLine("-----Hello HashTable");

            // Exception
            Console.WriteLine("-----Hello Excpetion");
            PlayWithException.Play();

            // Delegate
            Console.WriteLine("-----Hello Delegate");
            new PlayWithDelegate().Play();
        }
    }
}
