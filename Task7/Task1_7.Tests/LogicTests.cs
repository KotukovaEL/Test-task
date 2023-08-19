using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace Task1_7.Tests
{
    public class LogicTests
    {
        [Fact]
        public void Should_sorting_numbers_correctly()
        {
            var expectedArray = new int[]{ 1, 2, 5, 10, 11, 33, 50 };
            var array = new int[] { 5, 2, 10, 1, 50, 33, 11 };
            var lowInd = 3;
            var highInd = 4;
            Logic.Sort(array, lowInd, highInd);
            //Assert.Equal(expectedArray, actualArray);
            array.Should().BeEquivalentTo(expectedArray);
        }

        [Fact]
        public void Should_find_max_number_correctly()
        {
            var expectedMaxNum = 70;
            var actualArray = new[] { 10, 15, 14, 12, 55, 70 };
            var result = Logic.FindMax(actualArray);
            Assert.Equal(expectedMaxNum, result);
        }

        [Fact]
        public void Should_find_min_number_correctly()
        {
            var expectedMinNum = 10;
            var actualArray = new[] { 10, 15, 14, 12, 55, 70 };
            var result = Logic.FindMin(actualArray);
            Assert.Equal(expectedMinNum, result);
        }
    }
}
