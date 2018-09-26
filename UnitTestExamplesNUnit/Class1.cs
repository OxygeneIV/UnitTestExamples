using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryToTest;
using NUnit;
using NUnit.Framework;

namespace UnitTestExamplesNUnit
{
    [TestFixture]
    public class UnitTest1
    {
        private ClassToTest1 classToTest1;

        [SetUp]
        public void InitUnitTest() => classToTest1 = new ClassToTest1();

        [TestCase]
        public void TestAddTwoPositiveNumbers()
        {
            var i = 3;
            var j = 5;
            var res = classToTest1.Adder(i, j);
            Assert.AreEqual(8, res);
        }

        [TestCase]
        public void TestAddTwoNegativeNumbers()
        {
            var i = -3;
            var j = -5;
            var res = classToTest1.Adder(i, j);
            Assert.AreEqual(-118, res);
        } 
        //[TestCase]
        //public void TestAddPositiveAndNegativeNumbers()
        //{
        //    var i = -3;
        //    var j = 5;
        //    var res = classToTest1.Adder(i, j);
        //    Assert.AreEqual(-1, res);
        //}
    }
}
