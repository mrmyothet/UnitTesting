using UnitTesting.Fundamentals;

namespace UnitTesting.UnitTests;

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
        Assert.That(result == true);
    }

    [Test]
    public void CanBeCancelledBy_MadeByUserCancelling_ReturnsTrue()
    {
        var user = new User();
        var reservation = new Reservation() { MadeBy = user };

        var result = reservation.CanBeCancelledBy(user);

        Assert.True(result == true);
    }

    [Test]
    public void CanBeCancelledBy_OtherUserCancelling_ReturnsFalse()
    {
        var reservation = new Reservation() { MadeBy = new User() };

        var result = reservation.CanBeCancelledBy(new User());

        Assert.That(result == false);
    }
}
