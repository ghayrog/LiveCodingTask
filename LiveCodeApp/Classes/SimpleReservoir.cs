namespace LiveCodeApp
{
    public class SimpleReservoir : IReservoir
    {
        public double ReservoirPressure => _reservoirPressure;

        double _reservoirPressure;

        public SimpleReservoir(double initialPressure)
        {
            _reservoirPressure = initialPressure;
        }

        public double GetBottomPressure(double flowRate)
        {
            double pSquared = _reservoirPressure * _reservoirPressure - flowRate * 20;
            return (pSquared > 0 ) ? Math.Sqrt( pSquared ) : 0;
        }
    }
}