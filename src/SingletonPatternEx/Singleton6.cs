using System;

namespace SingletonPatternEx
{
// using .NET 4's Lazy<T> type
public sealed class Singleton6
{
    private static readonly Lazy<Singleton6> lazy =
        new Lazy<Singleton6>(() => new Singleton6());

    public static Singleton6 Instance
    {
        get { return lazy.Value; }
    }

    private Singleton6() { }
}
}
