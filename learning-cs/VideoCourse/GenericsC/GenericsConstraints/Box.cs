namespace GenericsConstraints
{
    // allow on;ly the Box class to create instances when the Type is only a class
    public class Box<T> where T : class
    {
    }
}