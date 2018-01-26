namespace Dependent
{
    using Jfk.Prism;

    [Description("Metoda klasy kontraktu zwraca kwadrat podanej liczby. Przyjmuje jeden argument typu int")]
    public sealed class Power : ICallable
    {
        int ICallable.Count(int n) => n * n;
    }
    
}