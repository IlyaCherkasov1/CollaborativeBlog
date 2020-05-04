using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classLibraryUP12;

namespace classLibraryUP12
{
    public class Matrix<T>:Icount,IComparable
    {
        T[,] matrix;
        public T[,] MyMatrix { get => matrix; set => matrix = value; }
        public delegate void MatrixHandlerf(string message);
        public event MatrixHandlerf Delete;

        public Matrix(T[,] matrix)
        {
            this.matrix = matrix;
           
        }

        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
        {
            T[,]  matrixResult = new T[a.matrix.GetLength(0),b.matrix.GetLength(1)]; 
            for (int i = 0; i < a.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < a.matrix.GetLength(1); j++)
                {
                    if (typeof(T) == typeof(int) || typeof(T) == typeof(double))
                    {
                         matrixResult[i,j] = (dynamic)a.matrix[i, j] + b.matrix[i, j];
                    }    
                }
            }
            return new Matrix<T>( matrixResult);
        }

        public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
        {
            T[,] copyMatrix = new T[a.matrix.GetLength(0), b.matrix.GetLength(1)];
            for (int i = 0; i < a.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < a.matrix.GetLength(1); j++)
                {
                    copyMatrix[i, j] = (dynamic)a.matrix[i, j] + b.matrix[i, j];
                }
            }
            return new Matrix<T>(copyMatrix);
        }

        public static Matrix<T> operator -(Matrix<T> a, int line)
        {
           
            T[,] deleteLineMatrix = new T[a.matrix.GetLength(0), a.matrix.GetLength(1)];

            for (int i = 0; i < a.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < a.matrix.GetLength(1); j++)
                {
                    if (i != line)
                    {
                        deleteLineMatrix[i, j] = (dynamic)a.matrix[i, j];
                    }
                
                }

            }
            a.generateEvent(line);
            return new Matrix<T>(deleteLineMatrix);
        }

        private void generateEvent(int line)
        {
            
            Delete?.Invoke("Произошло удаление строки под индексом "+ line);
        }



        public static bool operator >(Matrix<T> a, Matrix<T> b)
        {
            if (a.matrix.Length > b.matrix.Length)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator <(Matrix<T> a, Matrix<T> b)
        {
            if (a.matrix.Length < b.matrix.Length)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator &(Matrix<T> a, Matrix<T> b)
        {
            if (a.matrix.Length == b.matrix.Length)
            {
                return true;
            }
            else
                return false;
        }

        public T this[int index1,int index2]
        {
        
            get { return matrix[index1, index2];}
        }

     

        public override string ToString()
        {
            
            string str = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                   str += ((matrix[i, j] + " ")).ToString();
                }
                str += "\n";
            }
            return str;
        }

        public int Icount()
        {
            return matrix.Length;
        }

        public int CompareTo(object obj)
        {
            Array.Sort((Icount)matrix);
        }
    }
}


