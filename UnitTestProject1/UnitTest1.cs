using System;
using System.Linq;
using System.Security.Policy;
using Xunit;
using OOP__lab9;

namespace UnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyConstructor()
        {
            Money actual = new Time();
            Money expected = new Time(0, 0);
            Assert.Equal(expected, actual);
        }
    }
}
