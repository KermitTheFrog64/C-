using System;
using System.Collections.Generic;
using MyClass;

namespace MyClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publ = new Publisher("Наука и жизнь", "nauka@mail.ru", 1234, new DateTime(2014, 12, 14));

            Book b2 = new Book("Толстой Л.Н.", "Война и мир", publ, 1234, 2013, 101, true);
            b2.TakeItem();
            b2.Print();

            Audit.RunAudit();
            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
            mag1.TakeItem();
            mag1.Subs();
            mag1.Print();

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

            List<Item> itlist = new List<Item>();
            itlist.AddRange(new Item[] { b2, mag1});
            itlist.Sort();
            Console.WriteLine("\nСортировка по инвентарному номеру"); 
            foreach (Item x in itlist) 
            { 
                x.Print(); 
            }
        }
    }
}
