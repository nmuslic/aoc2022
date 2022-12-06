using Xunit;

namespace Aoc2022.Tests
{
    public class D03RucksackReorganizationTests
    {
        [Fact]
        public void GetMostStrategyWins_RucksackReorganizationInput_ReturnsSumOfPairs()
        {
            string input = Resources.ResourceFiles.RucksackReorganizationInput;

            int result = D03RucksackReorganization.GetSumOfPairs(input);

            Assert.Equal(8123, result);
        }

        [Fact]
        public void GetSumOfThrees_RucksackReorganizationInput_ReturnsSumOfThrees()
        {
            string input = Resources.ResourceFiles.RucksackReorganizationInput;

            int result = D03RucksackReorganization.GetSumOfThrees(input);

            Assert.Equal(2620, result);
        }
    }
}
