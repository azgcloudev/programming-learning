namespace Exercise_PrimeFactorsTest;

using Exercise_PrimeFactorsLib;

public class UnitTest1
{
    [Fact]
    public void PrimeFactorsTest()
    {
        // arrange
        int number = 40;
        string expected = "2 x 2 x 5";
        PrimeFactorsClass pfc = new();

        // act
        var result = pfc.PrimeFactors(number);

        //assert
        Assert.Equal(expected, result);
    }
}