using Lab9Main;

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
            Console.WriteLine("Создание с помощью конструктора с параметрами");
            Money money = new Money(11, 54);
            money.Show();

            Console.WriteLine("Создание с помощью конструктора по умолчанию");
            Money money1 = new Money();
            money1.Show();

            Console.WriteLine("Создание с помощью конструктора копирования");
            Money money2= new Money(money);
            money2.Show();

            Console.WriteLine("Сравнение двух объектов");
            money.Show(); money1.Show();
            Console.WriteLine(money.Compare(money1));
            money.Show(); money2.Show();
            Console.WriteLine(Compare(money, money2));

            Console.WriteLine($"Количество записей: {Money.Counter}");
            Console.WriteLine("-------------------------------------------------------------");


            Console.WriteLine("Операции декркмента и инкремента");
            money--;
            money.Show();
            money++;
            money.Show();

            Console.WriteLine("Операции приведения типа");
            Console.WriteLine("Неявное(рубли)");
            Console.WriteLine(money);
            Console.WriteLine("Явное\n" + (double)money);

            Console.WriteLine("Вычитание целого числа из Money\nmoney - 5:");
            money -= 5;
            money.Show();
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("Работа с классом-коллекцией");

            Console.WriteLine("Конструктор с параметрами");
            var userInteractor = new UserInteractor();
            int size = userInteractor.GetIntFromUser("Введите размер коллекции");
            MoneyArray moneyArray = new MoneyArray(size);
            moneyArray.Show();

            Console.WriteLine("Конструктор по умаолчанию");
            MoneyArray moneyArray1 = new MoneyArray();
            moneyArray1.Show();

            Console.WriteLine("Конструктор копирования");
            var moneyArray2 = new MoneyArray(moneyArray);
            moneyArray2.Show();

            Console.WriteLine("Поиск миннимального элемента:");
            Console.WriteLine(moneyArray.FindMinIndex());

            Console.WriteLine("Количество элементов: " + Money.Counter);
        }
    }
}