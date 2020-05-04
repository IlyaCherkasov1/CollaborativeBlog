using System.Drawing;

namespace Laba23_GraficPaint
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