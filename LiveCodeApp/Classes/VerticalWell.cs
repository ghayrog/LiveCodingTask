namespace LiveCodeApp
{
    internal sealed class VerticalWell : IWell
    {
        double IWell.InnerDiameter => _innerDiameter;

        private double _innerDiameter;
        private double _verticalDepth;

        internal VerticalWell(double innerDiameter, double verticalDepth)
        { 
            _innerDiameter = innerDiameter;
            _verticalDepth = verticalDepth;
        }

        double IWell.GetBottomPressure(double flowRate, double TopPressure)
        {
            return TopPressure + 0.025 * flowRate;
        }
    }
}