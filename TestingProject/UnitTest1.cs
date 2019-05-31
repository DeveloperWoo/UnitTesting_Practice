using System;
using System.CodeDom;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using W4_2_UnitTestingExample;

namespace TestingProject
{
    [TestClass] // class annotation, required
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddMethod()
        {
            //step1:  create an object
            var calculator = new Calculator();
            //step2: call methods
            int result = calculator.Add(3, 4);
            //step3: check result
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void TestDivide()
        {
            var calculator = new Calculator();
            int result = calculator.Divide(4, 2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivideByZero()
        {
            var calculator = new Calculator();
            int result = calculator.Divide(4, 0);
            Assert.Fail();
        }
    }
}
