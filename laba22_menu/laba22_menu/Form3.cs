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
    public partial class Autom : Form
    {
        int sum = 0;
        List<string> order = new List<string>();
        public Autom()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
           int selectIndex = comboBox1.SelectedIndex;
           int productNumber = int.Parse(textBox1.Text);
            switch (selectIndex) {
                case 0:
                    sum += 5 * productNumber;
                    label5.Text = sum.ToString();
                    order.Add(comboBox1.Items[0].ToString());
                    break;
                case 1:
                    sum += 10 * productNumber;
                    label5.Text = sum.ToString();
                    order.Add(comboBox1.Items[1].ToString());
                    break;
                case 2:
                    sum += 15 * productNumber;
                    label5.Text = sum.ToString();
                    order.Add(comboBox1.Items[2].ToString());
                    break;
                case 3:
                    sum += 20 * productNumber;
                    label5.Text = sum.ToString();
                    order.Add(comboBox1.Items[3].ToString());
                    break;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string orders = "";
            foreach (var i  in order)
            {
                orders += "\n" + i;
            }
            int discount = (sum - sum * 5 / 100);
            order.Clear();
            richTextBox1.Text = DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString() + "\n"
            + "Закак:" + orders + "\n" +
            "Общая сумма " + sum.ToString() + "\n" +
            "Сумма со скидкой = " + discount.ToString() + "\n";
        }

        private void отчиститьПолеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void сохранитьТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string fileName = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(fileName,richTextBox1.Text);
            MessageBox.Show("Файл успешно сохранен");
        }
    }
}
