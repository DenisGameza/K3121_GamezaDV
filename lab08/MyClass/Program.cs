using System;
using System.Collections.Generic;
namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publ = new Publisher("test", "ta@mail.ru", 1000, new DateTime(2014, 10, 16));
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", publ, 1246, 2016, 18, true);
            b2.TakeItem();
            Audit.RunAudit();
            Magazine mag1 = new Magazine("Обо всём", 4, "Правда", 2016, 12, true);
            mag1.TakeItem();
            mag1.Subs();
            Audit.StopAudit();
            Magazine mag2 = new Magazine("О разуме", 6, "Горе", 2015, 8, true);
            Console.WriteLine("\n Тестирование полиморфизма");
            b2.ReturnSrok();
            Item it;
            it = b2;
            it.TakeItem();
            it.Return();
            it = mag1;
            it.TakeItem();
            it.Return();
            List<Item> list = new List<Item>();
            list.AddRange(new Item[] { b2, mag1 });
            list.Sort();
            Console.WriteLine("\nСортировка по инвентарному номеру");
            foreach (Item x in list){
                x.Print(); }

        }
    }
}
