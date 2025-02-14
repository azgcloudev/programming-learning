namespace StaticDataAndMembers;

public class SavingsAccount
{
    public static double currInterestRate;
    
    public double currBalance;

    public SavingsAccount(double balance)
    {
        currBalance = balance;
    }
    
    // static constructor
    static SavingsAccount()
    {
        Console.WriteLine("Static constructor");
        currInterestRate = 0.05;
    }
    
    public static void SetInterestRate(double interestRate) 
        => currInterestRate = interestRate;
    
    public static double GetInterestRate() 
        => currInterestRate;
}