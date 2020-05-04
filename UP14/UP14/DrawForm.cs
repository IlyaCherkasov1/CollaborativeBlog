using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryUP14;

namespace UP14
{
    public partial class DrawForm : Form
    {
        public DrawForm()
        {
            InitializeComponent();
            Bitmap bmp = new Bitmap(Width, Height);
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    bmp.SetPixel(i, j, Color.White);
                }
            }
            pictureBox1.Image = bmp;

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

        private Point StartClick;
        private bool isFirstClick;



        private void FormChild_Load(object sender, EventArgs e)
        {

        }

        private void FormChild_Activated(object sender, EventArgs e)
        {
            isFirstClick = false;
        }

     

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isFirstClick)
            {
                StartClick = e.Location;
                isFirstClick = !isFirstClick;
            }
            else
            {
                isFirstClick = !isFirstClick;
                Point FinishClick = e.Location;
                fTwoClick?.Invoke(this, new TwoClickEventArgs(StartClick, FinishClick, Graphics.FromImage(pictureBox1.Image)));
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName);
                }
                catch (Exception)
                {

                    MessageBox.Show("Сохранения не удалось!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    pictureBox1.Load(openFileDialog1.FileName);
                }
                catch (Exception)
                {

                    MessageBox.Show("Сохранения не удалось!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
