using System;

namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publ = new Publisher("Наука и жизнь", "science@gmail.com", 121, new DateTime(2016, 1, 1));
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", publ, 122, 2013, 101, true);
            b2.TakeItem();
            b2.Print();
            Magazine mag1 = new Magazine("О науке", 5, "ABS", 2012, 123, true);
            mag1.TakeItem();
            mag1.Print();
            b2.ReturnSrok();
            Console.WriteLine("\n Тестирование полиморфизма");
            Item it;
            it = b2;
            it.TakeItem();
            it.Return();
            it.Print();
            it = mag1;
            it.TakeItem();
            it.Return();
            it.Print();
        }
    }
}
