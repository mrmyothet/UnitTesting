using Math = UnitTesting.Fundamentals.Math;

namespace UnitTesting.UnitTests;

[TestFixture]
public class MathTests
{
    [Test]
    [Ignore("Because I wanted to!")]
    public void Add_WhenCalled_Returns_Sum()
    {
        var math = new Math();

        var result = math.Add(1, 2);
        
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
    {
        var math = new Math();

        var result = math.Max(2, 1);
        
        Assert.That(result, Is.EqualTo(2));
    }
    
    [Test]
    public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
    {
        
        var math = new Math();

        var result = math.Max(1, 2);
        
        Assert.That(result, Is.EqualTo(2));
    }
    
    [Test]
    public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
    {
        
        var math = new Math();

        var result = math.Max(1, 1);
        
        Assert.That(result, Is.EqualTo(1));
    }
}