namespace Dependent2
{
    using Jfk.Prism;

    [Description("Metoda konkraktu klasy n-ty wyraz ciagu fibonacciego. Przyjmuje jeden argument typu int")]
    public sealed class Fibonacci : ICallable
    {
        int ICallable.Count(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                b += a;
                a = b - a;
            }

            return a;
        }
    }
}
