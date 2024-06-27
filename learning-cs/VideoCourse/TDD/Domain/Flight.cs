namespace Domain
{
    public class Flight
    {
        public int RemainingNumberOfSeats { get; set; }
        public List<Booking> BookingList { get; set; } = new List<Booking>();

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

            BookingList.Add(booking);
            
            RemainingNumberOfSeats -= numberOfSeats;
        }
    }
}
