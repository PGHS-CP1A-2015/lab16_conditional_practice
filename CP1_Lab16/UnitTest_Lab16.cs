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
            Assert.IsTrue(cm.isMultipleOf7(49));
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
            Assert.IsFalse(cm.isMultipleOf3And5(16));
            Assert.IsTrue(cm.isMultipleOf3And5(5175));
            Assert.IsFalse(cm.isMultipleOf3And5(5172));

        }

        [TestMethod]
        public void TestAge()
        {
            // given an age, figure out whether someone 
            // is a baby, toddler, child, teenager, adult, or old codger
            /*
             old codger = 90 or higher
             adult = 18 to 89
             teenager = 13 to 17
             child = 3 to 12
             toddler = 1.5 to 2.9
             baby = 0 - 1.4
             unknown = negative numbers
            */
            Assert.AreEqual("baby", cm.ageCategory(0));
            Assert.AreEqual("baby",cm.ageCategory(1));
            Assert.AreEqual("baby", cm.ageCategory(1.4));
            Assert.AreEqual("adult", cm.ageCategory(45));
            Assert.AreEqual("teenager", cm.ageCategory(13));
            Assert.AreEqual("teenager", cm.ageCategory(17));
            Assert.AreEqual("adult", cm.ageCategory(18));
            Assert.AreEqual("old codger", cm.ageCategory(90));
            Assert.AreEqual("old codger", cm.ageCategory(120));
            Assert.AreEqual("unknown", cm.ageCategory(-5));
        }
        [TestMethod]
        public void TestGrades()
        {
            // given a percentage, calculate the letter grade
            /*
                A  = 100% to 94%
                A- = < 94% to 90%
                B+ = < 90% to 87%
                B  = < 87% to 84%
                B- = < 84% to 80%
                C+ = < 80% to 77%
                C  = < 77% to 74%
                C- = < 74% to 70%
                D+ = < 70% to 67%
                D  = < 67% to 64%
                D- = < 64% to 61%
                F  = < 61% to 0%
                Unknown = negative number
                */
            Assert.AreEqual("A", cm.percentageToGrade(94));
            Assert.AreEqual("A-", cm.percentageToGrade(93));
            Assert.AreEqual("B+", cm.percentageToGrade(89));
            Assert.AreEqual("B", cm.percentageToGrade(85));
            Assert.AreEqual("B-", cm.percentageToGrade(81));
            Assert.AreEqual("C+", cm.percentageToGrade(77));
            Assert.AreEqual("C", cm.percentageToGrade(75));
            Assert.AreEqual("C-", cm.percentageToGrade(73));
            Assert.AreEqual("D+", cm.percentageToGrade(69));
            Assert.AreEqual("D", cm.percentageToGrade(64));
            Assert.AreEqual("D-", cm.percentageToGrade(63));
            Assert.AreEqual("F", cm.percentageToGrade(10));
            Assert.AreEqual("Unknown", cm.percentageToGrade(-1));
        }
    }
}
