using System;
using Xunit;

namespace Task1_4.Tests
{
    public class LogicTests
    {
        [Fact]
        public void Should_throw_Exception_for_incorrect_read_int()
        {
            var stringValue = "mnlkk";
            Assert.Throws<Exception>(() => Logic.ReadInt(stringValue));
        }
    }
}
