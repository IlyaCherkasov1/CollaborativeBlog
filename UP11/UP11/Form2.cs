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
    public partial class Form2 : Form
    {
        public delegate void InvokeDelegate(TaskProgress s);
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int[] mas = textBox5.Text.Split(' ').ToArray().Select(int.Parse).ToArray();
            StartTaskFirst((int[])mas.Clone());
            StartTaskSecond((int[])mas.Clone());
        }

        private void StartTaskSecond(int[] mas)
        {
            InvokeDelegate invokeDelegateSecond = InvokeMethodSecond;
            TaskProgress taskProgress = new TaskProgress(mas);
            Task.Run(() =>
            {
                for (int j = 0; j < mas.Length; j++)
                    for (int k = 0; k < mas.Length - 1; k++)
                    {
                        if (mas[k] < mas[k + 1])
                        {
                            int temp = mas[k];
                            mas[k] = mas[k + 1];
                            mas[k + 1] = temp;
                            taskProgress.Mas = mas;
                        }
                        Thread.Sleep(100);
                        invokeDelegateSecond.BeginInvoke(taskProgress, null, null);
                    }
            });
        }

        private void StartTaskFirst(int[] mas)
        {
            InvokeDelegate invokeDelegateFirst = InvokeMethodFirst;
            TaskProgress taskProgress = new TaskProgress(mas);
            Task.Run(() =>
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = 0; j < mas.Length - 1; j++)
                    {
                        if (mas[j] > mas[j + 1])
                        {
                            int z = mas[j];
                            mas[j] = mas[j + 1];
                            mas[j + 1] = z;
                            taskProgress.Mas = mas;
                        }
                        Thread.Sleep(100);
                        invokeDelegateFirst.BeginInvoke(taskProgress, null, null);
                    }
                }
            });
        }

        public void InvokeMethodFirst(TaskProgress s)
        {
            richTextBox1.AppendText(string.Join(" ", s.Mas) + "\n");
        }
        public void InvokeMethodSecond(TaskProgress s)
        {
            richTextBox2.AppendText(string.Join(" ", s.Mas) + "\n");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
