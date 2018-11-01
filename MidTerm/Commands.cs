using System;
using DataAccess;
using BookLibrary;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MidTerm
{
    public static class Commands
    {
        public static void ShowAllBooks()
        {
            using (var db = new AppDbContext())
            {
                var books = db.Books.Include(a => a.Author);

                foreach (var book in books)
                {
                    Console.WriteLine(book);
                    Console.WriteLine();
                }
            }
        }

        public static void BooksByAPress()
        {
            using (var db = new AppDbContext())
            {
                var books = db.Books.Include(a => a.Author);
                var booksByAPress = books.Where(b => b.Publisher == "Apress");

                foreach (var book in booksByAPress)
                {
                    Console.WriteLine(book);
                    Console.WriteLine();
                }
            }
        }

        public static void ShortestFirstName()
        {
            using (var db = new AppDbContext())
            {
                var books = db.Books.Include(a => a.Author);
                var minLength = books.Min(a => a.Author.FirstName.Length);
                var authShortestFName = books.Where(f => f.Author.FirstName.Length == minLength);

                foreach (var book in authShortestFName)
                {
                    Console.WriteLine(book);
                    Console.WriteLine();
                }

            }
        }
    }
}