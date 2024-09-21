namespace LiveCodeApp
{
    public interface ISolver
    {
        public delegate double MonotonicFunction(double argument);

        public bool IsBusy { get; }
        public int PercentDone { get; }
        public double SecondsElapsed { get; }

        //Solves equation f1(x) = f2(x)
        double? SolveFunctions(MonotonicFunction function1, MonotonicFunction function2);
    }
}