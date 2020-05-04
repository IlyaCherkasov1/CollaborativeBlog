using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUP10
{
    public class ListEventArgs:EventArgs
    {
        List<int> ls;
        bool confirm;

        public ListEventArgs(List<int> ls, bool confirm)
        {
            this.Ls = ls;
            this.Confirm = confirm;
        }

        public List<int> Ls { get => ls; set => ls = value; }
        public bool Confirm { get => confirm; set => confirm = value; }
    }
}
