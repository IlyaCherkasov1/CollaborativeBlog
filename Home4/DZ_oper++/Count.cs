using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_oper__
{
    class Count
    {
        public  event EventHandler<SetValue> krantThree;
        public event EventHandler<SetValue> krantFive;
        private int value;

        public int Value 
        { 
            get => value; 
            set
            {
                this.value = value;
                if(this.value % 3 == 0)
                    krantThree?.Invoke(this, new SetValue(value));
                if(this.value % 5 == 0)
                    krantFive?.Invoke(this, new SetValue(value));
            } 
        }

        public static Count operator ++(Count c)
        {
            c.Value ++;
            return c;
        }
    }
}
