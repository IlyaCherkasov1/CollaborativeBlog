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
    public partial class Form3 : Form
    {
        public delegate void InvokeDelegate(TaskProgress s);
        public Form3()
        {
            InitializeComponent();
        }

        public void InvokeMethodSin(TaskProgress s)
        {
            richTextBox3.AppendText($"Sin: {s.Sum}, Progress: {s.Progress}% \n");
        }
        public void InvokeMethodSinAsync(TaskProgress s)
        {
            richTextBox4.AppendText($"Sin: {s.Sum}, Progress: {s.Progress}% \n");
        }


        void AsyncCallback(IAsyncResult result)
        {
            InvokeDelegate invokeDelegate = InvokeMethodSin;
            TaskProgress t = result.AsyncState as TaskProgress;
            invokeDelegate.BeginInvoke(t, null, null);
        }

        double Sin(int value, double delta, TaskProgress t)
        {
            InvokeDelegate invokeDelegate = InvokeMethodSin;
            double radian = value * Math.PI / 180;

            double result = 0;
            double lastresult = 1;
            double a = radian;

            int countOp = TakeIterationOnSin(value, delta);



            for (int i = 0; Math.Abs(result - lastresult) > delta; i++)
            {
                lastresult = result;
                result += a;
                a *= -radian * radian / (2 * (2 * i + 3) * (i + 1));
                t.Sum = result;
                t.Progress += (100 / (countOp));
                invokeDelegate.BeginInvoke(t, null, null);
                Thread.Sleep(500);

            }
            t.Progress = 100;
            return result;
        }

        async void SinAsync(int value, double delta, TaskProgress t)
        {
            InvokeDelegate invokeDelegate = InvokeMethodSinAsync;
            double radian = value * Math.PI / 180;

            double result = 0;
            double lastresult = double.NegativeInfinity;
            double a = radian;

            int countOp = TakeIterationOnSin(value, delta);

            for (int i = 0; Math.Abs(result - lastresult) > delta; i++)
            {
                lastresult = result;
                result += a;
                a *= -radian * radian / (2 * (2 * i + 3) * (i + 1));
                t.Sum = result;
                t.Progress += (100 / (countOp));
                invokeDelegate.BeginInvoke(t, null, null);
                await Task.Delay(300);
            }
            t.Progress = 100;
        }

        int TakeIterationOnSin(int value, double delta)
        {
            double radian = value * Math.PI / 180;
            double result = 0;
            double lastresult = double.NegativeInfinity;
            double a = radian;
            int count = 0;

            for (int i = 0; Math.Abs(result - lastresult) > delta; i++)
            {
                count++;
                lastresult = result;
                result += a;
                a *= -radian * radian / (2 * (2 * i + 3) * (i + 1));
            }
            return count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Func<int, double, TaskProgress, double> F = Sin;
            TaskProgress taskProgress = new TaskProgress();
            IAsyncResult result = F.BeginInvoke(Convert.ToInt32(textBox1.Text),
            Convert.ToDouble(textBox2.Text), taskProgress, AsyncCallback, taskProgress);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TaskProgress taskProgress1 = new TaskProgress();
            SinAsync(Convert.ToInt32(textBox3.Text), Convert.ToDouble(textBox4.Text), taskProgress1);
        }

  
    }
}
