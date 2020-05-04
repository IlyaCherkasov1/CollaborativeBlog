using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba22_menu
{
    public partial class Form1 : Form
    {
        ToolStripLabel dateLabel1;
        ToolStripLabel timeLabel1;
        ToolStripLabel FIO;
        Timer timer1;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;

 
            dateLabel1 = new ToolStripLabel();
            timeLabel1 = new ToolStripLabel();
            FIO = new ToolStripLabel();
            FIO.Text = "Черкасов Илья";

            statusStrip1.Items.Add(FIO);
            statusStrip1.Items.Add(dateLabel1);
            statusStrip1.Items.Add(timeLabel1);
         


            timer1 = new Timer() { Interval = 1000 };
            timer1.Tick += timer_Tick;
            timer1.Start(); 
        }

        void timer_Tick(object sender, EventArgs e)
        {
            dateLabel1.Text = DateTime.Now.ToLongDateString();
            timeLabel1.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (textBox1.Text == "admin" && textBox2.Text == "admin")
           {
                text f2 = new text();
                f2.ShowDialog(); 
           }
           else
           {
                MessageBox.Show("Логин или пароль введены неправильно");
           }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && e.Control)
            {
                Autom f3 = new Autom();
                f3.ShowDialog();
            }
        }

  
    }
}
