using Xunit;

namespace Aoc2022.Tests
{
    public class D01CalorieCountingTests
    {
        [Fact]
        public void GetTopCaloriesElf_CaloriesCountingInput_ReturnsTopCalories()
        {
            string input = Resources.ResourceFiles.CaloriesCountingInput;

            int result = Day01CalorieCounting.GetTopCaloriesElf(input);

            Assert.Equal(68787, result);
        }

        [Fact]
        public void GetTop3CaloriesElf_CaloriesCountingInput_ReturnsTop3Calories()
        {
            string input = Resources.ResourceFiles.CaloriesCountingInput;

            int result = Day01CalorieCounting.GetTop3CaloriesElf(input);

            Assert.Equal(198041, result);
        }
    }
}