using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string writePath = @"D:\TestFolder\hta.txt";
        public Form1()
        {
            InitializeComponent();
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") || (textBox2.Text != ""))
                {
                dataGridView1.Visible = true;
                dataGridView1.RowCount = Convert.ToInt32(textBox1.Text);
                dataGridView1.ColumnCount = Convert.ToInt32(textBox2.Text);
            
            }
            else
           
                MessageBox.Show("Матрицы заданны неправильно для заданной операции");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i=0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j=0; j<dataGridView1.RowCount; j++)
                {
                    dataGridView1[i, j].Value = rnd.Next(-50,50);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < dataGridView2.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView2.RowCount; j++)
                {
                    dataGridView2[i, j].Value = rnd.Next(-50, 50);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox3.Text != "") || (textBox4.Text != ""))
            {
                dataGridView2.Visible = true;
                dataGridView2.RowCount = Convert.ToInt32(textBox3.Text);
                dataGridView2.ColumnCount = Convert.ToInt32(textBox4.Text);

            }
            else

                MessageBox.Show("Матрицы заданны неправильно для заданной операции");
            
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.RowCount != dataGridView2.RowCount) || (dataGridView1.ColumnCount != dataGridView2.ColumnCount))
            {
                MessageBox.Show("Матрицы заданны неправильно для заданной операции");
            }
            else
            {
                int x = 0;
                int y = 0;
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {

                    sw.WriteLine("Вычитание:");
                }


                for (int i = 0; i < dataGridView2.ColumnCount; i++)
                {

                    for (int j = 0; j < dataGridView2.RowCount; j++)
                    {
                       
                     dataGridView3[i, j].Value =Convert.ToInt32(dataGridView1[i, j].Value) - Convert.ToInt32(dataGridView2[i, j].Value);



                        using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                        {
                           
                            sw.WriteAsync(Convert.ToString( dataGridView3[i,j].Value) + " ");
                        }


                    }
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
        

                int x = 0;
                int y = 0;
                int z = 0;
                int sum = 0;


                for (int i = 0; i < dataGridView2.RowCount; i++)
                {

                    for (int j = 0; j < dataGridView2.RowCount; j++)
                    {
                        sum = 0;
                        for (int k = 0; k < dataGridView2.RowCount; k++)
                            x = Convert.ToInt32(dataGridView1[i, j].Value);
                        y = Convert.ToInt32(dataGridView2[i, j].Value);
                        sum = sum + x + y;
                        dataGridView3[i, j].Value = sum;
                    }
                }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.RowCount != dataGridView2.RowCount) || (dataGridView1.ColumnCount != dataGridView2.ColumnCount))
            {
                MessageBox.Show("Матрицы заданны неправильно для заданной операции");
            }
            else
            {
                int bufer = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {

                        bufer = Convert.ToInt32(dataGridView1[i, j].Value);
                        dataGridView3[j, i].Value = bufer;
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i, j;
            double det = 0;
            int sum = 0;
            int kol = 0;
            int bufer = 0;
        
                for (i = 0; i < dataGridView1.RowCount; i++)
                {
                sum = 0;
                    for (j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                    bufer = Convert.ToInt32(dataGridView1[i, j].Value);
                    sum += bufer ;
                    kol++;
                    det = det + sum;
                    }
                 
                }
            if (det < 0)
            {
                det = -det;
            }
        //    if (i != k)
        //        //то меняем знак определителя
        //        det = -det;
        //    //умножаем det на элемент a[i][i]
        //    det *= a[i][i];
        //    //идем по строке от i+1 до конца
        //    for (int j = i + 1; j < n; ++j)
        //        //каждый элемент делим на a[i][i]
        //        a[i][j] /= a[i][i];
        //    //идем по столбцам
        //    for (int j = 0; j < n; ++j)
        //        //проверяем
        //        if ((j != i) && (Math.Abs(a[j][i]) > EPS))
        //            //если да, то идем по k от i+1
        //            for (k = i + 1; k < n; ++k)
        //                a[j][k] -= a[i][k] * a[j][i];
        //}

        det = Math.Round(det / kol);
            MessageBox.Show("Детерменант равен:"+ Convert.ToString(det));
            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
            {
               sw.WriteLineAsync("Детерменант равен:" + Convert.ToString(det));
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") || (textBox2.Text != ""))
            {
                dataGridView3.RowCount = Convert.ToInt32(textBox1.Text);
                dataGridView3.ColumnCount = Convert.ToInt32(textBox2.Text);

            }
            else

                MessageBox.Show("Матрицы заданны неправильно для заданной операции");
          
        }

     
    }
}
