using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home2
{
    class IsOnException : ApplicationException
    {
        public IsOnException() : base ("The device is already on")
        {
        }

        public IsOnException(string message) : base(message)
        {
        }
    }
}
