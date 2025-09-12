namespace Exercise_PrimeFactorsLib;

public class PrimeFactorsClass
{
    public string PrimeFactors(int number)
    {
        if (number <= 1)
        {
            throw new ArgumentOutOfRangeException(nameof(number),number, "Number must be greater than 1");
        }

        var divNumber = 2;
        var newNumber = number;
        string result = string.Empty;
        
        while (newNumber > 1)
        {
            if (IsModuloZero(newNumber, divNumber))
            {
                newNumber /= divNumber;
                result += $"{divNumber} x ";
            }
            else
            {
                divNumber++;
            }
        }

        return RemoveLastX(result);
    }
    
    /// <summary>
    ///  Check if a number is modulo zero with another number.
    /// </summary>
    /// <param name="number">Number to divide.</param>
    /// <param name="index">Modulo number.</param>
    /// <returns>True if result is 0, false if not 0.</returns>
    private bool IsModuloZero(int number, int index)
    {
        return number % index == 0;
    }
    
    /// <summary>
    /// Remove the last " x " from a string if it exists.
    /// </summary>
    /// <param name="input">String to analyze.</param>
    /// <returns>New string without the last x if exist, and if it doesn't return the original string.</returns>
    private string RemoveLastX(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }
        
        return input.EndsWith(" x ") ? input[..^3] : input;
    }
}