namespace LiveCodeApp
{
    public interface IWell
    {
        public double InnerDiameter { get; }

        public double GetBottomPressure(double flowRate, double TopPressure);
    }
}