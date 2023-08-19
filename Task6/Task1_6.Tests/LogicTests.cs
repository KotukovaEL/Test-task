using System;
using Xunit;



namespace Task1_6.Tests
{
    public class LogicTests
    {
        [Theory]
        [InlineData("Bold", DisplayType.Bold)]
        [InlineData("Italic", DisplayType.Italic)]
        [InlineData("Underline", DisplayType.Underline)]
        public void Should_read_correct_DisplayType(string value, DisplayType expectedType)
        {
            var boolResult = Logic.TryReadType(value, out DisplayType actualType);
            Assert.True(boolResult);
            Assert.Equal(expectedType, actualType);
        }

        [Theory]
        [InlineData("fdg")]
        [InlineData("Italdfadsic")]
        [InlineData("sfd")]
        public void Should_not_read_incorrect_DisplayType(string value)
        {
            var boolResult = Logic.TryReadType(value, out DisplayType actualType);
            Assert.False(boolResult);
        }
    }
}
