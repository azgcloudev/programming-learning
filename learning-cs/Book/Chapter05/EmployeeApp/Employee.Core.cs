namespace EmployeeApp;

public partial class Employee
{
    // field members
    private string _empName;
    private int _empId;
    private float _pay;
    private int _empAge;
    private string _empSSN;
    private EmployeeTypeEnum _payType;
    private DateTime _hireDate;
    
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

    public float Pay
    {
        get { return _pay; }
        set { _pay = value; }
    }

    // using expression bodie members
    public int Age
    {
        get => _empAge;
        set => _empAge = value;
    }

    public string SocialSecurityNumber
    {
        get { return _empSSN; }
        private set { _empSSN = value; }
    }

    public EmployeeTypeEnum PayType
    {
        get { return _payType; }
        set { _payType = value; }
    }

    public DateTime HireDate
    {
        get { return _hireDate; }
        set { _hireDate = value; }
    }

    
    // constructors
    public Employee()
    {
    }

    public Employee(string name, int id, float pay, string empSsn) : this(name, 0, id, pay, empSsn, EmployeeTypeEnum.Salaried)
    {
    }

    public Employee(string empName, int age, int empId, float pay, string empSsn, EmployeeTypeEnum payType)
    {
        Name = empName;
        Id = empId;
        Pay = pay;
        Age = age;
    }
}