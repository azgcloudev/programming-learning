namespace Exercise_PrimeFactorsLib;

public class PrimeFactorsClass
{
    public string PrimeFactors(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(number), number, "Number must be positive");
        }

        if (number > 1000)
        {
            throw new ArgumentOutOfRangeException(nameof(number), number, "Number must be less than or equal to 1000");
        }

        return PrimeFactorization(number);

    }

    private static string PrimeFactorization(int number)
    {
        List<int> factors = new List<int>();
        var primes =  Primes(number);
        var tempNumber = number;
        var index = 0;
        var isValid = true;

        while (isValid)
        {
            if (tempNumber == 1)
            {
                isValid = false;
            }
            
            if (number % primes[index] == 0)
            {
                var divN = number /= primes[0];
                factors.Add(divN);
                tempNumber = divN;
            }
            else
            {
                index++;
            }
        }
        
        return ConvertListToString(factors);
    }

    private static string ConvertListToString(List<int> factors)
    {
        var factorizationStr = string.Empty;
        
        foreach (var n in factors)
        {
            factorizationStr += $"{n} x";
        }

        return factorizationStr;
    }

    /// <summary>
    /// Create a list of prime numbers.
    /// </summary>
    /// <param name="max">Maximum number to generate prime numbers.</param>
    /// <returns>A list of prime numbers.</returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    private static List<int> Primes(int max)
    {
        if (max <= 1)
        {
            throw new ArgumentOutOfRangeException(nameof(max), max, "Max must be greater than 1");
        }
        
        var primes = new List<int>();
        
        for (int i = 2; i <= max; i++)
        {
            if (IsPrime(i))
            {
                primes.Add(i);
            }
        }
        
        return primes;
    }

    private static bool IsPrime(int number)
    {
        return Factorial(number) % number == 0;
    }

    private static int Factorial(int number)
    {
        return Factorial(number - 1);
    }
}