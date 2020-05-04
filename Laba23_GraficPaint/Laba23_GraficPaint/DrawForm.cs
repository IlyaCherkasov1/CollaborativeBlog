using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba23_GraficPaint
{
    public partial class DrawForm : Form
    {
        public DrawForm()
        {
            InitializeComponent();
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            for (int i = 0; i< pictureBox1.Width; i++)
            {
                for (int j = 0; j < pictureBox1.Height; j++)
                {
                    bitmap.SetPixel(i, j, Color.White);
                }
            }
            pictureBox1.Image = bitmap;
        }

        private EventHandler<TwoClickEventArgs> fTwoClick;

        public event EventHandler<TwoClickEventArgs> TwoClick
        {
            add
            {
                fTwoClick = null;
                fTwoClick += value;
            }

            remove
            {
                fTwoClick -= value;
            }
        }

        private EventHandler<OneClickEventArgs> fOneClick;
        public event EventHandler<OneClickEventArgs> OneClick1
        {
            add
            {
                fOneClick = null;
                fOneClick += value;
            }
            remove
            {
                fOneClick -= value;
            }
        }

        private Point StartClick;
        Point FinishClick;
        private Point StartClick1;
        Point FinishClick1;
        Point FinishClick2;

        private bool isFirstClick;
        private bool oneTime = true;


        private void DrawForm_Activated(object sender, EventArgs e)
        {
            isFirstClick = false;
        }

        private void pictureBox1_MouseClick_1(object sender, MouseEventArgs e)
        
        {
            if (!isFirstClick)
            {
                StartClick = e.Location;
                if (oneTime)
                {
                    StartClick1 = e.Location;
                    oneTime = false;
                }
                else
                {
                    FinishClick2 = e.Location;
                    fOneClick?.Invoke(this, new OneClickEventArgs(StartClick1, FinishClick2, Graphics.FromImage(pictureBox1.Image)));
                    StartClick1 = FinishClick2;
                }

                isFirstClick = !isFirstClick;
                pictureBox1.Invalidate();
            }
            else
            {
                isFirstClick = !isFirstClick;
                FinishClick = e.Location;
                FinishClick1 = e.Location;
                fTwoClick?.Invoke(this, new TwoClickEventArgs(StartClick, FinishClick, Graphics.FromImage(pictureBox1.Image)));
                fOneClick?.Invoke(this, new OneClickEventArgs(StartClick1, FinishClick1, Graphics.FromImage(pictureBox1.Image)));
                StartClick1 = FinishClick1;
                pictureBox1.Invalidate();
            }
        }
    }
}
