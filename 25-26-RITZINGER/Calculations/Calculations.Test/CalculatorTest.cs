using Calculations;

namespace Calculations.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void AddGivenland2Returns3()
        {
            //Arange
            var calculator = new Calculator();
            //Act
            var sum = calculator.Add(1, 2);
            //Assert
            Assert.Equal(3, sum);
        }

        [Fact]
        public void AddGivenTwoDecimalNumbersReturnsSum_FirsSet() //Decimális
        {
            var cal = new Calculator();
            var result = cal.Add(1.1m, 2.2m);
            Assert.Equal(3.3m, result);
        }

        [Fact]
        public void IsOddtest1()
        {
            var calc = new Calculator();
            var result = calc.IsOdd(15);
            Assert.True(result);
        }

        [Fact]

        public void GetFibonacciDoesNotInclude0()
        {
            var calculator = new Calculator();
            var fibo = calculator.GetFibonacci(5);
            Assert.All(fibo, n => Assert.NotEqual(0, n));
        }
    }
}