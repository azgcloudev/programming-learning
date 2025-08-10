using System.Globalization;

partial class Program
{
    static void TimesTable(byte number, byte size = 12)
    {
        WriteLine($"This is the {number} times table with {size} rows");
        WriteLine();

        for (int rows = 1; rows <= size; rows++)
        {
            WriteLine($"{rows} x {number} = {rows * number}");
        }
        WriteLine();
    }

    static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
    {
        decimal rate = twoLetterRegionCode switch
        {
            "CH" => 0.08M, // Switzerland
            "DK" or "NO" => 0.25M, // Denmark, Norway
            "GB" or "FR" => 0.2M,
            "HU" => 0.27M,
            "OR" or "AK" or "MT" => 0.0M,
            "ND" or "WI" or "ME" or "VA" => 0.05M,
            "CA" => 0.0825M,
            _ => 0.06M,
        };
        return rate * amount;
    }

    static void ConfigureConsole(string culture = "fr-FR", bool useComputerCulture = true)
    {
        OutputEncoding = System.Text.Encoding.UTF8;

        if (useComputerCulture)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
        }
        WriteLine($"CurrentCulture: {CultureInfo.CurrentCulture.DisplayName}");
    }

    static string CardinalToOrdinal(uint number)
    {
        uint lastTwoDigits = number % 100;

        switch (lastTwoDigits)
        {
            case 11:
            case 12:
            case 13:
                return $"{number:N0}th";
            default:
                uint lastDigit = number % 10;
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

    static void RunCardinalToOrdinal()
    {
        for (uint number = 1; number <= 150; number++)
        {
            Write($"{CardinalToOrdinal(number)} ");
        }
        WriteLine();
    }

    static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException(
                message: $"The factorial functions is defined only for non-negative numbers. Input: {number}",
                paramName: nameof(number));
        }
        else if (number == 0)
        {
            return 1;
        }
        
        return number * Factorial(number - 1);
    }

    static void RunFactorial()
    {
        for (int i = 1; i <= 15; i++)
        {
            WriteLine($"{i}! = {Factorial(i):N0}");
        }
    }
}