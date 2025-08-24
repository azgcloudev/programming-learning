namespace Exercise_PrimeFactorsLib;

public static class PrimeFactorsClass
{
    public static string PrimeFactors(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(number), number, "Number must be positive");
        }

        if (number > 1000)
        {
            throw new ArgumentOutOfRangeException(nameof(number), number, "Number must be less than or equal to 1000");
        }

    }

    private statiic int PrimeFactorization(int number)
    {
        List<int> factors = new List<int>();
        var primes =  Primes(number);
        var index = 0;
    }

    private static List<int> Primes(int max)
    {
        if (max <= 1)
        {
            throw new ArgumentOutOfRangeException(nameof(max), max, "Max must be greater than 1");
        }
        
        var primes = new List<int>();
        
        for (int i = 2; i <= max; i++)
        {x
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