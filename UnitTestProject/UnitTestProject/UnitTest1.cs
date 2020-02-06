using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            SimpleCalc calc = new SimpleCalc();
            double result = calc.Add(2, 3);
            Assert.AreEqual(6, result); //intentionally wrong 1st
        }
        [TestMethod]
        public void TestDivide()
        {
            SimpleCalc calc = new SimpleCalc();
            double result = calc.Divide(100, 2);
            Assert.AreEqual(50, result); //correct, but make wrong inside class
        }
    }
}
// now, fill this first.
// simple example TDD for IT blog.