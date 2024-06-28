using Domain;
using FluentAssertions;
using Domain.BookingErrors;

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

        [Theory]
        [InlineData(3,1,1,3)]
        [InlineData(100,3,3,100)]
        public void Cancelling_bookings_frees_up_the_seats(int seatCapacity, int numberOfSeats,int seatsToCancel, int remainingSeats)
        {
            // given
            var flight = new Flight(seatCapacity);
            flight.Book("a@b.com",numberOfSeats);

            // when
            flight.CancelBooking("a@b.com", seatsToCancel);
            
            // then
            flight.RemainingNumberOfSeats.Should().Be(remainingSeats);

        }

        [Fact]
        public void Doesnt_cancel_booking_for_passenger_who_have_not_book()
        {
            var flight = new Flight(20);
            
            var error = flight.CancelBooking("a@b.com", 3);

            error.Should().BeOfType<BookingNotFoundError>();
        }

        [Fact]
        public void Returns_null_when_booking_cancelled()
        {
            var flight = new Flight(30);
            flight.Book("a@b.com", 4);
            var error = flight.CancelBooking("a@b.com", 4);

            error.Should().BeNull();
        }
    }
}