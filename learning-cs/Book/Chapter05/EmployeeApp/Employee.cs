namespace EmployeeApp;

public partial class Employee
{
    // methods
    public void GiveBonus(float amount)
    {
        Pay = this switch
        {
            // property nesting matching
            { Age: >= 18, PayType: EmployeeTypeEnum.Commission, HireDate: {Year: > 2020 }} => Pay += .10F * amount,
            { Age: >= 18, PayType: EmployeeTypeEnum.Hourly, HireDate: {Year: > 2020 }} => Pay += 40 * amount / 2080F,
            { Age: >= 18,  PayType: EmployeeTypeEnum.Salaried, HireDate: {Year: > 2020 }} => Pay += amount,
            _ => Pay += 0,
        };
    }
    
    public void DisplayStats()  
    {
        Console.WriteLine("Name: {0}", _empName);
        Console.WriteLine("ID: {0}", _empId);
        Console.WriteLine("Age: {0}", _empAge);
        Console.WriteLine("Pat: {0}", _pay);
    }
}