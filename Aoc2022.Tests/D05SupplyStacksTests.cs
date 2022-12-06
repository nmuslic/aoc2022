using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Aoc2022.Tests
{
    public class D05SupplyStacksTests
    {
        [Fact]
        public void GetTopCrates9000_SupplyStacksInput_ReturnsStacks()
        {
            string input = Resources.ResourceFiles.SupplyStacksInput;

            string result = D05SupplyStacks.GetTopCrates9000(input);

            Assert.Equal("SHQWSRBDL", result);
        }

        [Fact]
        public void GetTopCrates9001_SupplyStacksInput_ReturnsStacks()
        {
            string input = Resources.ResourceFiles.SupplyStacksInput;

            string result = D05SupplyStacks.GetTopCrates9001(input);

            Assert.Equal("CDTQZHBRS", result);
        }
    }
}
