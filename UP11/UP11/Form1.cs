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

namespace UP11
{
    public partial class Form1 : Form
    {

        Ball[] bl = new Ball[10];//массив пустых ссылок типа Ball
 
        
        public Form1()
        {
            InitializeComponent();
            Random rd = new Random();
            for (int j = 0; j < bl.Length; j++)
            {
                //создаем потоковые объекты
                bl[j] = new Ball(j, j * 10, 10, 10, j + 1, j + 1, (j+1).ToString());
                //подписываемся на событие
                bl[j].dl = this.Invalidate;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int j = 0; j < bl.Length; j++)
            {
                bl[j].Live = false;// Уничтожаем потоки
            }

        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            for (int j = 0; j < bl.Length; j++)
            {
                bl[j].DrawBall(e.Graphics);//рисуем
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int j = 0; j < bl.Length; j++)
            {
                bl[j].Live = false;//уничтожаем потоки
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ballNumber = int.Parse(textBox1.Text);
            bl[ballNumber-1].Dx = -bl[ballNumber-1].Dx;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ballNumber = int.Parse(textBox1.Text);
            bl[ballNumber - 1].Dx = 0;
            bl[ballNumber - 1].Dy = 0;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.Location.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();   
        }
    }
}

    

