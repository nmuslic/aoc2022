using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Aoc2022.Tests
{
    public class D07NoSpaceLeftOnDeviceTests
    {
        [Fact]
        public void GetSize_NoSizeLeftOnDeviceInput_ReturnsSize()
        {
            string input = Resources.ResourceFiles.NoSizeLeftOnDeviceInput;

            var result = D07NoSpaceLeftOnDevice.GetSize(input);

            Assert.Equal(1086293, result);
        }

        [Fact]
        public void GetSize_NoSizeLeftOnDeviceInput_ReturnsDeletedFolderSize()
        {
            string input = Resources.ResourceFiles.NoSizeLeftOnDeviceInput;

            var result = D07NoSpaceLeftOnDevice.GetDeletedFolderSize(input);

            Assert.Equal(366028, result);
        }
    }
}
