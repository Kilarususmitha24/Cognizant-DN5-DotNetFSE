using System;

namespace InterfaceDemo
{
    class Report : IPrintable
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Report(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void Print()
        {
            Console.WriteLine("===== Report Details =====");
            Console.WriteLine("Title  : " + Title);
            Console.WriteLine("Author : " + Author);
        }
    }
}