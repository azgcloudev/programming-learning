using Domain;
using FluentAssertions;

namespace FlightTest
{
    public class FlightSpecifications
    {

        [Fact]
        public void Successfull_booking()
        {
            var flight = new Flight(3);
        
            flight.Book("aldair@azgcloudev.xyz", 2);
        
            flight.RemainingNumberOfSeats.Should().Be(1);
        }
    }
}