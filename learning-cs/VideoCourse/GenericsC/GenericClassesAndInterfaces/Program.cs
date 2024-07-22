namespace GenericClassesAndInterfaces;

class Program
{
    static void Main(string[] args)
    {
        Repository<Product> car = new Repository<Product>();
        car.Add(new Product());
    }
}

internal class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
}

internal interface IRepository<T>
{
    void Add(T entity);
    void Remove(T entity);
}
    
// new class that combines interfaces with Generic so it is not attached only to the Product class
// and can be use by different classes
internal class Repository<T> : IRepository<T>
{
    public void Add(T entity)
    {
        throw new NotImplementedException();
    }

    public void Remove(T entity)
    {
        throw new NotImplementedException();
    }
}