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
    public partial class inputRotate : Form
    {
        public int Rotate { get; set; }
        public inputRotate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rotate = Int32.Parse(textBox1.Text);
            this.Close();
        }
    }
}
