using Domain;
using FluentAssertions;

namespace CalculatorTest
{
    public class CalculatorTest
    {
        //[Fact]
        //public void Sum_of_2_and_2_should_be_4()
        //{
        //    Calculator calculator = new Calculator();
        //    int result = calculator.Sum(2, 2);

        //    //if (result != 4)
        //    //{
        //    //    throw new Exception($"Sum(2,2) should be 4 and result was {result}");
        //    //}

        //    // fluent assertion package helps to remove the if statement
        //    result.Should().Be(2);
        //}

        // ANOTHER WAY FOR WRITTING THE PREVIOUS METHOD
        [Fact]
        public void Sum_of_2_and_2_should_be_4() =>
            new Calculator()
                .Sum(2, 2)
                .Should().Be(4);
    }
}