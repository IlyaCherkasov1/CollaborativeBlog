using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUP15
{
    interface IUsbBus
    {
         string  Addresing { get; set; }
         string Konfiguradtion { get; set; }
         bool RemoveWakeUp { get; set; }
    }
}
