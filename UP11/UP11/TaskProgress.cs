using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP11
{
   public class TaskProgress
    {
        double progress;
        double sum;
        int[] mas;

        public TaskProgress()
        {
            this.Progress = 0;
            this.Sum = 0;
        }

        public TaskProgress(int[] mas)
        {
            this.Progress = 0;
            this.Sum = 0;
            this.Mas = mas;
        }

        public double Progress { get => progress; set => progress = value; }
        public double Sum { get => sum; set => sum = value; }
        public int[] Mas { get => mas; set => mas = value; }
    }
}
