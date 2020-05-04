using classLibraryUP12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP12
{
    public class CollectionType<T>
    {
        List<Matrix<T>> myList;

        public CollectionType(List<Matrix<T>> myList)
        {
            this.myList = myList;
        }

        public int CountCollectionEqual(int n)
        {
            int count = 0;
            for (int i = 0; i < myList.Count; i++)
            {
                if(myList[i].MyMatrix.GetLength(0) == n)
                {
                    count++;
                }
            }
            return count;
        }

        public int MinCollection()
        {
            int numberOfCollection = 0;
            for (int i = 0; i < myList.Count-1; i++)
            {
                if (myList[i].MyMatrix.Length > myList[i + 1].MyMatrix.Length)
                {
                    numberOfCollection = i+1;
                }
            }
            return numberOfCollection;
        }


        public int MaxCollection()
        {
            int numberOfCollection = 0;
            for (int i = 0; i < myList.Count - 1; i++)
            {
                if (myList[i].MyMatrix.Length < myList[i + 1].MyMatrix.Length)
                {
                    numberOfCollection = i + 1;
                }
            }
            return numberOfCollection;
        }

        public void Sort()
        {
            
        }
    }
}
