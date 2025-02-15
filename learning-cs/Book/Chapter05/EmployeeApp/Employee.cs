namespace EmployeeApp;

public class Employee
{
    // field members
    private string _empName;
    private int _empId;
    private float _currPay;
    private int _empAge;

    // get and set using properties
    public string Name
    {
        get { return _empName; }
        set
        {
            if (value.Length > 15)
            {
                Console.WriteLine("Error, Name length exceeds 15 characters.");
            }
            else
            {
                _empName = value;
            }
        }
    }

    public int Id
    {
        get { return _empId; }
        set { _empId = value; }
    }

    public float CurrPay
    {
        get { return _currPay; }
        set { _currPay = value; }
    }

    public int Age
    {
        get { return _empAge; }
        set { _empAge = value; }
    }

    // constructors
    public Employee()
    {
    }

    public Employee(string name, int id, float currPay) : this(name, 0, id, currPay)
    {
    }

    public Employee(string empName, int age, int empId, float currPay)
    {
        _empName = empName;
        _empId = empId;
        _currPay = currPay;
        _empAge = age;
    }

    // methods
    public void GiveBonus(float amount) =>
        _currPay += amount;

    public void DisplayStats()
    {
        Console.WriteLine("Name: {0}", _empName);
        Console.WriteLine("ID: {0}", _empId);
        Console.WriteLine("Pat: {0}", _currPay);
    }
}