using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba24_Hero
{
   
    public partial class Form1 : Form
    {
        public Dictionary<int, int> KeyColors = new Dictionary<int,int>();
        int[,] currentmatr;
        Image image = Image.FromFile("MyHero1.png");

       Image cry1 = Image.FromFile("cry1.png");
        Image cry2 = Image.FromFile("cry2.png");
        Image cry3 = Image.FromFile("cry3.png");
        Image hit1 = Image.FromFile("hit1.png");
       Image hit2 = Image.FromFile("hit2.png");
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;


            currentmatr = GetPixels(image);
            DrawHero(currentmatr);
        }

        private int[,] GetPixels(Image image)
        {
            int[,] matrix = new int[image.Height, image.Width];
            int k = 0;
            for(int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color c = ((Bitmap)image).GetPixel(i, j);
                    if (!KeyColors.ContainsKey(c.ToArgb()))
                    { 
                        KeyColors.Add(c.ToArgb(),k);
                        k++;
                    }
                    matrix[j,i] = KeyColors[c.ToArgb()];
                }
            }
            return matrix;

        }

        bool  IsGoLeft, IsGoRight, IsGoTop, IsGoDown = false;

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            int speed = 5;
            if (IsGoLeft)
                speed--;
            if (IsGoRight)
                speed--;
            if (IsGoTop)
                speed--;
            if (IsGoDown)
                speed--;
            if (IsGoLeft)
            {
                pictureBox1.Left -= speed;
            }
            if (IsGoRight)
            {
                pictureBox1.Left += speed;
            }
            if (IsGoTop)
            {
                pictureBox1.Top -= speed;
            }
            if (IsGoDown)
            {
                pictureBox1.Top += speed;
            }
        }

      

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                IsGoTop = false;
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                IsGoLeft = false;
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                IsGoRight = false;
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                IsGoDown = false;
        }

        int animation = 1;
        private void CryAnimation_Tick(object sender, EventArgs e)
        {
            if (animation == 1)
            {
                currentmatr = GetPixels(cry1);
                DrawHero(currentmatr);
            }
            if (animation == 2)
            {
                currentmatr = GetPixels(cry2);
                DrawHero(currentmatr);
            }
            if (animation == 3)
            {
                currentmatr = GetPixels(cry2);
                DrawHero(currentmatr);
                animation = 0;
            }
            animation++;

        }

        int HitAnimation;
        private void HitTimer_Tick(object sender, EventArgs e)
        {

            if (HitAnimation == 1)
            {
                currentmatr = GetPixels(hit1);
                DrawHero(currentmatr);
            }
            if (HitAnimation == 2)
            {
                currentmatr = GetPixels(hit2);
                DrawHero(currentmatr);
                HitAnimation = 0;

            }

            HitAnimation++;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                IsGoTop = true;
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                IsGoLeft = true;
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                IsGoRight = true;
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                IsGoDown = true;
            if (e.KeyCode == Keys.Space)
                Jump();
        }



        private void Jump()
        {
            double Y0 = pictureBox1.Top;
            double X0 = pictureBox1.Left + (pictureBox1.Width / 2);
            int X = pictureBox1.Left;
            int Y = pictureBox1.Top;
            double r = pictureBox1.Width / 2;
            int startX = X;
            for (double i = 0; i <= r; i += 0.3)
            {
                X = Convert.ToInt32(startX + i);
                Y = Convert.ToInt32(-Math.Sqrt((r * r) - Math.Pow(X - X0, 2)) + Y0);
                pictureBox1.Top = Y;
                pictureBox1.Left = X;
                Thread.Sleep(1);
            }
        }

  
        private void DrawHero(int[,] matrix)
        {
            Bitmap actor = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(actor);
            g.FillRectangle(new SolidBrush(Color.LightGray), 0, 0, pictureBox1.Width, pictureBox1.Width);
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                     Color c;
                    int matrixValue = matrix[i, j];
                    if(matrixValue == 0)
                    {
                        c = Color.LightGray;
                    }
                    else
                    {
                        c = Color.FromArgb(KeyColors.First(x => x.Value == matrixValue).Key);
                    }
                    g.FillRectangle(new SolidBrush(c), j * 2, i * 2, 2, 2);  
                }
           }
            pictureBox1.Image = actor;
        }


    }
}
