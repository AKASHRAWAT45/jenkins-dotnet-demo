using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
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
    }
}
