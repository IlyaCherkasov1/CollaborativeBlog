using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNumbers1()
        {
            int[] arr = new int[] { 1, 3, 23, 13, 9, 11, 12, 7 };
            int[] arr1 = new int[] { 3, 9, 12, 1, 13, 7, 23, 11 };
            IComparer<int> cmp = new numbers();
            Array.Sort(arr, cmp);
            CollectionAssert.AreEqual(arr, arr1);
        }

        [TestMethod]
        public void TestNumbers2()
        {
            int[] arr = new int[] { 1, 3, 23, 13, 9, 11, 12, 7 };
            int[] arr1 = new int[] { 3, 9, 12, 1, 13, 7, 23, 11 };
            numbers nb = new numbers();
            IComparer<int> cmp = new numbers();
            Array.Sort(arr, cmp);
            CollectionAssert.AreEquivalent(arr, arr1);
        }


        [TestMethod]
        public void TestPointArray1()
        {
            PointArray array = new PointArray { new Point(-2, -1), new Point(-3, -2), new Point(-3, 2), new Point(3, 2), new Point(2, 3), new Point(4, 5) };
            PointArray pa = new PointArray();
            pa.Add(new Point(-3, 2));
            pa.Add(new Point(-3, -2));
            pa.Add(new Point(3, 2));
            pa.Add(new Point(-2, -1));
            pa.Add(new Point(2, 3));
            pa.Add(new Point(4, 5));
            Array.Sort(pa.mas);
            Assert.AreEqual(array, pa);
        }


    }
}
