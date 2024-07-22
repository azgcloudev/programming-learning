namespace NamingConventions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variable names
            string studentName = "John"; // camelCase
            CustomerService cx1 = new CustomerService();
            cx1.GetCustomerById(1);
        }

        // for classes use NOUNS
        class OrderProcessor()
        {
            // booleans convetions, prepend with 'has' or 'is'
            public bool HasOptIn { get; set; }
            public bool IsOverAge { get; set; }

            // for methods use VERBS
            public void PrintOrder()
            {

            }

            public void ProcessOrder()
            {

            }
        }
    }
}
