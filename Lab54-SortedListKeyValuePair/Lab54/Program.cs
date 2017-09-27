using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab54
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> books = new SortedList<string, string>();

            books.Add("Curly's Lament", "978-0-470-38461-9"); // Keys must be unique and can only be used once
            books.Add("Nightmare at Fenway", "978-0-470-19135-4"); // Could use an int if you dont't use dashes for formatting, saves memory
            books.Add("Remeberance of Things Past", "978-0-470-047205-7");
            books.Add("The Stooge Mystique", "978-0-470-19137-6");

            //foreach (KeyValuePair<string,> book in books)
            //{
            //    Console.WriteLine(book);
            //}

            foreach (KeyValuePair<string, string> book in books)
            {
                string title = book.Key;
                string ISBN = book.Value;

                Console.WriteLine($"{title}, {ISBN}");
            }
            foreach (KeyValuePair<string, string> book in books)
            {
                string title = book.Key;

                Console.WriteLine($"{title}");
            }
            foreach (KeyValuePair<string, string> book in books)
            {
                string ISBN = book.Value;

                Console.WriteLine($"{ISBN}");
            }
        }
    }
}
