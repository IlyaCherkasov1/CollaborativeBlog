using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_oper__
{
    class SetValue : EventArgs
    {
        int value;
        public SetValue(int value)
        {
            this.value = value;
        }
        public int Value { get => value; set => this.value = value; }
    }
}
