using System;
using Xunit;
using ConsoleApp2;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace ConsoleApp2.Tests
{
    public class ProgramTest
    {
        [Fact]
        public void TestLibFunctions()
        {
            var res = ConsoleApp2.Lib.Add(10, 40);
            Assert.Equal(505, res);
        }
    }
}
