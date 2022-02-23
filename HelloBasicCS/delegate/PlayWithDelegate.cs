using System;
namespace HelloBasicCS.@delegate
{
    public class PlayWithDelegate
    {
        public PlayWithDelegate()
        {
        }

        public delegate void MyDelegate(string msg);
        public delegate T AddDelegate<T>(T param1, T param2); // generic delegate

        Func<int> GetRandomNumber = delegate ()
        {
            Random rnd = new Random();
            return rnd.Next(1, 100);
        };

        public void Play()
        {
            MyDelegate del =  m => Console.WriteLine($"message={m}");
            del.Invoke("first");
            MyDelegate del2 = print;
            del2.Invoke("second");

            // Do nothing ??
            MyDelegate.Combine(del).DynamicInvoke("DynamicInvoke");

            InvokeDelegate(del,"third");

            // Combine
            var del3 = del + del2;
            del3("Combined");

            // Generic
            AddDelegate<String> concat = (s1, s2) => s1 + s2;
            Console.WriteLine(concat("a", "b"));

            AddDelegate<int> sum = (s1, s2) => s1 + s2;
            Console.WriteLine(sum(1, 2));

            // function
            Func<int, int, int> sm = Adding;
            Console.WriteLine(sm(4, 3));

            // Anonymous methods
            Console.WriteLine(GetRandomNumber());

            // Action
            Action<int> printActionDel = i => Console.WriteLine($"Action prints {i}");
            printActionDel(2);

            // Predicate
            Predicate<int> isBigger = i => i > 10;
            Console.WriteLine($"Predicating 10 : {isBigger(10)}");

            // Anonymous
            CheckAnonymous();

        }

        public delegate void Print(int value);

        private void CheckAnonymous()
        {
            Print print = delegate (int val) {
                Console.WriteLine("Inside Anonymous method. Value: {0}", val);
            };

            print(100);
        }

        private int Adding(int a,int b)
        {
            return a + b;
        }

        public void print(string message)
        {
            Console.WriteLine(message);
        }

        public void InvokeDelegate(MyDelegate del, String message)
        {
            del(message);
        }

    }
}
