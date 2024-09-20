namespace LiveCodeApp
{
    public sealed class TabularSolver : ISolver
    {
        private readonly double _minArgument;
        private readonly double _maxArgument;
        private readonly long _numberOfSteps;
        public TabularSolver(double minArgument, double maxArgument, int numberOfSteps)
        {
            _maxArgument = maxArgument;
            _numberOfSteps = numberOfSteps;
            _minArgument = minArgument;
        }
        public double? SolveFunctions(ISolver.MonotonicFunction function1, ISolver.MonotonicFunction function2)
        {
            double argumentStep = (_maxArgument - _minArgument) / _numberOfSteps;
            double solution = _minArgument - 1;
            for (long i = 0; i < _numberOfSteps; i++)
            {
                double currentArgument = _minArgument + i * argumentStep;
                double df1 = function1(currentArgument) - function2(currentArgument);
                double df2 = function1(currentArgument + argumentStep) - function2(currentArgument + argumentStep);
                if ((df1 >= 0 && df2 <= 0) || (df1 <= 0 && df2 >=0))
                {
                    solution = currentArgument - df1 * argumentStep / (df2 - df1);
                }
            }
            if (solution > _minArgument)
            {
                return solution;
            }
            else
            { 
                return null;
            }
        }
    }
}