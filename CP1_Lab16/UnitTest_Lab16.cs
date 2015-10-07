using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using cm = Lab16_Conditionals.MyConditionalMethods;

namespace CP1_Lab16
{
    [TestClass]
    public class UnitTest_Lab16
    {
        [TestMethod]
        public void TestMethod1()
        {
            
        }
        [TestMethod]
        public void TestMultiples()
        {
            // isMultipleOf3
            Assert.IsTrue(cm.isMultipleOf3(27));
            Assert.IsFalse(cm.isMultipleOf3(28));
            Assert.IsTrue(cm.isMultipleOf3(10368));
            // isMultipleOf5
            Assert.IsTrue(cm.isMultipleOf5(25));
            Assert.IsFalse(cm.isMultipleOf5(4257));
            Assert.IsTrue(cm.isMultipleOf5(1030));
            // isMultipleOf7
            Assert.IsTrue(cm.isMultipleOf7(21));
            Assert.IsFalse(cm.isMultipleOf7(49));
            Assert.IsTrue(cm.isMultipleOf7(168));

        }
        [TestMethod]
        public void TestOrMultiples()
        {
            // isMultipleOf3Or5
            Assert.IsTrue(cm.isMultipleOf3Or5(9));
            Assert.IsFalse(cm.isMultipleOf3Or5(8));
            Assert.IsTrue(cm.isMultipleOf3Or5(5172));
            Assert.IsFalse(cm.isMultipleOf3Or5(5176));

        }
        [TestMethod]
        public void TestAndMultiples()
        {
            // isMultipleOf3And5
            Assert.IsFalse(cm.isMultipleOf3And5(9));
            Assert.IsFalse(cm.isMultipleOf3And5(15));
            Assert.IsTrue(cm.isMultipleOf3Or5(5175));
            Assert.IsFalse(cm.isMultipleOf3Or5(5172));

        }
    }
}
