using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryUP14;

namespace UP14
{
    public partial class Form1 : Form
    {
        Pen pen = Pens.Black;
        SolidBrush brush;
        bool isFill = false;
        DrawForm drawForm = new DrawForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawForm f = new DrawForm();
            f.MdiParent = this;
            f.Show();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }

        private void закрытьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (MdiChildren.Length > 0)
            {
                MdiChildren[0].Close();
            }
        }

   


        private void DrawRectangle(object sender, TwoClickEventArgs e)
        {

            Rectangle rect = GetRectangle(e);

            if (pen != null)
            {
                if (isFill) e.Canvas.FillRectangle(brush, rect);
                e.Canvas.DrawRectangle(pen, rect);
            }

            else
                MessageBox.Show("Укажите карандаш!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private static Rectangle GetRectangle(TwoClickEventArgs e)
        {
            int x1 = e.Startpoint.X;
            int x2 = e.Finishpoint.X;
            int y1 = e.Startpoint.Y;
            int y2 = e.Finishpoint.Y;
            int minX = x1 < x2 ? x1 : x2;
            int minY = y1 < y2 ? y1 : y2;
            int height = Math.Abs(y1 - y2);
            int width = Math.Abs(x1 - x2);
            Rectangle rect = new Rectangle(minX, minY, width, height);
            return rect;
        }

        private void квадратToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckCountAndAddHandler(DrawRectangle);
        }

        private void CheckCountAndAddHandler(EventHandler<TwoClickEventArgs> handler)
        {
            if (MdiChildren.Count() > 0)
                (ActiveMdiChild as DrawForm).TwoClick += handler;
            else
                MessageBox.Show("Не создана форма для рисования!");
        }



        private void карандашToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                pen = new Pen(cd.Color, 5);
                SetIconКарандаш(cd);

            }
        }

        private void SetIconКарандаш(ColorDialog cd)
        {
            Bitmap bmp = CreateIcon(cd);
            карандашToolStripMenuItem.Image = bmp;
        }

        private static Bitmap CreateIcon(ColorDialog cd)
        {
            Bitmap bmp = new Bitmap(23, 23);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(cd.Color), 0, 0, 23, 23);
            return bmp;
        }

   

        private void зеркальноеОтображениеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CheckCountAndAddHandler(MirrorReflection);
        }

        private void MirrorReflection(object sender, TwoClickEventArgs e)
        {
            drawForm.pictureBox1.Image = new Bitmap(drawForm.pictureBox1.Width, drawForm.pictureBox1.Height);
            Graphics g = Graphics.FromImage(drawForm.pictureBox1.Image);
           
            int x = e.Startpoint.X, y = e.Startpoint.Y, w = e.Finishpoint.X - e.Startpoint.X, h = e.Finishpoint.Y - e.Startpoint.Y; //координаты прямоугольника исходные

            int lineX = 400, lineY = 400; //координаты второй точки линии, проходящей через начало координат

            e.Canvas.DrawLine(Pens.LightBlue, new Point(0, 0), new Point(lineX, lineY)); //линия относительно которой отражаем
            e.Canvas.DrawRectangle(Pens.Black, x, y, w, h); //исходный прямоугольник

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

            e.Canvas.DrawPolygon(Pens.Red, p3);


        }

        private void шумToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CheckCountAndAddHandler(Noise);
        }

        Image temp = null;
        private void Noise(object sender, TwoClickEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                   temp =  Image.FromFile(openFileDialog1.FileName);
                }
                catch (Exception)
                {

                    MessageBox.Show("Открытие не удалось!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            Bitmap bitmapImage = new Bitmap(temp);
            e.Canvas.DrawImage(bitmapImage, 0, 0);
            var image1 = AddGaussianNoise(bitmapImage, 70);
            e.Canvas.DrawImage(image1, 0, 0);
        }

        Bitmap AddGaussianNoise(Bitmap bmp, float noisePower = 20)
        {
            var res = (Bitmap)bmp.Clone();
            var rnd = new Random();

            using (var wr = new ImageWrapper(res))
                foreach (var p in wr)
                {
                    var c = wr[p];
                    var noise = (rnd.NextDouble() + rnd.NextDouble() + rnd.NextDouble() + rnd.NextDouble() - 2) * noisePower;
                    wr.SetPixel(p, c.R + noise, c.G + noise, c.B + noise); //разделить, асинхронность
                }

            return res;
        }

        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    temp.Save("out." + saveFileDialog1.FileName);
                }
                catch (Exception)
                {

                    MessageBox.Show("Сохранения не удалось!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }
    }
}

