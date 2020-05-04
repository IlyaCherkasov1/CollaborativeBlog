using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba25_Pharmacy
{
    public partial class AddForm : Form
    {
        int table = 0;
        public AddForm()
        {
            InitializeComponent();
            HideElements();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            try
            {
                switch (table)
                {

                    case 0:
                        {
                        DataRow nRow = main.pharmacyDataSet.Tables[0].NewRow();
                        nRow[0] = textBox1.Text;
                        nRow[1] = Int32.Parse(textBox2.Text);
                        nRow[2] = Convert.ToDateTime(textBox3.Text);
                        nRow[3] = Int32.Parse(textBox4.Text);
                        main.pharmacyDataSet.Tables[0].Rows.Add(nRow);
                        break;
                      
                        }
                    case 1:
                        {
                            DataRow nRow = main.pharmacyDataSet.Tables[1].NewRow();
                            nRow[0] = textBox1.Text;
                            nRow[1] = Int32.Parse(textBox2.Text);
                            nRow[2] = Convert.ToInt32(textBox3.Text);
                            nRow[3] = Convert.ToInt32(textBox4.Text);
                            nRow[4] = Convert.ToInt32(textBox5.Text);
                            nRow[5] = textBox6.Text;
                            main.pharmacyDataSet.Tables[1].Rows.Add(nRow);
                            break;
                        }
                    case 2:
                        {
                        DataRow nRow = main.pharmacyDataSet.Tables[2].NewRow();
                        nRow[0] = textBox1.Text;
                        nRow[1] = textBox2.Text;
                        nRow[2] = textBox3.Text;
                        main.pharmacyDataSet.Tables[2].Rows.Add(nRow);
                        break;
                    }
                }
           }
            catch (Exception)
            {
                MessageBox.Show("Uncorrect values");
            }
            Close();
        }

        private void medicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideElements();
            WrileNameLabels(0);
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideElements();
            WrileNameLabels(1);
        }

        private void warhouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideElements();
            WrileNameLabels(2);
        }

        private void HideElements()
        {
            TextBox[] textBoxes = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5,textBox6 };
            Label[] labels = new Label[] { label2, label3, label4, label5,label6,label7 };
            for (int i = 0; i < labels.Length; i++)
            {
                textBoxes[i].Visible = false;
                labels[i].Visible = false;
            }
        }

        private void WrileNameLabels(int index)
        {
            Form1 main = this.Owner as Form1;
            TextBox[] textBoxes = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5,textBox6 };
            Label[] labels = new Label[] { label2, label3, label4, label5, label6,label7 };
            for (int i = 0; i < main.pharmacyDataSet.Tables[index].Columns.Count; i++)
            {
                labels[i].Visible = true;
                textBoxes[i].Visible = true;
                labels[i].Text = main.pharmacyDataSet.Tables[index].Columns[i].ToString();
            }
            table = index;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    
    }
}
