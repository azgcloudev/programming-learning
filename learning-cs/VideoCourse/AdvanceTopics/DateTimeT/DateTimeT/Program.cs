DateTime dateTime = new DateTime(2002, 3, 4);

Console.WriteLine(dateTime);

//current day of today
Console.WriteLine("Today is: {0}", DateTime.Today);
Console.WriteLine(DateTime.Now); //current time in machine

// following day
DateTime tomorrow = GetTomorrow();
Console.WriteLine("Tomorrow is {0}.", tomorrow);


static DateTime GetTomorrow()
{
    return DateTime.Today.AddDays(1);
}