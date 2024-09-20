namespace LiveCodeApp
{
    public interface IReservoir
    {
        double ReservoirPressure { get; }

        double GetBottomPressure(double flowRate);
    }
}
