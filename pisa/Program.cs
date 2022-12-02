using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP__lab9
{
    internal class Program
    {
        public static bool Compare(Money m1, Money m2)
        {
            return (m1.Compare(m2));
        }
        public static int FindMinIndex(MoneyArray array)
        {
            if (array.Length != 0)
            {
                Money min = array[0];
                int minIndex = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                        minIndex = i;
                    }
                }
                return minIndex + 1;
            }
            else
            {
                Console.WriteLine("Массив пустой");
                return -1;
            }
        }
        static void Main(string[] args)
        {
            Money money = new Money(1, -1);
            money.Show();

            //Money money1 = new Money();
            //money1.Kopeks = 1100;
            //money1.Show();

            //Console.WriteLine(money.Compare(money1));
            //Console.WriteLine(Compare(money, money1));

            //Console.WriteLine($"Чило записей: {Money.Counter}");

            ++money;

            money.Show();

            money++;

            money.Show();


            Console.WriteLine();

            Console.WriteLine(money);
            Console.WriteLine((double)money);

            money -= 150;
            money.Show();

            MoneyArray array = new MoneyArray(15);
            array.Show();
            Console.WriteLine("Номер минимального элемента: " + FindMinIndex(array));
        }
    }
}