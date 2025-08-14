namespace CalculatorLibUnitTests;

using CalculatorLib;

public class CalculatorUnitTests
{
    [Fact]
    public void TestAdding2and2()
    {
        // ARRANGE
        double a = 2;
        double b = 2;
        double expected = 4;
        Calculator calc = new();
        
        // ACT
        double actual = calc.Add(a, b);

        // ASSERT   
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestAdding2and3()
    {
        double a = 2;
        double b = 3;
        double expected = 5;
        Calculator calc = new();
        
        double actual = calc.Add(a, b);
        
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(2,2,4)]
    [InlineData(2,3,5)]
    public void TestAdding(double a, double b, double expected)
    {
        Calculator calc = new();
        
        double actual = calc.Add(a, b);
        
        Assert.Equal(expected, actual);
    }
}