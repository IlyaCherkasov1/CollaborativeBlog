using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home2
{
    class IsOffException : ApplicationException
    {
        public IsOffException() : base ("The device is already off")
        {
        }

        public IsOffException(string message) : base(message)
        {
        }
    }
}
