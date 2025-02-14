namespace StaticDataAndMembers;

public class SavingsAccount
{
    public static double currInterestRate = 0.04;
    
    public double currBalance;

    public SavingsAccount(double balance)
    {
        currBalance = balance;
    }
}