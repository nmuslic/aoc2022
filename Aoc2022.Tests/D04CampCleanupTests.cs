using Xunit;

namespace Aoc2022.Tests
{
    public class D04CampCleanupTests
    {
        [Fact]
        public void GetOverlapedPairs_CampCleanupInput_ReturnsOverlapedPairs()
        {
            string input = Resources.ResourceFiles.CampCleanupInput;

            int result = D04CampCleanup.GetOverlapedPairs(input);

            Assert.Equal(518, result);
        }

        [Fact]
        public void GetAllOverlapedSections_CampCleanupInput_ReturnsOverlapedSections()
        {
            string input = Resources.ResourceFiles.CampCleanupInput;

            int result = D04CampCleanup.GetAllOverlapedSections(input);

            Assert.Equal(909, result);
        }
    }
}
