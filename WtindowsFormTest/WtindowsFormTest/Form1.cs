using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WtindowsFormTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

   

        private void button2_Click(object sender, EventArgs e)
        {
       // Полагаем что начало координат это левый верхний угол формы.
pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            Graphics g = Graphics.FromImage(pictureBox1.Image);

            int x = 50, y = 150, w = 200, h = 100; //координаты прямоугольника исходные
            int lineX = 400, lineY = 400; //координаты второй точки линии, проходящей через начало координат

            g.DrawLine(Pens.LightBlue, new Point(0, 0), new Point(lineX, lineY)); //линия относительно которой отражаем
            g.DrawRectangle(Pens.Black, x, y, w, h); //исходный прямоугольник

            double rotate = -Math.Atan(lineX / lineY); //угол на который нужно повернуть фигуру, чтобы линия совпала с осью Ox

            //поворачиваем прямоугольник на данный угол
            var p = new PointF[] {
    new PointF((float)(x * Math.Cos(rotate) - y * Math.Sin(rotate)), (float)(x * Math.Sin(rotate) + y * Math.Cos(rotate))),
    new PointF((float)((x + w) * Math.Cos(rotate) - y * Math.Sin(rotate)), (float)((x + w) * Math.Sin(rotate) + y * Math.Cos(rotate))),
    new PointF((float)((x + w) * Math.Cos(rotate) - (y + h) * Math.Sin(rotate)), (float)((x + w) * Math.Sin(rotate) + (y + h) * Math.Cos(rotate))),
    new PointF((float)(x * Math.Cos(rotate) - (y + h) * Math.Sin(rotate)), (float)(x * Math.Sin(rotate) + (y + h) * Math.Cos(rotate))),
};

            //зеркальное отражение относительно oX
            for (int i = 0; i < p.Length; ++i)
            {
                p[i].Y = -p[i].Y;
            }

            //поворачиваем прямоугольник назад на тот же угол
            rotate = -rotate;
            var p3 = new PointF[] {
    new PointF((float)(p[0].X * Math.Cos(rotate) - p[0].Y * Math.Sin(rotate)), (float)(p[0].X * Math.Sin(rotate) + p[0].Y * Math.Cos(rotate))),
    new PointF((float)(p[1].X * Math.Cos(rotate) - p[1].Y * Math.Sin(rotate)), (float)(p[1].X * Math.Sin(rotate) + p[1].Y * Math.Cos(rotate))),
    new PointF((float)(p[2].X * Math.Cos(rotate) - p[2].Y * Math.Sin(rotate)), (float)(p[2].X * Math.Sin(rotate) + p[2].Y * Math.Cos(rotate))),
    new PointF((float)(p[3].X * Math.Cos(rotate) - p[3].Y * Math.Sin(rotate)), (float)(p[3].X * Math.Sin(rotate) + p[3].Y * Math.Cos(rotate))),

};

            //рисуем отражение красным цветом
            g.DrawPolygon(Pens.Red, p3);

        }

    }
}
