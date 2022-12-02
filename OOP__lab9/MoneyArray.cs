using Lab9Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP__lab9
{
    public class MoneyArray
    {
        private Money[] array;
        private int size;
        static Random rnd = new Random();


        public MoneyArray()
        {
            array = new Money[0];
            size = array.Length;
        }

        public MoneyArray(int size)
        {
            var userInteractor = new UserInteractor();
            int action = userInteractor.GetIntFromUser("1. Случайные числа\n2. Ввод с клавиатуры");
            switch (action)
            {
                case 1:
                    {
                        array = new Money[size];
                        for (int i = 0; i < size; i++)
                        {
                            Money tempMoney = new Money(rnd.Next(20), rnd.Next(100));
                            array[i] = tempMoney;
                        }
                        break;
                    }
                case 2:
                    {
                        array = new Money[size];
                        for (int i = 0; i < size; i++)
                        {
                            int rub = userInteractor.GetIntFromUser("Введите количество рублей");
                            int kop = userInteractor.GetIntFromUser("Введите количество копеек");
                            Money tempMoney = new Money(rub, kop);
                            array[i] = tempMoney;
                        }
                        break;
                    }
            }
            
        }

        public MoneyArray(MoneyArray list)
        {
            array = new Money[list.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = list[i];
            }
        }
        public int Length
        {
            get { return array.Length; }
        }

        public void Show()
        {
            Console.WriteLine("{");
            for (int i = 0; i < this.Length; i++)
            {
                Console.Write((i + 1) + ":\t");
                array[i].Show();
            }
            Console.WriteLine("}");
        }

        public Money this[int index]
        {
            get 
            {
                if (index < 0 || index >= array.Length)
                {
                    Console.WriteLine("Выход за границы массива!");
                    return new Money(0, 0);
                }
                else
                {
                    return array[index];
                }
            }
            set { array[index] = value; }
        }
        public int FindMinIndex()
        {
            if (this.Length != 0)
            {
                Money min = this[0];
                int minIndex = 0;
                for (int i = 1; i < this.Length; i++)
                {
                    if (this[i] < min)
                    {
                        min = this[i];
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
        public override bool Equals(Object o)
        {
            bool result;
            for (int i = 0; i < this.Length; i++)
            {
                result = this[i] == ((MoneyArray)o)[i];
                if (result)
                    return true;
            }
            return false;
        }
    }
}
