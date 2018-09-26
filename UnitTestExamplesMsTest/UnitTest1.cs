using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryToTest;

namespace UnitTestExamplesMsTest
{
    [TestClass]
    public class UnitTest1
    {
        private ClassToTest1 classToTest1;

        [TestInitialize]
        public void InitUnitTest() => classToTest1 = new ClassToTest1();

        [TestMethod]
        public void TestAddTwoPositiveNumbers()
        {
            var i = 3;
            var j = 5;
            var res = classToTest1.Adder(i, j);
            Assert.AreEqual(8, res);
        }
            
        [TestMethod]
        public void TestAddTwoNegativeNumbers()
        {
            var i = -3;
            var j = -5;
            var res = classToTest1.Adder(i, j);
            Assert.AreEqual(-118, res);
        }
    }
}

