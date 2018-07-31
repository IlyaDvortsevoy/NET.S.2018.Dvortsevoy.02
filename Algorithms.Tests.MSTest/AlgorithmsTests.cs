using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.MSTest
{
    [TestClass]
    public class AlgorithmsTests
    {
        [TestMethod]
        public void InsertNumber_executes_successfully()
        {
            int result1 = Algorithm.InsertNumber(6, 10, 1, 3);
            int result2 = Algorithm.InsertNumber(29, 20, 2, 6);

            Assert.AreEqual(4, result1);
            Assert.AreEqual(81, result2);
        }

        [TestMethod]
        public void FilterDigitByDivision_executes_successfully()
        {
            int[] result1 = Algorithm.FilterDigitByDivision(5, 15, 7, 33, 105, -4, -53);
            int[] result2 = Algorithm.FilterDigitByDivision(9, 20, 2, 6, 19, 99, -100, -109);

            CollectionAssert.AreEqual(new int[] { 15, 105, -53 }, result1);
            CollectionAssert.AreEqual(new int[] { 19, 99, -109 }, result2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidatePoints_throws_exception_when_starting_point_less_than_zero()
        {
            Algorithm.InsertNumber(6, 10, -1, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidatePoints_throws_exception_when_starting_point_greater_than_ending_point()
        {
            Algorithm.InsertNumber(6, 10, 15, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidatePoints_throws_exception_when_ending_point_exceeds_limitation()
        {
            Algorithm.InsertNumber(6, 10, 1, 33);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ValidateArray_throws_exception_when_null_value_passed()
        {
            Algorithm.FilterDigitByDivision(5, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidateDigit_throws_exception_when_digit_is_out_of_the_range()
        {
            Algorithm.FilterDigitByDivision(10, 34, 1, -1, 0);
        }
    }
}
