using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryUP13;

namespace UP13_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TextFile textFile = new TextFile();
            Assert.AreEqual(textFile.ChangeLetter("task1", "т", "б"), "буб будеб бексб");
        }

        [TestMethod]
        public void TestMethod2()
        {
            TextFile textFile = new TextFile();
            Assert.AreNotEqual(textFile.ChangeLetter("task1", "т", "б"), "тут тудет текст");
        }


        [TestMethod]
        public void SortNumbers1()
        {
            TextFile textFile = new TextFile();
            Assert.AreEqual(string.Join(" ", textFile.SortNumbers("sortTask2")), "1 3 6 7 8");
        }

        [TestMethod]
        public void SortNumbers2()
        {
            TextFile textFile = new TextFile();
            Assert.AreNotEqual(string.Join(" ", textFile.SortNumbers("sortTask2")), "1 9 9 7 8");
        }

        [TestMethod]
        public void FileComponent1()
        {
            TextFile textFile = new TextFile();
            Assert.AreEqual(textFile.FileComponent("fileComponentTask3", 8),7);

        }

        [TestMethod]
        public void FileComponent2()
        {
            TextFile textFile = new TextFile();
            Assert.AreNotEqual(textFile.FileComponent("fileComponentTask3", 8), 4);

        }
    }
}
