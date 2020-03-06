using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using ClassLibraryUP8;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestUP8
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void OutputNotServed()
        {
            var Empl = new Employee[5];
            string[] data = File.ReadAllLines("dataEmployee.txt");
            int k = 0;
            for (int i = 0; i < Empl.Length; i++)
            {
                Empl[i] = new Employee(data[k], data[k + 1]);
                k += 2;
            }
            List<string> checkResult = new List<string>() { "фамилия1", "фамилия4" };
            CollectionAssert.AreEqual(OutputNotServed(Empl), checkResult);
        }

        [TestMethod]
        public void MomentOfTime1()
        {
            var moment = new MomentOfTime[5];
            int[][] day = File.ReadAllLines("dayInfo.txt")
            .Select(x => x.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
            Select(y => Int32.Parse(y)).ToArray()).ToArray();

            int c = 0;
            for (int i = 0; i < moment.Length; i++)
            {
                moment[i] = new MomentOfTime(day[i][0], day[i][1], day[i][2]);

            }
            Comparer<MomentOfTime> mt = Comparer<MomentOfTime>.Default;
            int z = mt.Compare(moment[3], moment[4]);
            Assert.AreEqual(z, -1);
        }

        [TestMethod]
        public void MomentOfTime2()
        {
            var moment = new MomentOfTime[5];
            int[][] day = File.ReadAllLines("dayInfo.txt")
            .Select(x => x.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
            Select(y => Int32.Parse(y)).ToArray()).ToArray();

            int c = 0;
            for (int i = 0; i < moment.Length; i++)
            {
                moment[i] = new MomentOfTime(day[i][0], day[i][1], day[i][2]);

            }
            Comparer<MomentOfTime> mt = Comparer<MomentOfTime>.Default;
            int z = mt.Compare(moment[4], moment[3]);
            Assert.AreEqual(z, 1);
        }

        [TestMethod]
        public void MomentOfTime3()
        {
            var moment = new MomentOfTime[5];
            int[][] day = File.ReadAllLines("dayInfo.txt")
            .Select(x => x.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
            Select(y => Int32.Parse(y)).ToArray()).ToArray();

            int c = 0;
            for (int i = 0; i < moment.Length; i++)
            {
                moment[i] = new MomentOfTime(day[i][0], day[i][1], day[i][2]);

            }
            Comparer<MomentOfTime> mt = Comparer<MomentOfTime>.Default;
            int z = mt.Compare(moment[3], moment[3]);
            Assert.AreEqual(z, 0);
        }


        [TestMethod]
        public void Numbers1()
        {
            Numbers nb = new Numbers();
            Assert.AreEqual(3, nb.Division(12, 4));
        }

        [TestMethod]
        public void Numbers2()
        {
            Numbers nb = new Numbers();
            Assert.AreEqual(48, nb.Multiple(12, 4));
        }


        private static List<string> OutputNotServed(Employee[] Empl)
        {
            List<string> ls = new List<string>();
            for (int i = 0; i < Empl.Length; i++)
            {
                if (Empl[i].Service == "не служил")
                {
                    ls.Add(Empl[i].Surname);
                }
            }
            return ls;
        }
    }
}
