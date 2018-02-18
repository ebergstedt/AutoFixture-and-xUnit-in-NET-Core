using System.Linq;
using AutoFixture;
using AutoFixture_xUnit_Core.Concrete;
using Xunit;

namespace AutoFixture_xUnit_Core.Tests
{
    public class SimpleCalculator_CreateMany_Test
    {
        [Fact]
        public void SimpleCalculator_CreateMany_Addition()
        {
            // Arrange
            var calc = new SimpleCalculator();
            var fix = new Fixture();

            // Act
            fix.CreateMany<int>(100).ToList().ForEach(n => calc.Add(n));            

            // Assert
            Assert.True(calc.Result > 0);
        }

        [Fact]
        public void SimpleCalculator_CreateMany_Subtraction()
        {
            // Arrange
            var calc = new SimpleCalculator();
            var fix = new Fixture();

            // Act
            fix.CreateMany<int>(100).ToList().ForEach(n => calc.Subtract(n));

            // Assert
            Assert.True(calc.Result < 0);
        }
    }
}
