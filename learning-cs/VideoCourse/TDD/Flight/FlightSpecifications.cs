using Domain;
using FluentAssertions;

namespace FlightTest
{
    public class FlightSpecifications
    {
        [Fact]
        public void Booking_reduces_the_number_of_seats()
        {
            var flight = new Flight(seatCapacity: 3);

            flight.Book("aldair@azgcloudev.xyz", 1);
            flight.RemainingNumberOfSeats.Should().Be(2);

        }

        [Fact]
        public void Avoids_overbooking()
        {
            // GIVEN
            Flight flight = new Flight(3);

            // WHEN
            Action act = () => flight.Book("aldair@azgcloudev.xyz", 4);

            // THEN
            act.Should().Throw<OverBookingException>();
        }
    }
}