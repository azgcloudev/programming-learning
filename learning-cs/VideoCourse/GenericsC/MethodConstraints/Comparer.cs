namespace MethodConstraints;

public class Comparer
{
    /// <summary>
    /// Compares if two objects have the same referece.
    /// </summary>
    /// <param name="first"></param>
    /// <param name="second"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns>Returns a boolean if the two objects are equal.</returns>
    public static bool AreEqual<T>(T first, T second) where T : class
    {
        return first == second;
    }
}