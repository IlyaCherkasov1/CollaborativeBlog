using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк матрицы");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов матрицы");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Заполните матрицу");
            DoubleMatrix matrix = new DoubleMatrix(n, m);
            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.cols; j++)
                {
                    Console.Write("Введите элемент [{0},{1}] : ", i, j);
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Матрица :");
            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.cols; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }

            matrix.Method(); //нулевая или не нулевая

            if (matrix.Method1() == false) // проверка на семмитричность
            {
                Console.WriteLine("Матрица не симметричная");
            }
            else Console.WriteLine("Матрица симметричная");

            matrix.Method2();  // Проверка квадратная

            if (matrix.Method3())  // проверка на единичность
            {
                Console.WriteLine("Матрица единичная");
            }
            else Console.WriteLine("Матрица не единичная");

            if (matrix.Method4() == true)   //Проверка на диагональность
            {
                Console.WriteLine("Матрица диагональная");
            }
            else Console.WriteLine("Матрица не диагональная");

            if (matrix.Method5())
            {
                Console.WriteLine("Матрица верхняя треугольная ");
            }
            else Console.WriteLine("Матрица не верхняя треугольная ");

            if (matrix.Method6())
            {
                Console.WriteLine("Матрица нижняя треугольная ");
            }
            else Console.WriteLine("Матрица не нижняя треугольная ");
            Console.WriteLine(matrix[0, 0]); //доступ к элементу по индексам
            Console.ReadKey();
        }
    }
  }

