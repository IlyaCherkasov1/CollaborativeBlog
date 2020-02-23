using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
   public class Counter
    {
        private int threshold;
        private int total;

        public Counter(int passedThreshold)
        {
            threshold = passedThreshold;
        }

        public void Add(int x)
        {
            total += x;
            if (total >= threshold)
            {
                Counter args = new Counter(4);
                args.total++;
                OnThresholdReached(args);
            }
        }

        public virtual void OnThresholdReached(Counter e)
        {
            EventHandler<Counter> handler = cn;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler<Counter> cn;
    }
}
