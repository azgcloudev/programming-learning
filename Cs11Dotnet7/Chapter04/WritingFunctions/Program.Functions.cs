
partial class Program
{
    static void TimesTable(byte number, byte size = 12)
    {
        WriteLine("This is the {0} times table with {1} rows:", number, size);
        for (int row = 1; row <= size; row++)
        {
            WriteLine("{0} x {1} = {2}", row, number, row * number);
        }
        WriteLine();
    }

    static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
    {
        decimal rate = 0.0M;

        switch (twoLetterRegionCode)
        {
            case "CH":
                rate = 0.08M;
                break;
            case "DK":
            case "NO":
                rate = 0.25M;
                break;
            case "GB":
            case "FR":
                rate = 0.2M;
                break;
            case "OR":
            case "AK":
            case "MT":
                rate = 0.0M;
                break;
            case "ND": // North Dakota
            case "WI": // Wisconsin
            case "ME": // Maine
            case "VA": // Virginia
                rate = 0.05M;
                break;
            case "CA": // California
                rate = 0.0825M;
                break;
            default: // most US states
                rate = 0.06M;
                break;
        }
        return amount * rate;

    }

    static string CardinalToOrdinal(int number)
    {
        int lastTwoDigits = number % 100;

        switch (lastTwoDigits)
        {
            case 11:
            case 12:
            case 13:
                return $"{number:N0}th";
            default:
                int lastDigit = number % 10;

                string suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };

                return $"{number:N0}{suffix}";
        }
    }

    static void RunCardinaltoOrdinal()
    {
        for (int number = 0; number < 150; number++)
        {
            Write($"{CardinalToOrdinal(number)} ");
        }
    }

    // Factorial of a number
    static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException(message: $"The factorial function is defined for non-negative integers only. Input {number}",
                paramName: nameof(number));
        }
        else if (number == 0)
        {
            return 1;
        }
        else
        {
            checked
            {
                return number * Factorial(number - 1);
            }
        }
    }

    static void RunFactorial()
    {
        for (int number = -2; number <= 15; number++)
        {
            try
            {
                WriteLine($"{number}! = {Factorial(number):N0}");
            }
            catch (OverflowException)
            {
                WriteLine($"{number}! is too big for a 32-bit integer.");
            }
            catch (Exception ex)
            {
                WriteLine($"{number}! throw {ex.GetType()}: {ex.Message}");
            }
        }
    }
}