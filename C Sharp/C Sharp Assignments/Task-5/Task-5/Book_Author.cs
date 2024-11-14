using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Book_Author
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        public Book_Author(string BookName, string AuthorName)
        {
            this.BookName = BookName;
            this.AuthorName = AuthorName;
        }
        public void Display()
        {
            Console.WriteLine("Book Name: " + BookName);
            Console.WriteLine("Author Name: " + AuthorName);
        }

    }
    class BookShelf
    {
        private Book_Author[] b = new Book_Author[5];

        public Book_Author this[int i]
        {
            get { return b[i]; }
            set { b[i] = value; }
        }
    }

    class Author
    {
        static void Main()
        {
            BookShelf bookshelf = new BookShelf();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter Book Name {i + 1}");
                string BookName = Console.ReadLine();

                Console.WriteLine($"Enter Author Name {i + 1}");
                string AuthorName = Console.ReadLine();

                bookshelf[i] = new Book_Author(BookName, AuthorName);

                Console.WriteLine($"Book {i + 1} details");
                bookshelf[i].Display();
            }
              Console.ReadLine();
        }
    }
}
