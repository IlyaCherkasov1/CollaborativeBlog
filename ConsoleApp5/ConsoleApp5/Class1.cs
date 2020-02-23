using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Forest
    {
        public string name;
        public int trees;
        public int age;
        private string biome;
        public int area;

        public int Age
        {
            get { return area; }
            private set { area = value;  }
        }
        public int Area
        {
            get { return area; }
            set { area = value; }
        }
        public string Name        
         { get; set; }
        
        public int Trees
        { get;set;
        }

        public string Biome
        {
            get { return biome; }
            set
            {
                if ((value == "Tropical") || (value == "Temperate") || (value == "Boreal")) { biome = value; }
        else
                { biome = "Unknown"; }
            }
        }
        public int Grow()
        {
            Trees = Trees + 30;
            Age = Age + 1;
            return Trees;

        }
        public int Burn()
        {
          Trees = Trees - 20; 
          Age = Age +1;
          return Trees;
        }

        public Forest(string name, string biome)
        {
            Name = name;
            Biome = biome;
        }
        public Forest(string name) :
         this(name, "Unknown")
        {
            Console.WriteLine("Country property not specified. Value defaulted to 'Unknown'.");
        }
    }
}
