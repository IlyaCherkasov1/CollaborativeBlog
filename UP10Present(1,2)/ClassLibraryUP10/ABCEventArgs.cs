using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUP10
{
    public class ABCEventArgs: EventArgs
    {
        ABC abc;
        bool confirm;

        public ABCEventArgs(ABC abc, bool confirm)
        {
            this.Abc = abc;
            this.Confirm = confirm;
        }

        public ABC Abc { get => abc; set => abc = value; }
        public bool Confirm { get => confirm; set => confirm = value; }
    }
}
