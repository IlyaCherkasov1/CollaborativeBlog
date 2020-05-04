using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_19._2
{
    class Test
    {
        double progress;
        double sum;

        public Test()
        {
            Progress = 0;
            Sum = 0;
        }

        public Test(double progress, int sum)
        {

        }

        public double Progress { get => progress; set => progress = value; }
        public double Sum { get => sum; set => sum = value; }
    }
}
