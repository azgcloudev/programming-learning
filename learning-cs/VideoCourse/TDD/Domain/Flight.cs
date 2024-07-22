using Domain.BookingErrors;

namespace Domain
{
    public class Flight
    {
        public Guid Id { get; }

        private List<Booking> bookingList = new();
        public IEnumerable<Booking> BookingList => bookingList;
        
        public int RemainingNumberOfSeats { get; set; }

        [Obsolete("Needed by EF")]
        Flight()
        {
        }

        public Flight(int seatCapacity)
        {
            RemainingNumberOfSeats = seatCapacity;
        }

        public void Book(string passengerEmail, int numberOfSeats)
        {
            // Check first for overbooking
            if (numberOfSeats > RemainingNumberOfSeats)
            {
                throw new OverBookingException();
            }

            var booking = new Booking(passengerEmail, numberOfSeats);

            bookingList.Add(booking);
            
            RemainingNumberOfSeats -= numberOfSeats;
        }

        public object? CancelBooking(string passengerEmail, int cancelledSeats)
        {
            if (bookingList.All(booking => booking.Email != passengerEmail))
            {
                return new BookingNotFoundError();
            }
            
            RemainingNumberOfSeats += cancelledSeats;

            return null;
        }
    }
}
