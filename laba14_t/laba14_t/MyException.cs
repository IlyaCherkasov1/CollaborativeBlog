using System;

namespace LibraryLaba14
{
    class MyException : Exception
    {
        public MyException() : base("Invalid character set")
        {
        }

        public MyException(string message) : base(message)
        {
        }
    }
}
