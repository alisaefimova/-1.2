using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Библиотека;

namespace Тест
{
    [TestClass]
    public class Test1
    {
        Calculator calc = new Calculator(); 

        [TestMethod]
        public void Add_Test()
        {
            Assert.AreEqual(5, calc.Add(2, 3));
        }

        [TestMethod]
        public void Divide_Test()
        {
            Assert.AreEqual(2, calc.Divide(4, 2));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ByZero_Test()
        {
            calc.Divide(5, 0);
        }
    }
}