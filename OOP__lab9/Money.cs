using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__lab9
{

    public class Money
    {
        private int rubles;
        private int kopeks;
        private static int counter;
        public int Rubles
        {
            get { return rubles; }
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Рублей не может быть меньше нуля!");
                    rubles = 0;
                }
                else
                {
                    rubles = value;
                }
            }
        }
        public int Kopeks
        {
            get { return kopeks; }
            set 
            {  
                if (value < 0)
                {
                    Console.WriteLine("Копеек не может быть меньше нуля!");
                    kopeks = 0;
                }
                else if (value > 99)
                {
                    kopeks = value % 100;
                    rubles += value / 100;
                }
                else
                {
                    kopeks = value;
                }
            }
        }
        public static int Counter
        {
            get { return counter; }
            private set { counter = value; }
        }

        public static void NullCounter()
        {
            Counter = 0;
        }

        public Money (Money money)
        {
            Rubles = money.rubles;
            Kopeks = money.kopeks;
            Counter = counter + 1;
        }
        public Money(int iRubles, int iKopeks)
        {
            Rubles = iRubles;
            Kopeks = iKopeks;
            Counter = counter + 1;
        }
        public Money()
        {
            Rubles = 0;
            Kopeks = 0;
            Counter = counter + 1;
        }
        public void Show()
        {
            Console.WriteLine($"{Rubles} руб. {Kopeks} коп.");
        }

        public bool Compare(Money m1)
        {
            return (this.Kopeks == m1.Kopeks
                &&  this.Rubles == m1.Rubles);
        }

        public static Money operator --(Money money)
        {
            if (money.Rubles > 0 && money.Kopeks == 0)
            {
                money.Rubles--;
                money.Kopeks = 99;
            }
            else
            {
                money.Kopeks--;
            }
            return money;
        }

        public static Money operator ++(Money money)
        {
            return new Money(money.Rubles, money.Kopeks + 1);
        }

        public static implicit operator int(Money money)
        {
            return money.Rubles;
        }

        public static explicit operator double(Money money)
        {
            double _D = money.Kopeks * 0.01;
            return _D;
        }
        public static Money operator -(Money m1, Money m2)
        {
            int money1Sum = m1.Rubles * 100 + m1.Kopeks;
            int money2Sum = m2.Rubles * 100 + m2.Kopeks;
            int sum = Math.Abs(money2Sum - money1Sum);
            return new Money(sum / 100, sum % 100); 
        }
        public static Money operator -(Money money, int _M)
        {
            int moneySum = money.Rubles * 100 + money.Kopeks;
            if (moneySum <= _M)
            {
                money.Kopeks = 0;
                money.Rubles = 0;
            }
            else
            {
                moneySum -= _M;
                money.Kopeks = moneySum % 100;
                money.Rubles = moneySum / 100;
            }
            return money;
        }

        public static bool operator <(Money _m1, Money _m2)
        {
            return _m1.Rubles * 100 + _m1.Kopeks < _m2.Rubles * 100 + _m2.Kopeks;
        }
        public static bool operator >(Money _m1, Money _m2)
        {
            return !(_m1.Rubles * 100 + _m1.Kopeks < _m2.Rubles * 100 + _m2.Kopeks || _m1 == _m2);
        }

        public override bool Equals(Object o)
        {
            return this.Compare((Money)o);
        }

        
    }
}
