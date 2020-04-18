using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass
{
    class Book : Item
    {
        public string Author { get; set; }
        public string Title { get; set; } 
        public Publisher Publ { get; set; }
        public int Pages { get; set; } 
        public int Year { get; set; } 
        public Book(string author, string title, Publisher publisher, int pages, int year, long invNumber, bool taken) : base(invNumber, taken)
        { this.Author = author;  this.Title = title; this.Publ = publisher; this.Pages = pages; this.Year = year; }
        public override string ToString()
        {
            string bs = String.Format("\nКнига:\n Автор: {0}\n Название: {1}\n Год издания: {2}\n {3}стр.\n Стоимость аренды: {4}\nИздательство: {5}", Author, Title, Year, Pages, Book.price, Publ.ToString());
            return bs;
        }
        public override void Print()
        { Console.WriteLine(ToString()); Console.WriteLine("\n"); base.Print(); }
        private static double price;
        static Book() { Price = 9; }
        public static double Price
        {
            get { return price; }
            set { if (value >= 9) price = value; }
        }
        public void SetBook(string author, string title, Publisher publisher, int pages, int year)
        { this.Author = author; this.Title = title; this.Publ = publisher; this.Pages = pages; this.Year = year; }
        public Book(string author, string title, Publisher publisher, int pages, int year)
        { this.Author = author; this.Title = title; this.Publ = publisher; this.Pages = pages; this.Year = year; }
        public Book() { }
        public Book(string author, string title)
        { this.Author = author; this.Title = title; }
        public static void SetPrice(double price) { Book.Price = price;}
        public double PriceBook(int s) { double cust = s * price; return cust;}
        public override void Return() 
        {
            if (returnSrok == true)
                taken = true;
            else
                taken = false;
        }

    }
}
