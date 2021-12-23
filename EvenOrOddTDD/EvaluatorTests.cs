using Xunit;

namespace EvenOrOddTDD
{
    public class EvaluatorTests
    {
        //[Fact]
        //public void Evaluate_ShouldReturnEven_When_EvenNumberPass()
        //{
        //    const int number = 4;

        //    var evaluator = new Evaluator();

        //    var actual =  evaluator.Evaluate(number);
        
        //    Assert.Equal("Even",actual);
        //}
        //[Fact]
        //public void Evaluate_ShouldReturnOdd_When_OddNumberPass()
        //{
        //    const int number = 5;

        //    var evaluator = new Evaluator();

        //    var actual = evaluator.Evaluate(number);

        //    Assert.Equal("Odd", actual);
        //}
        [Theory]
        [InlineData(4,"Even")]
        [InlineData(2,"Even")]
        [InlineData(5,"Odd")]
        [InlineData(7,"Odd")]
        public void Evaluate_ShouldReturnEvenOrOdd_WithProperAtGivenElements(int number,string expected)
        {
            var actual = Evaluator.Evaluate(number);

            Assert.Equal(expected, actual);
        }
    }
}
