using Math = UnitTesting.Fundamentals.Math;

namespace UnitTesting.UnitTests;

[TestFixture]
public class MathTests
{
    [Test]
    public void Add_WhenCalled_Returns_Sum()
    {
        var math = new Math();

        var result = math.Add(1, 2);
        
        Assert.That(result, Is.EqualTo(3));
    }
}