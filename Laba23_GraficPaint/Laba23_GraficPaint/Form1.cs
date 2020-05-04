using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.CodeDom.Compiler;

namespace Laba23_GraficPaint
{
    public partial class Form1 : Form
    {
        Pen pen = new Pen(Color.Red,5);
        Color penPouring = Color.White;
        SolidBrush brush = new SolidBrush(Color.White);
        bool isFill = false;
        string inputText1;
        bool minusHendler = false;

        DrawForm drawForm = new DrawForm();

        public Form1()
        {
            InitializeComponent();

        }

       
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            drawForm.MdiParent = this;
            drawForm.Show();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveMdiChild?.Close();
        }

        private void закрытьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteOneclickEvent(DrawBrokenLine);
        }

        private void квадратToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckCountAndAddHandler(DrawRectangle);
        }

        private void кругToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckCountAndAddHandler(DrawCircle);
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

        private void DrawRectangle(object sender, TwoClickEventArgs e)
        {

            Rectangle rect = GetRectangle(e);
            if (pen != null)
            {
                e.Canvas.FillRectangle(brush, rect);
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

        private void CheckCountAndAddHandler(EventHandler<TwoClickEventArgs> handler)
        {
            if (MdiChildren.Count() > 0 )
                (ActiveMdiChild as DrawForm).TwoClick += handler;
            else
                MessageBox.Show("Не создана форма для рисования!");
        }

    
        private void CheckOneClick(EventHandler<OneClickEventArgs> handler)
        {
           
            if (MdiChildren.Count() > 0)
            {
                if (minusHendler == false)
                {
                    (ActiveMdiChild as DrawForm).OneClick1 += handler;
                }
            }
            else
                MessageBox.Show("Не создана форма для рисования!");
        }

     

        private void DrawCircle(object sender, TwoClickEventArgs e)
        {

            Rectangle rect = GetRectangle(e);
            if (pen != null)
            {
                //if (isFill)
                e.Canvas.FillEllipse(brush, rect);
                e.Canvas.DrawEllipse(pen, rect);
            }

            else
                MessageBox.Show("Укажите карандаш!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void линияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckCountAndAddHandler(DrawLine);
        }

        private void DrawLine(object sender, TwoClickEventArgs e)
        {
            if (pen != null)

                e.Canvas.DrawLine(pen, e.Startpoint, e.Finishpoint);
            else
                MessageBox.Show("Укажите карандаш!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void цветЗаливкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                brush = new SolidBrush(cd.Color);
                SetIconКарандаш(cd);

            }
        }

        private void текстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckCountAndAddHandler(DrawText);
        }

        private void DrawText(object sender, TwoClickEventArgs e)
        {
      
            if (pen != null)
            {
                PouringText(e);
                e.Canvas.DrawString(inputText1, new Font("Times New Roman", 30), new SolidBrush(pen.Color), e.Startpoint);
            }
            else
                MessageBox.Show("Укажите карандаш!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void PouringText( TwoClickEventArgs e)
        {
            InputText inputText = new InputText();
            inputText.ShowDialog();
            inputText1 = inputText.TextForDraw;
            Rectangle rect = GetRectangle(e);
            Pen localPen = new Pen(brush.Color, 1);
            e.Canvas.FillRectangle(brush, rect);
            e.Canvas.DrawRectangle(localPen, rect);
        }


        private void поллинияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckOneClick(DrawBrokenLine);

        }

        private void DrawBrokenLine(object sender, OneClickEventArgs e)
        {
           e.Canvas.DrawLine(pen, e.Startpoint, e.Finishpoint);

        }

        private void DeleteOneclickEvent(EventHandler<OneClickEventArgs> handler)
        {
                (ActiveMdiChild as DrawForm).OneClick1 -= handler;
        }

        private void DeleteTwoClickEvent(EventHandler<TwoClickEventArgs> handler)
        {
            (ActiveMdiChild as DrawForm).TwoClick -= handler;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteOneclickEvent(DrawBrokenLine);
        }


        
        private void CopyRegion(object sender, TwoClickEventArgs e)
        {
            Image temp = drawForm.pictureBox1.Image;
            e.Canvas.DrawImage(temp, e.Finishpoint.X + 5, e.Finishpoint.Y + 5,
                new Rectangle(e.Startpoint.X, e.Startpoint.Y, e.Finishpoint.X, e.Finishpoint.Y) ,GraphicsUnit.Pixel);
          
        }

        private void копироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CheckCountAndAddHandler(CopyRegion);
        }

        private void зеркальноОтобразитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckCountAndAddHandler(MirrorReflection);
        }
        
        private void MirrorReflection(object sender, TwoClickEventArgs e)
        {
            drawForm.pictureBox1.Image = new Bitmap(drawForm.pictureBox1.Width, drawForm.pictureBox1.Height);

            Graphics g = Graphics.FromImage(drawForm.pictureBox1.Image);

            int x = e.Startpoint.X, y = e.Startpoint.Y, w = e.Finishpoint.X - e.Startpoint.X, h = e.Finishpoint.Y - e.Startpoint.Y; //координаты прямоугольника исходные
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

        private void поворотНа90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckCountAndAddHandler(FigureRotate);
        }

        private void FigureRotate(object sender, TwoClickEventArgs e)
        {
            inputRotate inputRotate = new inputRotate();
            inputRotate.ShowDialog();
            int degree = inputRotate.Rotate;
            e.Canvas.RotateTransform(degree);
            Image temp = drawForm.pictureBox1.Image;
            e.Canvas.DrawImage(temp,e.Startpoint.X, e.Startpoint.Y,
            new Rectangle(e.Startpoint.X, e.Startpoint.Y, e.Finishpoint.X - 
            e.Startpoint.X, e.Finishpoint.Y - e.Startpoint.Y), GraphicsUnit.Pixel);
        }

    }
}
