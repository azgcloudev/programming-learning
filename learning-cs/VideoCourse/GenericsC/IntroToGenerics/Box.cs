namespace IntroToGenerics
{
    // creating a Generic class
    public class Box<T>
    {
        // Content will get the type 
        public T? Content { get; set; }

        public string Log()
    {
        return $"Box contains {Content}";
    }
    }
}