using System;
namespace HelloBasicCS.types
{
    public class NullableTypes
    {
        public NullableTypes()
        {
        }

        public void play()
        {
            string? NullableOfString = null;
            if (NullableOfString == null)
            {
                Console.WriteLine("Null");
            } else
            {
                Console.WriteLine("Has Length");
            }

            Nullable<int> i = null;
            if (i.HasValue)
            {
                Console.WriteLine("Has value");
            } else
            {
                Console.WriteLine("Null");
                Console.WriteLine(i.GetValueOrDefault(2));
                Console.WriteLine(i ?? 4);
            }

           

        }
    }
}
