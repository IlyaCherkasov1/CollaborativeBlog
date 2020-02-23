using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryUP2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NumbersInSetTest1()
        {
            NumbersInSet ns = new NumbersInSet();
            CollectionAssert.AreEqual(arr1, ns.WriteAllTheNumbersInTheSourceSet());
        }

        [TestMethod]
        public void NumbersInSetTest2()
        {
            NumbersInSet ns = new NumbersInSet();
            CollectionAssert.AreEquivalent(arr1, ns.WriteAllTheNumbersInTheSourceSet());
        }


        [TestMethod]
        public void ClosestToAverageTest1()
        {
            ClosestToAverage ca = new ClosestToAverage();
            Assert.AreEqual(ca.CalculateClosesToAverage(), (3, 1));       
        }

        [TestMethod]
        public void ClosestToAverageTest2()
        {
            ClosestToAverage ca = new ClosestToAverage();
            Assert.AreNotEqual(ca.CalculateClosesToAverage(), (3, 2));
        }

        [TestMethod]
        public void OddNumbersTest1()
        {
            OddNumbers on = new OddNumbers();
            CollectionAssert.AreEqual(on.IncreaceOddNumbers(), arr2);
        }

        [TestMethod]
        public void OddNumbersTest2()
        {
            OddNumbers on = new OddNumbers();
            CollectionAssert.AreNotEqual(on.IncreaceOddNumbers(), arr1);
        }

        [TestMethod]
        public void MinPathTest1()
        {
            MinPath mp = new MinPath();
            CollectionAssert.AreEqual(ShortPath, mp.FindMinPath());
        }

        [TestMethod]
        public void MinPathTest2()
        {
            MinPath mp = new MinPath();
            CollectionAssert.AreEquivalent(ShortPath, mp.FindMinPath());
        }

        private int[,] arr1 = new int[,]
         {
         {13,13,13,13},
         {14,14,14,14},
         {15,15,15,15},
         {16,16,16,16}
         };

         private int[,] arr2 = new int[,]
         {
         {10,8,2,14},
         {12,8,6,14},
         {12,28,22,14},
         {24,16,16,32}
         };

        private int[] ShortPath = new int[] { 3, 1, 9, 9, 32 };

    }
}
