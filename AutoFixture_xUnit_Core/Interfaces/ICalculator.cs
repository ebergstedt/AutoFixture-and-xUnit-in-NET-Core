namespace AutoFixture_xUnit_Core.Interfaces
{
    public interface ICalculator
    {
        decimal Result { get; }

        void Add(decimal value);

        void Subtract(decimal value);
    }
}
