using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUP14
{
    public class TwoClickEventArgs
    {
        Point startpoint;
        Point finishpoint;

        public TwoClickEventArgs(Point startpoint, Point finishpoint)
        {
            this.startpoint = startpoint;
            this.finishpoint = finishpoint;
        }

        public TwoClickEventArgs(Point startpoint, Point finishpoint, Graphics Canvas) : this(startpoint, finishpoint)
        {
            this.Canvas = Canvas;
        }

        public Point Startpoint { get => startpoint; }
        public Point Finishpoint { get => finishpoint; }

        public Graphics Canvas { get; private set; }
    }
}
