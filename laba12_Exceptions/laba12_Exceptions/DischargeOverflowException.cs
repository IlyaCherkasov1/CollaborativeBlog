using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba12_Exceptions
{
    class DischargeOverflowException : ApplicationException
    {
        public DischargeOverflowException() : base("DischargeOverflowException")
        {
        }

        public DischargeOverflowException(string message) : base(message)
        {
        }
    }
}
