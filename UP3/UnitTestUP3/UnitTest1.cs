using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UP3_Library;
using System.Collections.Generic;

namespace UnitTestUP3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCountPointOutOfCircle1()
        {
            var sp = new SetPooints();
            sp.Add(new Point(1, 1));
            sp.Add(new Point(-15, 16));
            sp.Add(new Point(13, -13));
            sp.Add(new Point(-1, -1));
            Assert.AreEqual(sp.CountPointOutOfCircle(), 3);
        }

        [TestMethod]
        public void TestCountPointOutOfCircle2()
        {
            var sp = new SetPooints();
            sp.Add(new Point(1, 1));
            sp.Add(new Point(-15, 16));
            sp.Add(new Point(13, -13));
            sp.Add(new Point(-1, -1));
            Assert.AreNotEqual(sp.CountPointOutOfCircle(), 2);
        }

        [TestMethod]
        public void TestIsTwoTrianglesWithEqualsErias1()
        {
            var sp = new SetPooints();
            sp.Add(new Point(1, 1));
            sp.Add(new Point(-15, 16));
            sp.Add(new Point(13, -13));
            sp.Add(new Point(-1, -1));
            Assert.AreEqual(sp.IsTwoTrianglesWithEqualsErias(), false);
        }

        [TestMethod]
        public void TestIsTwoTrianglesWithEqualsErias2()
        {
            var sp = new SetPooints();
            sp.Add(new Point(1, 1));
            sp.Add(new Point(-15, 16));
            sp.Add(new Point(13, -13));
            sp.Add(new Point(-1, -1));
            Assert.AreNotEqual(sp.IsTwoTrianglesWithEqualsErias(), true);
        }

        [TestMethod]
        public void TestFindIntersectionPoints1() 
        {
            Rectangle rg = new Rectangle();
            List<double> Xcoordinates = new List<double>() { -5, -3, 2, 4 };
            List<Point> result = rg.FindIntersectionPoints(Xcoordinates);
            List<Point> CheckResult = new List<Point>()
            { new Point(-3,2), new Point(-3,-2), new Point (2,2), new Point(2,-2), new Point(4,2), new Point(4,-2)};
            CollectionAssert.AreEqual(CheckResult, result);
        }

        [TestMethod]
        public void CheckArea()
        {
            List<Point> points1 = new List<Point>()
            {
                new Point(1,1), new Point(2,5), new Point(5,3) };
            SetPooints set = new SetPooints();
            Assert.AreEqual(set.CountArea(points1, 0, 1, 2), 7);
          
        }

    }
}
