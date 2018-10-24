using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tasks7and8;

namespace Task7and8.Tests
{
    [TestClass]
    public class BusinessLogicTests
    {
        [TestMethod]
        public void FibonacciTest()
        {
            //arrange
            int number = 7;
            BusinessLogic bl = new BusinessLogic();

            //act
            int result = bl.Fibonacci(number);

            //assert
            Assert.AreEqual(13, result);
        }

        [TestMethod]
        public void GetSequenceInRangeTest()
        {
            // arrange
            int left = 7;
            int right = 15;
            BusinessLogic bl = new BusinessLogic();

            //act
            string result = bl.GetSequenceInRange(left, right);

            //assert
            Assert.AreEqual("8, 13, ", result);
        }

        [TestMethod]
        public void GetSequenceTest_SetMaxValue_ReturnCorrectString()
        {
            // arrange
            int maxValue = 20;
            BusinessLogic bl = new BusinessLogic();

            //act
            string result = bl.GetSequence(maxValue);

            //assert
            Assert.AreEqual("1, 2, 3, 4, ", result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FibonacciTest_SetMaxValue_ReturnException()
        {
            //arrange
            int number = -7;
            BusinessLogic bl = new BusinessLogic();

            //act
            int result = bl.Fibonacci(number);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetSequenceInRangeTest_SetMaxValue_ReturnException()
        {
            // arrange
            int left = -7;
            int right = 0;
            BusinessLogic bl = new BusinessLogic();

            //act
            string result = bl.GetSequenceInRange(left, right);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetSequenceTest_SetMaxValue_ReturnException()
        {
            // arrange
            int maxValue = -20;
            BusinessLogic bl = new BusinessLogic();

            //act
            string result = bl.GetSequence(maxValue);
        }
    }
}