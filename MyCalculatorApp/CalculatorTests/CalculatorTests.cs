using CalculatorLib;
using Xunit;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            Assert.Equal(5, _calculator.Add(2, 3));
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            Assert.Equal(3, _calculator.Subtract(5, 2));
        }

        [Fact]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            Assert.Equal(12, _calculator.Multiply(4, 3));
        }

        [Fact]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            Assert.Equal(4, _calculator.Divide(8, 2));
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            var exception = Assert.Throws<ArgumentException>(() => _calculator.Divide(5, 0));
            Assert.Equal("Cannot divide by zero.", exception.Message);
        }
        [Fact]
        public void Power_BaseAndExponent_ReturnsResult()
        {
            Assert.Equal(8, _calculator.Power(2, 3));
        }
    }
}