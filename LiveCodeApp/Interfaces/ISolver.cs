namespace LiveCodeApp
{
    public interface ISolver
    {
        public delegate double MonotonicFunction(double argument);

        //Solves equation f1(x) = f2(x)
        double? SolveFunctions(MonotonicFunction function1, MonotonicFunction function2);
    }
}