using System;
using Xunit;
using Utils;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var inputString = "Dotnet-bot: Welcome to using .NET Core!";
            var expectedString = "!eroC TEN. gnisu ot emocleW :tob-tentoD";
            var actualString = ReverseUtil.ReverseString(inputString);
            Assert.True(actualString == expectedString, "The input string was not reversed correctly.");
        }
    }
}
