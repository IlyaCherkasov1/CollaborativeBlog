using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba17DLL;

namespace Laba17Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> list = new List<int> { 1, 2, 3, 4 };
            Assert.AreEqual(3, list[2]);
        }

        [TestMethod]
        public void TestMethod2()
        {

            List<int> list1 = new List<int> { 1, 2, 3 };
            ListInt A1 = new ListInt(list1);
           
            List<int> list2 = new List<int> { 1, 2, 3,1,2,3};
            ListInt A2 = new ListInt(list2);
            Assert.AreEqual(+A1,A2);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int constant = 3;
            List<int> list1 = new List<int> { 1, 3, 4 };
            ListInt A1 = new ListInt(list1);
            List<int> list2 = new List<int> { 3,1, 3, 4 };
            ListInt A2 = new ListInt(list2);
            Assert.AreEqual(A1, A1 + constant);
        }

        [TestMethod]
        public void TestMethod4()
        { 
            int index = 2;
            var queue = new Queue<string>();
            queue.Enqueue("1");
            queue.Enqueue("2");
            queue.Enqueue("3");
            QueueString Q = new QueueString(queue);
            Assert.AreEqual("3", Q[index]);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var queue1 = new Queue<string>();
            queue1.Enqueue("1");
            queue1.Enqueue("2");
            QueueString Q1 = new QueueString(queue1);

            var queue2 = new Queue<string>();
            queue2.Enqueue("1");
            queue2.Enqueue("2");
            queue2.Enqueue("1");
            queue2.Enqueue("2");
            QueueString Q2 = new QueueString(queue2);
            Assert.AreEqual(+Q1, Q2); 
        }


        [TestMethod]
        public void TestMethod6()
        {
            var queue1 = new Queue<string>();
            queue1.Enqueue("1");
            queue1.Enqueue("2");
            queue1.Enqueue("3");
            QueueString Q1 = new QueueString(queue1);
            var queue2 = new Queue<string>();
            queue2.Enqueue("5");
            queue2.Enqueue("1");
            queue2.Enqueue("2");
            queue2.Enqueue("3");
            QueueString Q2 = new QueueString(queue2);
            string constant = "5";
            Assert.AreEqual(Q1 + constant, Q2);
        }

        [TestMethod]
        public void TestMethod7()
        {
            int count = 3;
            int[] C1 = new int[] { 1, 2, 3, 4 };
            GeneralizedClass<int> GS1 = new GeneralizedClass<int>(C1);
            Assert.AreEqual(GS1 << count, 2);
        }

        [TestMethod]
        public void TestMethod8()
        {
            int count = 4;
            int[] C1 = new int[] { 1, 2, 3, 4 };
            GeneralizedClass<int> GS1 = new GeneralizedClass<int>(C1);
            Assert.AreEqual(GS1 << count, 3);
        }


    }
}
