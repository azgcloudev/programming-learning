DateTime dateTime = new DateTime(2002, 3, 4);

Console.WriteLine(dateTime);

//current day of today
Console.WriteLine("Today is: {0}", DateTime.Today);
Console.WriteLine(DateTime.Now); //current time in machine

// following day
DateTime tomorrow = GetTomorrow();
Console.WriteLine("Tomorrow is {0}.", tomorrow);

// First day of year
Console.WriteLine("First year of 1995 was {0}", GetFirstDayOfTheYear(1995));
Console.WriteLine($"Days in the month June from 1995 were {DateTime.DaysInMonth(1995, 6)}");

// display specific information
DateTime now = DateTime.Now;
Console.WriteLine($"Minute is {now.Minute}");
Console.WriteLine($"Time is {now.Hour} o'clock and {now.Minute} minutes and {now.Second}");

// substract days
Console.Write("Enter your birthday in the following format yyyy-mm-dd: ");
string birthInput = Console.ReadLine();
if (DateTime.TryParse(birthInput, out DateTime birthDateTime))
{
    Console.WriteLine(birthDateTime);
    TimeSpan daysPassed = now.Subtract(birthDateTime);
    Console.WriteLine($"Since your day of birth it has been {daysPassed.Days} days.");
}

Console.ReadLine();

static DateTime GetTomorrow()
{
    return DateTime.Today.AddDays(1);
}

static DateTime GetFirstDayOfTheYear(int year)
{
    return new DateTime(year, 1, 1);
}