using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP__lab9
{
    internal class MoneyArray
    {
        Money[] array;
        private int size;
        static Random rnd = new Random();
        private static int counter;
        public static int Counter
        {
            get { return counter; }
            private set { counter = value; }
        }


        public MoneyArray()
        {
            array = new Money[0];
            size = array.Length;
            Counter += 0;
        }

        public MoneyArray(int size)
        {
            array = new Money[size];
            for (int i = 0; i < size; i++)
            {
                Money tempMoney = new Money(rnd.Next(20), rnd.Next(100));
                array[i] = tempMoney;
            }
            Counter += size;
        }

        public MoneyArray(params Money[] list)
        {
            array = new Money[list.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = list[i];
            }
            Counter += array.Length;
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
}
}
