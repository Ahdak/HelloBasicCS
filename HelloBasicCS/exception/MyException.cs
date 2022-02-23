using System;
namespace HelloBasicCS.exception
{
    public class MyException : ApplicationException
    {
        public MyException(String message) : base(message)
        {       
        }
    }
}
