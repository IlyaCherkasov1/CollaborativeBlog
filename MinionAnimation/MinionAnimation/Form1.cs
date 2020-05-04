using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinionAnimation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void PrintMinoin(int x, int y, bool isSmile)
        {

            Rectangle hand = new Rectangle(x - 25, y + 140, 150, 40);
            g.FillRectangle(Brushes.Black, hand);

            Rectangle head = new Rectangle(x, y, 100, 100);
            g.FillEllipse(Brushes.Yellow, head);

            Rectangle body = new Rectangle(x, y + 50, 100, 120);
            g.FillRectangle(Brushes.Yellow, body);

            Rectangle mask = new Rectangle(x, y + 40, 100, 20);
            g.FillRectangle(Brushes.Black, mask);

            Rectangle monocle = new Rectangle(x + 35, y + 35, 30, 30);
            Pen pMonocle = new Pen(Color.Gray, 10);
            g.FillEllipse(Brushes.White, monocle);
            g.DrawEllipse(pMonocle, monocle);
            pMonocle.Dispose();

            Rectangle eye = new Rectangle(x + 45, y + 45, 10, 10);
            g.FillEllipse(Brushes.Black, eye);

            int offset = isStep ? 0 : 10;
            Rectangle footLeft = new Rectangle(x + offset, y + 170, 40, 50);
            g.FillRectangle(Brushes.Black, footLeft);

            Rectangle footRight = new Rectangle(x + 55 + offset, y + 170, 40, 50);
            g.FillRectangle(Brushes.Black, footRight);
            isStep = !isStep;
            Rectangle pantsFloar = new Rectangle(x + 15, y + 150, 70, 40);
            g.FillRectangle(Brushes.Blue, pantsFloar);
            Rectangle pantsTop = new Rectangle(x + 20, y + 110, 60, 40);
            g.FillRectangle(Brushes.Blue, pantsTop);
            Pen pSuspenders = new Pen(Color.Blue, 10);
            g.DrawLine(pSuspenders, x, y + 85, x + 30, y + 115);
            g.DrawLine(pSuspenders, x + 100, y + 85, x + 70, y + 115);
            pSuspenders.Dispose();

            Rectangle smile = new Rectangle(x + 25, y + 80, 50, 20);
            Pen pSmile = new Pen(Color.Black, 6);
            int start = isSmile ? 0 : 180;

            g.DrawArc(pSmile, smile, start, 180);
            pSmile.Dispose();



        }


        int x = 100, y = 100;
        int speed = 10;
        bool isSmile = true;
        Graphics g;
        bool isStep = false;
        private void AnimationMinion_Load(object sender, EventArgs e)
        {

        }

        private void AnimationMinion_KeyDown(object sender, KeyEventArgs e)
        {
            g = pBox.CreateGraphics();

            if (e.KeyCode == Keys.Left)
            {
                x -= speed;
            }
            if (e.KeyCode == Keys.Right)
            {
                x += speed;
            }
            if (e.KeyCode == Keys.Up)
            {
                y -= speed;
            }
            if (e.KeyCode == Keys.Down)
            {
                y += speed;
            }
            if (e.KeyCode == Keys.Shift)
            {
                isSmile = !isSmile;
            }


            g.Clear(this.BackColor);
            if (e.KeyCode == Keys.Space)
            {

                for (int step = 0; step < 50; step++)
                {
                    g = pBox.CreateGraphics();

                    PrintMinoin(x++,
                                y++,
                                isSmile);
                    Thread.Sleep(10);
                    g.Clear(this.BackColor);
                }



            }


            PrintMinoin(x, y, isSmile);

        }
    }

}

