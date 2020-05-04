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
    public partial class InputText : Form
    {
        public InputText()
        {
            InitializeComponent();
        }

        public string TextForDraw { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            TextForDraw = textBox1.Text;
            this.Close();
        }
    }
}
