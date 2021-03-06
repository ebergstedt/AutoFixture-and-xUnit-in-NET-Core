using AutoFixture;
using AutoFixture_xUnit_Core.Concrete;
using Xunit;

namespace AutoFixture_xUnit_Core.Tests
{
    public class SimpleCalculator_BasicFixture_Test
    {
        [Fact]
        public void SimpleCalculator_BasicFixture_Addition()
        {
            // Arrange
            var calc = new SimpleCalculator();
            var fix = new Fixture();

            // Act
            calc.Add(fix.Create<int>());

            // Assert
            Assert.True(calc.Result > 0);
        }

        [Fact]
        public void SimpleCalculator_BasicFixture_Subtraction()
        {
            // Arrange
            var calc = new SimpleCalculator();
            var fix = new Fixture();

            // Act
            calc.Subtract(fix.Create<int>());

            // Assert
            Assert.True(calc.Result < 0);
        }
    }
}
