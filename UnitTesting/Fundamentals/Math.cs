using System.Data;

namespace UnitTesting.Fundamentals;

public class Math
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Max(int a, int b)
    {
        return (a > b) ? a : b;
    }
}