using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    [Serializable]
    public class Car
    {
        public string Model { get; set; }
        public int Years { get; set; }

        public Car()
        {
        }

        public Car(string model, int years)
        {
            this.Model = model;
            this.Years = years;
        }
    }
}
