using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classLibraryUP12;

namespace UP12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
             {
                 { 1,2,3,4 },
                 { 5,6,7,8 },
                 { 9,10,11,12 },
              };
            Matrix<int> matrix1 = new Matrix<int>(matrix);
            Matrix<int> matrix2 = new Matrix<int>(matrix);

            matrix1.Delete += DisplayMessage;
            Console.WriteLine(matrix1+matrix2);//add matrix
            Console.WriteLine(matrix1 * matrix2);// copy matrix
            Console.WriteLine(matrix1 - 1);// delete line
        
            Console.WriteLine(matrix1 > matrix2);
            Console.WriteLine(matrix1 < matrix2);
            Console.WriteLine(matrix1 & matrix2); // проверка соответствия размеров
            Console.WriteLine(matrix1[1,2]);

            List<Matrix<int>> list1 = new List<Matrix<int>>();
            list1.Add(matrix1);
            list1.Add(matrix2);
            CollectionType<int> collectionType = new CollectionType<int>(list1);
            Console.WriteLine(collectionType.CountCollectionEqual(3));

        }

        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
