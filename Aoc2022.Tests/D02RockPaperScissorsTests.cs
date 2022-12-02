using Xunit;

namespace Aoc2022.Tests
{
    public class D02RockPaperScissorsTests
    {
        [Fact]
        public void GetMostWins_RockPaperScissorsInput_ReturnsMostWins()
        {
            string input = Resources.ResourceFiles.RockPaperScissorsInput;

            int result = D02RockPaperScissors.GetMostWins(input);

            Assert.Equal(13268, result);
        }

        [Fact]
        public void GetMostStrategyWins_RockPaperScissorsInput_ReturnsMostWins()
        {
            string input = Resources.ResourceFiles.RockPaperScissorsInput;

            int result = D02RockPaperScissors.GetMostStrategyWins(input);

            Assert.Equal(15508, result);
        }
    }
}
