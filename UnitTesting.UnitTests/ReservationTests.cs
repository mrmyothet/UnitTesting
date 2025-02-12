using UnitTesting.Fundamentals;

namespace UnitTesting.UnitTests;

[TestFixture]
public class ReservationTests
{
    [Test]
    public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
    {
        //Arrange
        var reservation = new Reservation();

        //Act
        var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

        //Assert
        //Assert.That(result == true);
        Assert.That(result, Is.True);
    }

    [Test]
    public void CanBeCancelledBy_MadeByUserCancelling_ReturnsTrue()
    {
        var user = new User();
        var reservation = new Reservation() { MadeBy = user };

        var result = reservation.CanBeCancelledBy(user);

        //Assert.True(result == true);
        Assert.That(result, Is.True);
    }

    [Test]
    public void CanBeCancelledBy_OtherUserCancelling_ReturnsFalse()
    {
        var reservation = new Reservation() { MadeBy = new User() };

        var result = reservation.CanBeCancelledBy(new User());

        Assert.That(result, Is.False);
    }
}
