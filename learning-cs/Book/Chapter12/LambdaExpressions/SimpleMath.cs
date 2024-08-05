namespace LambdaExpressions;

public class SimpleMath
{
    public delegate void MathMessage(string message, int result);

    private MathMessage _mmDelegate;

    public void SetMathHandler(MathMessage target)
    {
        _mmDelegate = target;
    }

    public void Add(int x, int y)
    {
        _mmDelegate?.Invoke("Adding has completed!", x + y);
    }

    // lambda and expression bodie members
    public int AddTwoNumbers(int x, int y) => x + y;
    public void PrintSum(int x, int y) => Console.WriteLine(x + y);

}