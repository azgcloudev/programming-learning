using Domain;

namespace CalculatorTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var calculator = new Calculator();

            if (calculator.Sum(1, 2) != 3)
            {
                throw new SystemException();
            }
        }
    }
}