namespace CustomInterfaceConstraint
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository<Product> repository = new Repository<Product>();
            var product = new Product();
            repository.Add(product);
        }
    }
}