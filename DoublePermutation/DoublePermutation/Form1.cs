using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DoublePermutation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            string s = richTextBox1.Text;
            if (s.Length != 16)
            {
                MessageBox.Show(
               $"длина должна быть 16. фактически {s.Length}",
               "Сообщение",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1
              );
                return;
            }

            dataGridView1.ColumnCount = 4;
            dataGridView1.RowCount = 4;
            int k = 0;
            for (int j = 0; j < dataGridView1.ColumnCount; j++)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1[i, j].Value = s[k];
                    k++;
                }

            }

            dataGridView2.ColumnCount = 4;
            dataGridView2.RowCount = 4;
  
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView2[3,i].Value = dataGridView1[0,i].Value;
                dataGridView2[0, i].Value = dataGridView1[1, i].Value;
                dataGridView2[2, i].Value = dataGridView1[2, i].Value;
                dataGridView2[1, i].Value = dataGridView1[3, i].Value;

            }
            
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    dataGridView1[i, j].Value = dataGridView2[i, j].Value;
                }
            }

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView2[i,2].Value = dataGridView1[ i,0].Value;
                dataGridView2[ i,0].Value = dataGridView1[ i, 1].Value;
                dataGridView2[i,3].Value = dataGridView1[i,2].Value;
                dataGridView2[i,1].Value = dataGridView1[ i,3].Value;

            }

            StringBuilder sb = new StringBuilder();

            for (int j = 0; j < dataGridView2.ColumnCount; j++)
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                   sb.Append(dataGridView2[i,j].Value);
                }
            }
            
            richTextBox2.Text = sb.ToString();

            FileInfo fl = new FileInfo("cipher.txt");
            if (!fl.Exists)
            fl.Create();
            

            using (StreamWriter sw = new StreamWriter("cipher.txt", false, System.Text.Encoding.Default))
            {
                sw.WriteLine(sb.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cipher = "";
            using (StreamReader sr = new StreamReader("cipher.txt", System.Text.Encoding.Default))
            {
               cipher = sr.ReadToEnd();
            }

            richTextBox2.Text = "";
            richTextBox1.Text = cipher;

            dataGridView1.ColumnCount = 4;
            dataGridView1.RowCount = 4;

            int k = 0;
            for (int j = 0; j < dataGridView1.ColumnCount; j++)
            {

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1[i, j].Value = cipher[k];
                    k++;
                }

            }

            dataGridView2.ColumnCount = 4;
            dataGridView2.RowCount = 4;

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView2[i, 0].Value = dataGridView1[i, 2].Value;
                dataGridView2[i, 1].Value = dataGridView1[i, 0].Value;
                dataGridView2[i, 2].Value = dataGridView1[i, 3].Value;
                dataGridView2[i, 3].Value = dataGridView1[i, 1].Value;

            }

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    dataGridView1[i, j].Value = dataGridView2[i, j].Value;
                }
            }

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView2[0, i].Value = dataGridView1[3, i].Value;
                dataGridView2[1, i].Value = dataGridView1[0, i].Value;
                dataGridView2[2, i].Value = dataGridView1[2, i].Value;
                dataGridView2[3, i].Value = dataGridView1[1, i].Value;

            }

            StringBuilder sb = new StringBuilder();

            for (int j = 0; j < dataGridView2.ColumnCount; j++)
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    sb.Append(dataGridView2[i, j].Value);
                }
            }
            richTextBox2.Text = sb.ToString();

        }
    }

}

