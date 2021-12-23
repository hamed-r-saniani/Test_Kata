using Xunit;

namespace FizzBuzzTDD
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Start_ShouldReturnAList_WithGivenRoundsLength()
        {
            const int count = 444;

            var actual = FizzBuzz.Start(count);

            Assert.Equal(count, actual.Count);
        }
        //[Fact]
        //public void Start_ShouldReturnProperValueAtExpectedIndex_WhenNumberIsDividablrTo3()
        //{
        //    const int count = 444;
        //    const int index = 2;

        //    var actual = FizzBuzz.Start(count);

        //    Assert.Equal("Fizz", actual[index]);
        //}
        //[Fact]
        //public void Start_ShouldReturnProperValueAtExpectedIndex_WhenNumberIsDividablrTo5()
        //{
        //    const int count = 444;
        //    const int index = 4;

        //    var actual = FizzBuzz.Start(count);

        //    Assert.Equal("Buzz", actual[index]);
        //}
        //[Fact]
        //public void Start_ShouldReturnProperValueAtExpectedIndex_WhenNumberIsDividablrTo15()
        //{
        //    const int count = 444;
        //    const int index = 14;

        //    var actual = FizzBuzz.Start(count);

        //    Assert.Equal("FizzBuzz", actual[index]);
        //}
        [Theory]
        [InlineData(2, "Fizz")]
        [InlineData(4, "Buzz")]
        [InlineData(14, "FizzBuzz")]
        public void Start_ShouldReturnAListWithProperAtGivenElements(int index, string expected)
        {
            const int count = 444;

            var actual = FizzBuzz.Start(count);

            Assert.Equal(expected, actual[index]);
        }
    }
}
