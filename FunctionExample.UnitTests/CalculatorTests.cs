using FunctionExample.Services;
using System;
using Xunit;

namespace FunctionExample.UnitTests
{
    public class CalculatorTests
    {
        Calculator calculator;

        public CalculatorTests()
        {
            calculator = new Calculator();
        }

        [Theory]
        [InlineData(1,1,2)]
        [InlineData(5, 7, 12)]
        [InlineData(10, 10, 20)]
        public void AddNumbers(int integer1, int integer2, int expectedResult)
        {
            var result = calculator.Add(integer1, integer2);
            Assert.Equal(expectedResult, result);

        }
    }
}
