namespace Dependent2
{
    using Jfk.Prism;

    [Description("Metoda konkraktu klasy zwraca silnie podanej liczby. Przyjmuje jeden argument typu int")]
    public sealed class Factorial : ICallable
    {
        public static void Main(string [] args)
        {
            return;
        }

        int s;
        int ICallable.Count(int n)
        {
            s = 1;
            for (int i = 1; i <= n; i++)
            {
                s = s * i;
            }
            return s;
        }

    }
}
