using System;
namespace HelloBasicCS.extensionmethod
{
    public class PlayWithExtensionMethod
    {
        public void Play()
        {
            int i = 4;
            Console.WriteLine(i.IsGreaterThan(5));
        }
    }

    public static class ExtensionInts
    {
        public static bool IsGreaterThan(this int i, int j)
        {
            return i > j;
        }
    }
}
