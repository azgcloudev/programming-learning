namespace Exercise_PrimeFactorsTest;

using Exercise_PrimeFactorsLib;

public class PrimeFactorsClassTest
{
    [Theory]
    [InlineData(40, "2 x 2 x 2 x 5")]
    [InlineData(4, "2 x 2")]
    [InlineData(7, "7")]
    [InlineData(30, "2 x 3 x 5")]
    [InlineData(50, "2 x 5 x 5")]
    public void PrimeFactorsTest(int number, string expected)
    {
        // arrange
        PrimeFactorsClass pfc = new();

        // act
        var result = pfc.PrimeFactors(number);

        //assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(0)]
    [InlineData(-10)]
    public void IsNumber1OrLess_ThrowsArgumentOutOfRangeException(int number)
    {
        // arrange
        var pfc = new PrimeFactorsClass();
        
        // assert
        Assert.Throws<ArgumentOutOfRangeException>(() => pfc.PrimeFactors(number));
    }
}