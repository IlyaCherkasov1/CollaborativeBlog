using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home5
{
    [Serializable]
    class Laptop
    {


        public Laptop()
        {

        }

        public Laptop(string cPU, string graphicsCard, string model)
        {
            CPU = cPU;
            GraphicsCard = graphicsCard;
            Model = model;
        }

        public string CPU { get; set; }
        public string GraphicsCard {  get; set; }
        public string Model { get; set; }    
    }
}
