using System;
using System.Collections.Generic;
using System.Text;
using AutoFixture_xUnit_Core.Interfaces;

namespace AutoFixture_xUnit_Core.Concrete
{
    public class SimpleCalculator : ICalculator
    {
        private decimal _result = 0;

        public decimal Result => _result;

        public SimpleCalculator(decimal initialValue = 0)
        {
            _result = initialValue;
        }

        public void Add(decimal value)
        {
            _result = _result + value;
        }

        public void Subtract(decimal value)
        {
            _result = _result - value;
        }
    }
}
