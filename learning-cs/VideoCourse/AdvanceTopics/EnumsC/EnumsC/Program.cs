namespace EnumsC
{
    enum Months { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };
    // by default start with 0
    // we can set the int value of the first element
    // any other element can be change its number and the next ones will start from that last value

    internal class Program
    {
        static void Main(string[] args)
        {
            // ENUMS
            Months June = Months.Jun;
            Console.WriteLine($"My month of birth us {June}, month number {(int)June}.");
        }
    }
}
