using Math = UnitTesting.Fundamentals.Math;

namespace UnitTesting.UnitTests;

[TestFixture]
public class MathTests
{

    private Math _math;
    
    // Setup 
    // TearDown

    [SetUp]
    public void Setup()
    {
        _math = new Math();
    }

    [Test]
    [Ignore("Because I wanted to!")]
    public void Add_WhenCalled_Returns_Sum()
    {

        var result = _math.Add(1, 2);
        
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    [TestCase(2, 1, 2)]
    [TestCase(1, 2, 2)]
    [TestCase(1, 1, 1)]
    public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
    {
        var result = _math.Max(a, b);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}