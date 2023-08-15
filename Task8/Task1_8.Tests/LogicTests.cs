using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace Task1_8.Tests
{
    public class LogicTests
    {
        [Fact]
        public void Should_replace_numbers_correctly()
        {
            var expectedArray = new int[,,] {
                {
                    {0, -2, 0 },
                    {-11, -8, -9},
                },
                {
                    {0, -7, 0 },
                    {-55, -36, 0},
                },
                {
                    {-99, 0, 0 },
                    {-55, 0, -45},
                }
            };
            var array = new int[,,] 
            {
                {
                    {2, -2, 5 },
                    {-11, -8, -9},
                },
                {
                    {11, -7, 5 },
                    {-55, -36, 2},
                },
                {
                    {-99, 10, 8 },
                    {-55, 55, -45},
                }
            };
            Logic.ReplaceArray(array);
            //Assert.Equal(expectedArray, actualArray);
            array.Should().BeEquivalentTo(expectedArray);
        }
    }
}
