using NuGet.Frameworks;
using Xunit.Sdk;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using OOP__lab9;
using System.IO;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ComparisonTest1()
        {
            bool actual = new Money(0, 0) < new Money(1, 0);
            bool expected = true;
            Assert.Equal(expected, actual);
        }

        [Fact]  
        public void ComparisonTest2()
        {
            Money expected = new Money();
            Money actual = new Money(0, 0);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ComparisonTest3()
        {
            Money actual = new Money(12, 0);
            actual--;
            Money expected = new Money(11, 99);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ComparisonTest4()
        {
            Money actual = new Money(12, 0);
            actual++;
            Money expected = new Money(12, 1);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ComparisonTest5()
        {
            bool expected = new Money(12, 0) > new Money(11, 0);
            bool actual = true;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ComparisonTest6()
        {
            Money actual = new Money(12, 0);
            Money expected = new Money(actual);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ComparisonTest7()
        {
            int actual = new Money(12, 0);
            int expected = 12;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ComparisonTest8()
        {
            MoneyArray actual = new MoneyArray(5);
            MoneyArray expected = new MoneyArray(5);
            Assert.Equal(expected.Length, actual.Length);
        }
        [Fact]
        public void ComparisonTest9()
        {
            Money expected = new Money(10, 10);
            double actual = 0.1;
            Assert.Equal((double)expected, actual);
        }
        [Fact]
        public void ComparisonTest10()
        {
            MoneyArray expected = new MoneyArray(10);
            MoneyArray actual = new MoneyArray(expected);
            Assert.Equal(expected.FindMinIndex(), actual.FindMinIndex());
        }
        [Fact]
        public void ComparisonTest11()
        {
            MoneyArray expected = new MoneyArray(1);
            MoneyArray actual = new MoneyArray(expected);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ComparisonTest12()
        {
            MoneyArray expected = new MoneyArray(1);
            expected[0] = new Money(1, 1);
            Money actual = new Money(1, 1);
            Assert.Equal(expected[0], actual);
        }
        [Fact]
        public void ComparisonTest13()
        {
            Money money = new Money(1, 1);
            Money money1 = new Money(5, 1);
            Money money2 = new Money(4, 0);   
            Assert.Equal(money1 - money, money2);
        }
        [Fact]
        public void ComparisonTest14()
        {
            Money.NullCounter();
            int expected = 3;
            MoneyArray mArr = new MoneyArray(expected);
            Assert.Equal(expected, Money.Counter);
        }
        [Fact]
        public void ComparisonTest15()
        {
            Money money = new Money(0, 5);
            money -= 500;
            Assert.Equal(money, new Money(0,0));
        }
        [Fact]
        public void ComparisonTest16()
        {
            Money money = new Money(0, 5);
            Money money1 = new Money(money);
            bool expected = Program.Compare(money, money1);
            bool actual = true;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ComparisonTest17()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var n1 = new Money(12, 0);
            n1.Show();

            String? actual = stringWriter.ToString();
            String? expected = "12 руб. 0 коп.\r\n";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ComparisonTest18()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var n1 = new MoneyArray(1);
            n1[0] = new Money(12, 0); 
            n1.Show();

            String? actual = stringWriter.ToString();
            String? expected = "{\r\n1:\t12 руб. 0 коп.\r\n}\r\n";

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ComparisonTest19()
        {
            var money = new Money();
            int expected = 0;
            money.Kopeks = -1;
            int actual = money.Kopeks;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ComparisonTest20()
        {
            var money = new Money();
            int expected = 1;
            money.Kopeks = 101;
            int actual = money.Kopeks;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ComparisonTest21()
        {
            var money = new Money(12,0);
            int expected = 0;
            money.Rubles = -5;
            int actual = money.Rubles;
            Assert.Equal(expected, actual);
        }
    }   
}