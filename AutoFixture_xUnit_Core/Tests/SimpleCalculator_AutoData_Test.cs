using System.Linq;
using AutoFixture;
using AutoFixture.Xunit2;
using AutoFixture_xUnit_Core.Concrete;
using Xunit;

namespace AutoFixture_xUnit_Core.Tests
{
    public class SimpleCalculator_AutoData_Test
    {
        [Theory]        
        [AutoData]
        public void SimpleCalculator_AutoData_Addition(int a, int b)
        {
            var calc = new SimpleCalculator();

            calc.Add(a);
            calc.Add(b);

            Assert.True(calc.Result == a + b);
        }

        [Theory]
        [AutoData]
        public void SimpleCalculator_AutoData_Subtraction(int a, int b)
        {
            var calc = new SimpleCalculator();

            calc.Subtract(a);
            calc.Subtract(b);

            Assert.True(calc.Result == 0 - a - b);
        }
    }
}
