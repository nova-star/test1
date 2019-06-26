using System;
using Xunit;
using ConsoleApp2;
using Microsoft.Extensions.DependencyModel;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace ConsoleApp2.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestLibFunctions()
        {
            var res = ConsoleApp2.Lib.Add(10, 40);
            Assert.Equal(50, res);

        }
    }
}