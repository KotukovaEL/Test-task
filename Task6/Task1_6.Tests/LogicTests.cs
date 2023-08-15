using System;
using Xunit;


namespace Task1_6.Tests
{
    public class LogicTests
    {
        [Theory]
        [InlineData("Bold", DisplayType.Bold)]
        public void Should_read_correct_DisplayType(string value, string displayType)
        {
            var boolResult = Logic.TryReadType(value, out var type);
            Assert.True(boolResult);
            Assert.Equal(displayType, type);
        }       
    }
}
