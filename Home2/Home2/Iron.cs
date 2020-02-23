using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home2
{
    class Iron : ISwitchetable
    {
        private bool on;
        private bool off;
        public Iron()
        {
            on = false;
            off = true;
        }

        public bool On
        {
            get { return on; }
            set
            {
                on = value;
            }
        }

        public bool Off
        {
            get { return off; }
            set
            {
                off = false;
            }
        }
        public bool On1()
        {
            if (on == true)
            {
                throw new IsOnException();
            }
            if (on == false)
            {
                on = true;
                off = false;
                return true;
            }

            return false;
        }
        public bool Off1()
        {
            if (off == true)
            {
                throw new IsOnException();
            }
            if (off == false)
            {
                off = true;
                on = false;
                return false;
            }

            return true;
        }

        public bool IsOn()
        {
            if (on)
                return true;
            if (on == false)
                return false;
            return false;
        }
    }
}
