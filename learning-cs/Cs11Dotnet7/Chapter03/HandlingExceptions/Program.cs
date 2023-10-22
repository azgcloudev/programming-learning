namespace HandlingExceptions;

class Program
{
    static void Main(string[] args)
    {
        WriteLine("Before parsing");
        Write("What is your age? ");
        string? input = ReadLine();

        try
        {
            int age = int.Parse(input!);
            WriteLine("Your age is {0}", age);
        }
        // specific format exception
        catch (FormatException)
        {
            WriteLine("The age you entered is not a valid number format.");
        }
        catch (OverflowException)
        {
            WriteLine("Age is a valid format but is either to big or too small for type.");
        }
        catch (Exception ex)
        {
            WriteLine("{0} says {1}", ex.GetType(), ex.Message);
        }
        WriteLine("After parsing");

        WriteLine();

        // catching with filters
        WriteLine("=== Catching with filters ===");
        Write("Enter amount: ");
        string amount = ReadLine()!;
        if (string.IsNullOrEmpty(amount))
        {
            return;
        }

        try
        {
            decimal amountValue = decimal.Parse(amount);
            WriteLine("Amount formatted as currency {0:C}", amountValue);
        }
        catch (FormatException) when (amount.Contains("$"))
        {
            WriteLine("Amounts cannot use the dollar sign.");
        }
        catch (FormatException)
        {
            WriteLine("Amounts must only contains digits.");
        }
    }
}

