using System;
using System.Collections.Generic;
using System.Text;

namespace AutoFixture_xUnit_Core.Interface
{
    public interface ICalculator
    {
        decimal Result { get; }

        void Add(decimal value);

        void Subtract(decimal value);
    }
}
