
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

    /// <summary>
    /// Pass a 32-bit integer and it will be converted into its ordinal equivalent.
    /// </summary>
    /// <param name="number">Number as a cardinal value e.g. 1, 2, 3, and so on.</param>
    /// <returns>Number as an ordinal value e.g 1st, 2nd, 3rd, and so on.</returns>
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

    static int FibImperative(int term)
    {
        if (term == 1)
        {
            return 0;
        }
        else if (term == 2)
        {
            return 1;
        }
        else
        {
            return FibImperative(term - 1) + FibImperative(term - 2);
        }
    }

    static void RunFibImperative()
    {
        WriteLine("Fibonacci imperative:");
        for (int i = 1; i <= 30; i++)
        {
            WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
                CardinalToOrdinal(i),
                FibImperative(i));
        }
    }

    static int FibFunctional(int term) =>
        term switch
        {
            1 => 0,
            2 => 1,
            _ => FibFunctional(term - 1) + FibFunctional(term - 2)
        };

    static void RunFibFunctional()
    {
        WriteLine("Fibonacci functional:");
        for (int i = 1; i < 30; i++)
        {
            WriteLine($"The {CardinalToOrdinal(i)} term of the Fibonacci sequence is {FibFunctional(i):N0}.");
        }
    }
}