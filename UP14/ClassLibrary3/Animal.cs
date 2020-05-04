using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUP14
{
    [WeightValidation(0)]
     [KindValidation("wild","marine","pet")]
     public  class Animal
     {
        [NameValidation]
        private static Predicate<Animal> ValidateName = x => char.IsUpper(x.Name[0]);
        public Animal(string name, string kindOfAnimal, int weight)
        {
            Name = name;
            KindOfAnimal = kindOfAnimal;
            Weight = weight;
        }

        public string Name { get; set; }
        public string KindOfAnimal { get; set; }
        public int Weight { get; set; }

       
     }
}
