using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Laba20_WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.BackColor = Color.Brown;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkedListBox1.Cursor = Cursors.Hand;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkedListBox1.ForeColor = Color.Yellow;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkedListBox1.UseWaitCursor = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkedListBox1.Size = new Size(250, 100);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            checkedListBox1.Location = new Point(250, 300);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            checkedListBox1.MaximumSize = new Size(200,50);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            checkedListBox1.MinimumSize = new Size(20, 20);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            checkedListBox1.Enabled = !checkedListBox1.Enabled;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            checkedListBox1.Visible = !checkedListBox1.Visible;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            checkedListBox1.Font = new Font("Microsoft Sans Serif", Font.Size);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(13, false);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            checkedListBox1.Font = new Font("Microsoft Sans Serif", Font.Size,FontStyle.Bold);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            checkedListBox1.Dock = DockStyle.Top;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            checkedListBox1.BorderStyle = BorderStyle.FixedSingle;
        }

   
    }
}
