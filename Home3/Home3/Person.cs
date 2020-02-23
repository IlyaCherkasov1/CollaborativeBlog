using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home3
{
    class Person
    {
        public event Action GoToSleep;
        public event EventHandler GoToWork;
        public string Name { get; set; }
        public void TakeTime(DateTime now)
        {
            if (now.Hour <= 8)
            {
                GoToSleep?.Invoke();
            }
            else
            {
                GoToWork?.Invoke(this, null);
            }
        }
    }
}
