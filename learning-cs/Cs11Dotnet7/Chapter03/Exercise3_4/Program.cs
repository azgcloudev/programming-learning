//Create a console app in Chapter03 named Ch03Ex04Exceptions that asks the user for two numbers
//in the range 0-255 and then divides the first number by the second:
//Write exception handlers to catch any thrown errors

try
{

    Console.Write("Enter a number between 0 and 255: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Enter another number between 0 and 255: ");
    double num2 = double.Parse(Console.ReadLine());

    double result = num1 / num2;
    Console.WriteLine("{0} divided by {1} is {2}.", num1, num2, result);
}
catch (FormatException)
{
    Console.WriteLine("FormatException: Input string is not a number.");
}
catch (Exception ex)
{
    Console.WriteLine("{0}: {1}", ex.GetType(), ex.Message);
}