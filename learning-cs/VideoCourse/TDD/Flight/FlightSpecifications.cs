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
        public void Booking_reduces_the_number_of_seats_2()
        {
            var flight = new Flight(seatCapacity: 6);
        
            flight.Book("aldair@azgcloudev.xyz", 2);
            flight.RemainingNumberOfSeats.Should().Be(4);
        }
        
        [Fact]
        public void Avoids_overbooking()
        {
            // GIVEN
            var flight = new Flight(3);
        
            // WHEN
            var act = () => flight.Book("aldair@azgcloudev.xyz", 4);
        
            // THEN
            act.Should().Throw<OverBookingException>();
        }
        
        [Fact]
        public void Successfull_booking()
        {
            var flight = new Flight(3);
        
            flight.Book("aldair@azgcloudev.xyz", 2);
        
            flight.RemainingNumberOfSeats.Should().Be(1);
        }
        
        // PARAMETER TEST
        [Theory]
        [InlineData(3,1,2)]
        [InlineData(10,5,5)]
        [InlineData(245,100,145)]
        public void Booking_reduces_the_number_of_seats_3(int seatCapacity, int numberOfSeats, int remainingNumberOfSeats)
        {
            var flight = new Flight(seatCapacity: seatCapacity);
        
            flight.Book("aldair@azgcloudev.xyz", numberOfSeats);
            flight.RemainingNumberOfSeats.Should().Be(remainingNumberOfSeats);
        }
        
        [Fact]
        public void Remember_bookings()
        {
            var flight = new Flight(150);
            
            flight.Book("a@me.com", 4);
            /*
            flight.BookingList.Should().Contain(new Booking("a@me.com", 4)); // contain checks for the refence type
            // because contain creates a new object and reference will be different
            */
            
            // correct way to check
            flight.BookingList.Should().ContainEquivalentOf(new Booking("a@me.com", 4));

        }
    }
}