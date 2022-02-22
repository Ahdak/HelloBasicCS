using System;
namespace HelloBasicCS.types
{
    public struct Point
    {
        private readonly int X { get; }
        private readonly int Y { get; }

        public void print()
        {
            Console.WriteLine("X={0} Y={1}", X, Y);
        }
    }
}
