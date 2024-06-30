using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign5ques1
{
    public class Books
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        public Books(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }

        public void Display()
        {
            Console.WriteLine($"Book: {BookName}\nAuthor: {AuthorName}\n");
        }
    }

    public class BookShelf
    {
        private Books[] books = new Books[5];

        public Books this[int index]
        {
            get
            {
                if (index < 0 || index >= books.Length)
                {
                    throw new IndexOutOfRangeException($"Index {index} is out of range for the BookShelf.");
                }
                return books[index];
            }
            set
            {
                if (index < 0 || index >= books.Length)
                {
                    throw new IndexOutOfRangeException($"Index {index} is out of range for the BookShelf.");
                }
                books[index] = value;
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            BookShelf shelf = new BookShelf();

            shelf[0] = new Books("Angels and demons", "Dan Brown");
            shelf[1] = new Books("Da Vinci Code", "Dan Brown");
            shelf[2] = new Books("Deception point", "Dan Brown");
            shelf[3] = new Books("Inferno", "Dan Brown");
            shelf[4] = new Books("Origin", "Dan Brown");

            Console.WriteLine("Books present in the bookshelf");
            for (int i = 0; i < 5; i++)
            {
                shelf[i].Display();
            }
            Console.ReadLine();
        }
    }

}
