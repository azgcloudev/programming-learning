namespace Domain
{
    public class Flight
    {
        private List<Booking> bookingList = new();
        public IEnumerable<Booking> BookingList => bookingList;
        
        public int RemainingNumberOfSeats { get; set; }

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
    }
}
