using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void CItriggertest()
        {
            Console.WriteLine("CI trigger test");
        }
        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Arrange
            var calc = new Calculator();

            // Act
            int result = calc.Add(2, 3);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            var calc = new Calculator();
            int result = calc.Multiply(2, 4);
            Assert.Equal(8, result);


        }
        [Fact]
        public void Subtract_TwoNumbers_ReturnsSub()
        {
            var calc = new Calculator();
            int result = calc.Subtract(9, 1);
            Assert.Equal(8, result);
        }
    }
}
