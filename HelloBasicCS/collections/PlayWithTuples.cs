using System;
namespace HelloBasicCS.collections
{
    public class PlayWithTuples
    {
        public PlayWithTuples()
        {
        }

        public void Play()
        {
            Tuple<int, string, string> person = new Tuple<int, string, string>(1, "Steve", "Jobs");
            Console.WriteLine(person.Item1);
            var numbers = Tuple.Create("One", 2, 3, "Four", 5, "Six", 7, Tuple.Create(8, 9, 10, 11, 12, 13));
            Console.WriteLine(numbers.Rest);

            // Named Tuple
            (int Id, string FirstName, string LastName) namedTuple = (1, "Bill", "Gates");
            Console.WriteLine(namedTuple.FirstName);

            var person3 = (Id: 3, FirstName: "A", LastName: "DK");
            Console.WriteLine(person3.FirstName);
            Console.WriteLine(person3.Id);


            Console.WriteLine(GetData().id);

            // Desconstruct
            (int x, string name, double v) data = GetData();
            Console.WriteLine($"{data.name} => {data.x}");

        }

        public static (int id, string, double) GetData() => (1, "A", 2.0);
    }
}
