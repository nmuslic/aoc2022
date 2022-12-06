using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Aoc2022.Tests
{
    public class D06TuningTroubleTests
    {
        [InlineData(4, 1142)]
        [InlineData(14, 2803)]
        [Theory]
        public void D61GetTop3CaloriesElf_CaloriesCountingInput_ReturnsTop3Calories(int packetLength, int expectedResult)
        {
            string input = Resources.ResourceFiles.TuningTroubleInput;

            int result = D06TuningTrouble.GetStartOfPacketMarker(input, packetLength);

            Assert.Equal(expectedResult, result);
        }
    }
}
