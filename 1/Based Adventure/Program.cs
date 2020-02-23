using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Based_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 6;
            float b = a / 0; // попытка деления на ноль
            Console.WriteLine(b); 


            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Title = "Заголовок";
        }
 
        public static void Beep() //Гудок. Перегрузки (частота, длительность)
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Console.Beep(500, 1000);
            }
        }

        public static void KeyPress1()// выполняет цикл пока не нажата клавиша x
        {
            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();
                Console.WriteLine(keyinfo.Key + " was pressed");
            }
            while (keyinfo.Key != ConsoleKey.X);
        }

        
    }
}
