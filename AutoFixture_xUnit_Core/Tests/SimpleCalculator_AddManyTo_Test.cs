using System.Linq;
using AutoFixture;
using AutoFixture_xUnit_Core.Concrete;
using Xunit;

namespace AutoFixture_xUnit_Core.Tests
{
    public class SimpleCalculator_AddManyTo_Test
    {
        [Fact]
        public void SimpleCalculator_AddManyTo_Addition()
        {
            // Arrange
            var calc = new SimpleCalculator();
            var fix = new Fixture();

            // Act
            var list = fix.CreateMany<int>(100).ToList();
            fix.AddManyTo(list, 100);

            list.ForEach(n => calc.Add(n));

            // Assert
            Assert.True(calc.Result > 0);
        }

        [Fact]
        public void SimpleCalculator_AddManyTo_Subtraction()
        {
            // Arrange
            var calc = new SimpleCalculator();
            var fix = new Fixture();

            // Act
            var list = fix.CreateMany<int>(100).ToList();
            fix.AddManyTo(list, 100);

            list.ForEach(n => calc.Subtract(n));

            // Assert
            Assert.True(calc.Result < 0);
        }
    }
}
