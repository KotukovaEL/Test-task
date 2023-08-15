using FluentAssertions;
using System;
using Xunit;

namespace Task1_9.Tests
{
    public class LogicTests
    {
        [Fact]
        public void Should_find_sum_correctly()
        {
            var expectedArray = 15;
            var array = new[] { 1, 2, 3, 4, 5 };
            var sumNum = Logic.FindSum(array);
            Assert.Equal(sumNum, expectedArray);
        }
    }
}
