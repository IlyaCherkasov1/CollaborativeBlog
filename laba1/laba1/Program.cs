using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Ilya";
            Console.WriteLine("My name is " + name);// simple
            int god = 2002;
            Console.WriteLine("I was born in {0}", god);//форматированный
            byte age = 17;
            Console.WriteLine($"My age is {age} ");// интепалируемый
            string college = "MKP";
            string group = "P-1708";
            Console.WriteLine("I study " + college + " in group " + group);
            string film = "Ilusion of deception";
            string actor = "Jesse Elsenberd";
            Console.WriteLine("My favoarit film is {0} with cool actor {1}", film, actor);
            string breakfast = "potato";
            string lunch = "buckwheat";
            string dinner = "salad";
            Console.WriteLine($"For breakfast I like more {breakfast}, for lunch {lunch}, for dinner {dinner} ");
            Console.WriteLine("What is your mood?");
            string mood = Console.ReadLine();
            Console.WriteLine("I am also in a {0} mood", mood);
            Console.WriteLine("What is tha name of your favorite animal?");//
            string NameAnimal = Console.ReadLine();
            Console.WriteLine("name of my favorite pet is "+NameAnimal);
            Console.WriteLine("What is  your favorite subject?");//
            string subject = Console.ReadLine();
            Console.WriteLine("My favorite subject is "+subject);





        }
    }
}
