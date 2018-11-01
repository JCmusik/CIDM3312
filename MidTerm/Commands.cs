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
        // first book by an author named "Adam" and print that record to the screen
        public static void FindFirstBookAuthorNamedAdam()
        {
            using (var db = new AppDbContext())
            {
                var books = db.Books.Include(a => a.Author).ToList();
                var authAdam = books.Find(a => a.Author.FirstName == "Adam");

                Console.WriteLine(authAdam);

            }
        }
        // first book whose page count is greater than 1000
        public static void PagesGreaterThan1000()
        {
            using (var db = new AppDbContext())
            {
                var books = db.Books.Include(a => a.Author).ToList();
                var pgGt1000 = books.Find(pc => pc.Pages > 1000);

                Console.WriteLine(pgGt1000);
            }
        }

        // show all Books sorted by Author's last name
        public static void SortByAuthLastName()
        {
            using (var db = new AppDbContext())
            {
                var books = db.Books.Include(a => a.Author);
                var srtLName = books.OrderBy(l => l.Author.LastName).ToList();

                foreach (var book in srtLName)
                {
                    Console.WriteLine(book);
                }

            }
        }

        // show all Books sorted by book title descending
        public static void SortByTitleDescending()
        {
            using (var db = new AppDbContext())
            {
                var books = db.Books.Include(a => a.Author);
                var sortByTitleDesc = books.OrderByDescending(t => t.Title).ToList();

                foreach (var book in sortByTitleDesc)
                {
                    Console.WriteLine(book);
                }
            }
        }
    }
}