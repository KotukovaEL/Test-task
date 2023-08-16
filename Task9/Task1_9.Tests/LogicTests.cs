using FluentAssertions;
using System;
using Xunit;

namespace Task1_9.Tests
{
    public class LogicTests
    {
        [Fact]
        public void Should_find_sum_correctly_when_all_numbers_positive()
        {
            var expectedSumNum = 15;
            var array = new[] { 1, 2, 3, 4, 5 };
            var sumNum = Logic.FindSumPositivNumbers(array);
            Assert.Equal(sumNum, expectedSumNum);
        }

        [Fact]
        public void Should_find_sum_correctly_when_some_numbers_negative()
        {
            var expectedSumNum = 8;
            var array = new[] { 1, -2, 3, 4, -5 };
            var sumNum = Logic.FindSumPositivNumbers(array);
            Assert.Equal(sumNum, expectedSumNum);
        }
    }
}
