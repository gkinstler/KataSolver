using System;
using Xunit;
using KataSolver;

namespace KataSolverTests.tests
{
    public class KataTests
    {
        [Theory]
        [InlineData('+', 4, 7, 11)]
        [InlineData('-', 2, 1, 1)]
        [InlineData('*', 4, 7, 28)]
        public void BasicOps(char operation, double value1, double value2, double expected)
        {
            // Arrange
            MathOps kataTests = new MathOps();

            // Act
            double actual = kataTests.BasicOps(operation, value1, value2);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
