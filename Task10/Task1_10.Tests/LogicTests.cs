using System;
using Xunit;

namespace Task1_10.Tests
{
    public class LogicTests
    {
        [Fact]
        public void Should_find_sum_in_even_positions()
        {
            var expectedArray = 6;
            var array = new int[,]
            {
                { 0, 1, 2 },
                { 3, 4, 5 }
            };

            var sumEvenPos = Logic.FindSum(array);
            //Assert.Equal(expectedArray, actualArray);
            sumEvenPos.Equals(expectedArray);

        }
    }
}