using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UP1;
namespace TestMyMethods
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFunction1()
        {
            Function fn = new Function();
            Assert.AreEqual(fn.CalsulateFunction(), -55.6848d, 0.01);
        }

        [TestMethod]
        public void TestFunction2()
        {
            Function fn = new Function();
            Assert.AreNotEqual(fn.CalsulateFunction(), -55.1148d, 0.01);
        }

        [TestMethod]
        public void TestMethod1()
        {
            SumPositiveNuber sn = new SumPositiveNuber(3);
            Assert.AreEqual(sn.CalculateSumPositiveNumber(), 1.83, 0.01);
        }

        [TestMethod]
        public void TestMethod2()
        {
            SumPositiveNuber sn = new SumPositiveNuber(3);
            Assert.AreNotEqual(sn.CalculateSumPositiveNumber(), 1.13, 0.01);
        }

        [TestMethod]
        public void TestLargestNumber1()
        {
            LargestNumber ln = new LargestNumber(28);
            Assert.AreEqual(ln.FindLargestNumber(), 3);
        }


        [TestMethod]
        public void TestLargestNumber2()
        {
            LargestNumber ln = new LargestNumber(27);
            Assert.AreEqual(ln.FindLargestNumber(), 2);
        }

        [TestMethod]
        public void TestPerfect1()
        {
            PerfectNumbers pn = new PerfectNumbers(0, 500);
            CollectionAssert.Contains(pn.PerfectNumbersAB(), 28);
        }

        [TestMethod]
        public void TestPerfect2()
        {
            PerfectNumbers pn = new PerfectNumbers();
            CollectionAssert.DoesNotContain(pn.PerfectNumbersAB(), 2);
        }

        [TestMethod]
        public void TestPermute1()
        {
            List<string> list = new List<string>() { "123", "132", "213", "231", "321","312"};
            Combinatoric combinatoric = new Combinatoric("123");
            CollectionAssert.AreEquivalent(combinatoric.Permute(0), list);
        }

        [TestMethod]
        public void TestPermute2()
        {
            List<string> list = new List<string>() { "123", "132", "213", "231", "321", "312" };
            Combinatoric combinatoric = new Combinatoric("1234");
            CollectionAssert.AreNotEquivalent(combinatoric.Permute(0), list);
        }


    }
}
