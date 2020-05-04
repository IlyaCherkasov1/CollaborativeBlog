using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba23_GraficPaint
{
   public class OneClickEventArgs
    {
        Point finishpoint;
        Point startpoint;

        public OneClickEventArgs(Point startpoint, Point finishpoint)
        {
            this.startpoint = startpoint;
            this.finishpoint = finishpoint;
        }

        public OneClickEventArgs(Point startpoint, Point finishpoint, Graphics Canvas)  : this(startpoint, finishpoint)
        {

            this.Canvas = Canvas;
        }

        public Point Startpoint { get => startpoint; }
        public Point Finishpoint { get => finishpoint; }


        public Graphics Canvas { get; private set; }
    }
}
