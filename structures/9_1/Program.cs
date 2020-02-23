using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1
{
    class Program
    {
        struct Book
        {
            public string title;
            public string name;
            //    public string author;

            public Book(string t, string n)
                {
                title = t; name = n;
                }
          public  void DisplayInfo()
            {
                Console.WriteLine($"title={title} name = {name}");
            }
        }

        static void Main(string[] args)
        {
            Book b;
            b.title = "Rick and Morty";
            b.name = "Alex";
            b.DisplayInfo();

            Book[] book = new Book[2];
            book[0].title = "hj";// book[0] = new Book("hj", "g")
            book[0].name = "g";//
            book[1].title = "qw";
            book[1].name = "w";

            foreach(Book i in book)
            {
                i.DisplayInfo();
            }
        }
        Book bk = new Book("hj", "g");
    }
}
