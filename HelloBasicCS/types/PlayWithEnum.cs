using System;
namespace HelloBasicCS.types
{
    public class PlayWithEnum
    {
        public static void CheckEnumContent()
        {
            Console.WriteLine(MyDayOfWeek.Monday);
            Console.WriteLine(MyDayOfWeek.Monday.ToString());
            Console.WriteLine(DayOfWeek.Monday == DayOfWeek.Saturday);
            var value = 1;
            bool isDefined = Enum.IsDefined(typeof(MyDayOfWeek), value);
            Console.WriteLine("{0} is defined ? {1}", value, isDefined);
            Console.WriteLine("{0} is defined ? {1}", 20, Enum.IsDefined(typeof(MyDayOfWeek), 20));
            Console.WriteLine("{0} is defined ? {1}", 12, Enum.IsDefined(typeof(MyDayOfWeek), 12));
            var names = Enum.GetNames(typeof(MyDayOfWeek));
            var joinedNames = String.Join(",", names);
            Console.WriteLine("Joined Names " + joinedNames);
            Console.WriteLine("Joined Names lenght " + joinedNames.Length);
            var values = Enum.GetValues(typeof(MyDayOfWeek));
            Console.WriteLine("Iterating on values : ");
            foreach (var v in values)
            {
                Console.WriteLine("=> " + v);
            }
            Console.WriteLine("Total size : " + values.Length);
        }
    }
}
