using Xunit;

namespace FizzBuzz
{
    public class FizzBuzzTests
    {
        private const string fizz = "Fizz";
        private const string buzz = "Buzz";

        [Fact]
        public void Start_ShouldReturnAListWithGivenRoundLength()
        {
            const int rounds = 444;

            var actual = FizzBuzz.Start(rounds);

            Assert.Equal(rounds, actual.Count);
        }
        
        [Theory]
        [InlineData(444,fizz,2)]
        [InlineData(444,fizz,8)]
        [InlineData(444,buzz,4)]
        [InlineData(444,buzz,9)]
        [InlineData(444,fizz+buzz,14)]
        [InlineData(444,fizz+buzz,29)]
        public void Start_ShouldReturnAListWithProperAtGivenElements(int rounds,string expected,int index)
        {
            var actual = FizzBuzz.Start(rounds);

            Assert.Equal(expected, actual[index]);
        }
    }
}
