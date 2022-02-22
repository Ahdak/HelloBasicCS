using System;
namespace HelloBasicCS.poo
{
    public class Data
    {
        private static int Counter = 0;

        static Data()
        {
            Console.WriteLine("Calling Data static construcor");
        }
        public Data()
        {
            Counter++;
        }

        public static int GetCounter()
        {
            return Counter;
        }
    }

    public static class NonInstanciedCalculator
    {
        public static int sum(int a, int b)
        {
            return a + b;
        }
    }
}
