using System;
using Xunit;
using KataSolver;

namespace KataSolverTests.tests
{
    public class KataTests
    {
        //  8KU #1 https://www.codewars.com/kata/basic-mathematical-operations //

        [Theory]
        [InlineData('+', 4, 7, 11)]
        [InlineData('-', 2, 1, 1)]
        [InlineData('*', 4, 7, 28)]
        [InlineData('/', 4, 2, 2)]
        public void BasicMathOps(char operation, double value1, double value2, double expected)
        {
            // Arrange
            BasicMathOps BasicMathOps = new BasicMathOps();

            // Act
            double actual = BasicMathOps.BasicMathOpsTests(operation, value1, value2);

            // Assert
            Assert.Equal(expected, actual);
        }

        //  8KU #2 https://www.codewars.com/kata/century-from-year //

        [Theory]
        [InlineData(1750, 17)]
        [InlineData(1865, 18)]
        [InlineData(1900, 19)]
        public void CenturyFromYear(int year, int expected)
        {
            // Arrange
            CenturyFromYear CenturyFromYear = new CenturyFromYear();

            // Act
            int actual = CenturyFromYear.СenturyFromYearTests(year);

            // Assert
            Assert.Equal(expected, actual);
        }

        //  8KU #3 https://www.codewars.com/kata/even-or-odd //

        [Theory]
        [InlineData(2, "Even")]
        [InlineData(1, "Odd")]
        [InlineData(7, "Odd")]
        [InlineData(0, "Even")]
        public void EvenOrOdd(int number, string expected)
        {
            // Arrange
            EvenOrOdd EvenOrOdd = new EvenOrOdd();

            // Act
            string actual = EvenOrOdd.EvenOrOddTests(number);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
