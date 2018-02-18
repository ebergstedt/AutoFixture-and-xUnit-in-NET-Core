using System.Linq;
using AutoFixture;
using AutoFixture.Xunit2;
using AutoFixture_xUnit_Core.Concrete;
using Xunit;

namespace AutoFixture_xUnit_Core.Tests
{
    public class SimpleCalculator_InlineAutoData_Test
    {
        [Theory]        
        [InlineAutoData(2, 1)]
        public void SimpleCalculator_InlineAutoData_Addition(int a, int b)
        {
            var calc = new SimpleCalculator();

            calc.Add(a);
            calc.Add(b);

            Assert.True(calc.Result == 3);
        }

        [Theory]
        [InlineAutoData(2, 1)]
        public void SimpleCalculator_InlineAutoData_Subtraction(int a, int b)
        {
            var calc = new SimpleCalculator();

            calc.Subtract(a);
            calc.Subtract(b);

            Assert.True(calc.Result == -3);
        }
    }
}
