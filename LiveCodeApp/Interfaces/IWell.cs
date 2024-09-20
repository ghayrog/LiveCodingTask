namespace LiveCodeApp
{
    internal interface IWell
    {
        internal double InnerDiameter { get; }

        internal double GetBottomPressure(double flowRate, double TopPressure);
    }
}