using Xunit;

namespace EvenOrOdd
{
    public class EvaluatorTests
    {
        [Fact]
        public void Evaluate_Should_Return_Even()
        {
            const int number = 4;
            var evaluator = new Evaluator();
            var actual = evaluator.Evaluate(number);
            Assert.Equal("Even",actual);
        }
        [Fact]
        public void Evaluate_Should_Return_Odd()
        {
            const int number = 3;
            var evaluator = new Evaluator();
            var actual = evaluator.Evaluate(number);
            Assert.Equal("Odd", actual);
        }
    }
}
