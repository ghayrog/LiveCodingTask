namespace LiveCodeApp
{
    public sealed class VerticalWell : IWell
    {
        public double InnerDiameter => _innerDiameter;

        private double _innerDiameter;
        private double _verticalDepth;

        public VerticalWell(double innerDiameter, double verticalDepth)
        { 
            _innerDiameter = innerDiameter;
            _verticalDepth = verticalDepth;
        }

        public double GetBottomPressure(double flowRate, double topPressure)
        {
            return topPressure + 0.025 * flowRate;
        }

    }
}