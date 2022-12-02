using System;
using System.Linq;
using System.Security.Policy;
using Xunit;
using pisa;

namespace UnitTestProject2
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