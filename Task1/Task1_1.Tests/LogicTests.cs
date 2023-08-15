using System;
using Xunit;

namespace Task1_1.Tests
{
    public class LogicTests
    {
        [Fact]
        public void Should_throw_Exception_for_incorrect_read_int()
        {
            var stringValue = "mnlkk";
            Assert.Throws<Exception>(() => Logic.ReadInt(stringValue));
        }

        [Fact]
        public void Should_throw_Exception_for_incorrect_read_int_1()
        {
            var stringValue = "   ";
            Assert.Throws<Exception>(() => Logic.ReadInt(stringValue));
        }
        [Fact]
        public void Should_calculate_square_corretly()
        {
            int intValue1 = 0;
            int intValue2 = 1;
            Assert.Throws<Exception>(() => Logic.CalculateSquare(intValue1, intValue2));
        }

        [Fact]
        public void Should_calculate_square_corretly_1()
        {
            int intValue1 = 11;
            int intValue2 = -1;
            Assert.Throws<Exception>(() => Logic.CalculateSquare(intValue1, intValue2));
        }
    }
}
