using Microsoft.VisualStudio.TestTools.UnitTesting;
using TK;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        private readonly MainWindow _mainWindow = new MainWindow();

        [TestMethod]
        public void TestMethod1()
        {
            int total = _mainWindow.CalculateTotalScore(10, 50, 30, 10);
            string grade = _mainWindow.CalculateGrade(total);
            Assert.AreEqual(100, total);
            Assert.AreEqual("5 (отлично)", grade);

        }

        [TestMethod]
        public void TestMethod2()
        {
            int total = _mainWindow.CalculateTotalScore(10, 40, 15, 5);
            string grade = _mainWindow.CalculateGrade(total);
            Assert.AreEqual(70, total);
            Assert.AreEqual("5 (отлично)", grade);

        }

        [TestMethod]
        public void TestMethod3()
        {
            int total = _mainWindow.CalculateTotalScore(2, 5, 8, 5);
            string grade = _mainWindow.CalculateGrade(total);
            Assert.AreEqual(20, total);
            Assert.AreEqual("3 (удовлетворительно)", grade);

        }

        [TestMethod]
        public void TestMethod4()
        {
            int total = _mainWindow.CalculateTotalScore(5, 20, 15, 5);
            string grade = _mainWindow.CalculateGrade(total);
            Assert.AreEqual(45, total);
            Assert.AreEqual("4 (хорошо)", grade);

        }

        [TestMethod]
        public void TestMethod5()
        {
            int total = _mainWindow.CalculateTotalScore(0, 0, 0, 0);
            string grade = _mainWindow.CalculateGrade(total);
            Assert.AreEqual(0, total);
            Assert.AreEqual("2 (неудовлетворительно)", grade);

        }
    }
}
