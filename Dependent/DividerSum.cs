namespace Dependent
{
    using Jfk.Prism;

    [Description("Metoda klasy kontraktu zwraca sume dzielnikow podanej liczby. Przyjmuje jeden argument typu int")]
    public sealed class DividerSum : ICallable
    {
         int ICallable.Count(int n)
        {
            int s = 0;
            for(int i=1;i<=n/2;i++)
            {
                if(n%i==0)
                {
                    s += i;
                }
            }
            return s;
        }
    }
}
