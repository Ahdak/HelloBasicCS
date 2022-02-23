using System;
namespace HelloBasicCS.exception
{
    public class PlayWithException
    {
        public PlayWithException()
        {
        }

        public static void Play()
        {
            String number = "A";
            try
            {
                int.Parse(number);
            } catch (Exception e)
            {
                Console.WriteLine("Catching exception " + e.Message);
            }
            finally
            {
                Console.WriteLine("Finally bloc");
            }

            try
            {
                CallException();
            }
            catch (ApplicationException e)
            {
                Console.WriteLine(e.Message);
            }
        } 

        private static void CallException()
        {
            throw new MyException("my message");
        }
    }
}
