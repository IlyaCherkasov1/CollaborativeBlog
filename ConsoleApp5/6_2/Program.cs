using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix();
            Matrix m2 = new Matrix(2,2);
     
        

            Console.WriteLine("m1=");
            m1.Create();
            m1.Show();

            Console.WriteLine("m2=");
            m2.Create();
            m2.Show();

            Console.WriteLine("Матрицы равны " + m1.Equals(m2)); 
            Console.WriteLine("Матрица квадратная " + m1.Square());
            Console.WriteLine("Матрица нулевая " + m1.IsZero());
            Console.WriteLine("Матрица единичная " + m1.Single());
            Console.WriteLine("Матрица диагональная " + m1.Diagonal());
            Console.WriteLine("Матрица симметричная " + m1.Symmetrical());
            Console.WriteLine("Верхняя треугольная " + m1.VTreangular());
            Console.WriteLine("Нижняя треугольная " + m1.NTreangular());
            Console.WriteLine("Ввведите индексы массива");
            int i =Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Массив по заданным индексам = "+m1[i,j]);
           
           
            Console.ReadKey();
           
        }
    }
}
