using System;
using System.Linq;
using Xunit;
using OOP__lab9;


namespace test_lab9
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyConstructor()
        {
            Money actual = new Time();
            Money  expected = new Time(0, 0);
            Assert.Equal(expected, actual);
        }
    }
}
