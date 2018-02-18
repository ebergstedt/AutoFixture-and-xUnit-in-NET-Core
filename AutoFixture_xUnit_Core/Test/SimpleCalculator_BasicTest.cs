using AutoFixture_xUnit_Core.Concrete;
using Xunit;

namespace AutoFixture_xUnit_Core.Test
{
    public class SimpleCalculator_BasicTest
    {
        [Fact]
        public void Test_SimpleCalculator_Addition()
        {
            // Arrange
            var calc = new SimpleCalculator();

            // Act
            calc.Add(1);

            // Assert
            Assert.True(calc.Result == 1);

        }

        [Fact]
        public void Test_SimpleCalculator_Subtraction()
        {
            // Arrange
            var calc = new SimpleCalculator();

            // Act
            calc.Subtract(1);

            // Assert
            Assert.True(calc.Result == -1);
        }
    }
}
