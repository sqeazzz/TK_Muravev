using Microsoft.VisualStudio.TestTools.UnitTesting;
using TK;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest2
    {
        private readonly MainWindow _mainWindow = new MainWindow();

        [TestMethod]
        
        public void TestMethod1()
        {

            _mainWindow.ValidateInput(11, 10, "Задание 1");

        }

        [TestMethod]
        public void TestMethod2()
        {
            _mainWindow.ValidateInput(-5, 50, "Задание 2");

        }

        [TestMethod]
        public void TestMethod3()
        {
            _mainWindow.ParseInput("abc", 30, "Задание 3");

        }

        [TestMethod]
        public void TestMethod4()
        {
            _mainWindow.ValidateInput(31, 30, "Задание 3");

        }

        [TestMethod]
        public void TestMethod5()
        {
            int total = _mainWindow.CalculateTotalScore(1, 2, 3, 4);
            string grade = _mainWindow.CalculateGrade(total);
            Assert.AreNotEqual("5 (отлично)", grade);
            Assert.AreEqual("2 (неудовлетворительно)", grade);

        }
    }
}
