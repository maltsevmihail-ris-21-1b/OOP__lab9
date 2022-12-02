namespace OOP__lab9
{
    public class Program
    {
        public static bool Compare(Money m1, Money m2)
        {
            return (m1.Compare(m2));
        }
        
        static void Main(string[] args)
        {
            //Money money = new Money(1, -1);
            //money.Show();

            ////Money money1 = new Money();
            ////money1.Kopeks = 1100;
            ////money1.Show();

            ////Console.WriteLine(money.Compare(money1));
            ////Console.WriteLine(Compare(money, money1));

            ////Console.WriteLine($"Чило записей: {Money.Counter}");

            //++money;

            //money.Show();

            //money++;

            //money.Show();


            //Console.WriteLine();

            //Console.WriteLine(money);
            //Console.WriteLine((double)money);

            //money -= 150;
            //money.Show();

            //MoneyArray array = new MoneyArray(15);
            //MoneyArray array2 = new MoneyArray(array);
            //array.Show();
            //array2.Show();
            //Console.WriteLine("Номер минимального элемента: " + array2.FindMinIndex());

            MoneyArray expected = new MoneyArray(3);
            expected.Show();
        }
    }
}