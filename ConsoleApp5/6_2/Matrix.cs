using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2
{
    class Matrix
    {
        double[,] matrix;
       private int lengthx, lengthy;
       private bool a = true;
    

        public bool Diagonal()
        {
            int count = 0; ;
            for (int i = 0; i < lengthx; i++)
            {
                for (int j = 0; j < lengthy; j++)
                {

                    if (i == j)
                    {
                        count++;
                    }

                    if (matrix[i, j] != 0 && i != j)
                    {
                        return false;
                    }

                }
            }

            if (count == lengthx)
                return true;
            return false;


        }

        public bool Single()
        {
            int count = 0; ;
            for (int i = 0; i < lengthx; i++)
            {
                for (int j = 0; j < lengthy; j++)
                {

                    if (matrix[i, j] == 1 && i == j)
                    {
                        count++;
                    }

                    if (matrix[i, j] == 1 && i != j)
                    {
                        return false;
                    }

                }
            }
            
            if (count == lengthx)
                return true;
            return false;

        }


        public bool IsZero()
        {
            int count = 0;

            for (int i = 0; i < lengthx; i++)
            {
                for (int j = 0; j < lengthy; j++)
                {

                    if (matrix[i, j] == 0)
                    {
                        count++;
                    }

                }
            }

            if (count == lengthx * lengthy)
            {
                return true;
            }
            return false;
        }

        public void Create()
        {
            for (int i = 0; i < lengthx; i++)
            {
                for (int j = 0; j < lengthy; j++)
                {
                    Console.Write("Введите элемент [{0},{1}] : ", i, j);
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }


        }

        public bool Square()
        {
            if (lengthx == lengthy)
            {
                return true;
            }
            return false;

        }

        public void Show()
        {
            for (int i = 0; i < lengthx; i++)
            {
                for (int j = 0; j < lengthy; j++)
                {

                    Console.Write("\t" + matrix[i, j]);

                }
                Console.WriteLine();
            }
        }

        public bool Equals(Matrix a)
        {
            int count = 0;
            for (int i = 0; i < lengthx; i++)
            {
                for (int j = 0; j < lengthx; j++)
                {

                    if (a.matrix[i, j] == matrix[i, j])
                    {
                        count++;
                    }

                }
                Console.WriteLine();
            }

            if (count == lengthx * lengthy)
            {
                return true;
            }
            return false;
        }

        public Matrix(int lengthx, int lengthy)
        {
            this.lengthx = lengthx;
            this.lengthy = lengthy;
            matrix = new double[this.lengthx, this.lengthy];
          //  Length = rows * cols;
        }

        public Matrix()
        {
            Console.WriteLine("Введите количество строк матрицы");
            this.lengthx = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов матрицы");
            this.lengthy = int.Parse(Console.ReadLine());
            matrix = new double[this.lengthx, this.lengthy];
        }
        public bool Symmetrical() // проверка на семмитричность
        {
            if (lengthx == lengthy)
            {
                for (int i = 0; i < matrix.GetLength(0); ++i)
                {
                    for (int j = 0; j < matrix.GetLength(1); ++j)
                        if (matrix[i, j] != matrix[j, i])
                        {
                            a = false;
                            break;
                        }
                    if (!a) break;
                }
                return a;
            }
            else return false;
        }

        public bool VTreangular()
        {
            if (lengthx == lengthy)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] != 0 && i > j)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            return false;
        }

        public bool NTreangular()
        {
            if (lengthx == lengthy)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] != 0 && i < j)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            return false;
        }

       public double this[int index1,int index2]
        {   
            get
            {
                return matrix[index1, index2];
            }
          set
            {
                matrix[index1, index2] = value;
            }
       }

    }
}
