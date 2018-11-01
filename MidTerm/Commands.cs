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
                
                Console.Clear();
                Console.WriteLine("------List of All Books------");
                Console.WriteLine();
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

                Console.Clear();
                Console.WriteLine("------Books from the publisher Apress------");
                Console.WriteLine();
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

                Console.Clear();
                Console.WriteLine("------Author with shortest First Name------");
                Console.WriteLine();
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

                Console.Clear();
                Console.WriteLine("------First Book Author with First Name Adam------");
                Console.WriteLine();
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

                Console.Clear();
                Console.WriteLine("------Book with page count > 1000------");
                Console.WriteLine();
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

                Console.Clear();
                Console.WriteLine("------Books sorted by Author Last Name------");
                Console.WriteLine();
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

                Console.Clear();
                Console.WriteLine("------Books sorted by Title Descending------");
                Console.WriteLine();
                foreach (var book in sortByTitleDesc)
                {
                    Console.WriteLine(book);
                }
            }
        }

        // show all Books Grouped by publisher
        public static void BooksGroupedByPublisher()
        {
            using (var db = new AppDbContext())
            {
                var books = db.Books.Include(a => a.Author);
                var grpBook = books.GroupBy(p => p.Publisher);

                Console.Clear();
                Console.WriteLine("--Books Grouped by Publisher------");
                Console.WriteLine();

                foreach (var book in grpBook)
                {
                    foreach (var b in book)
                    {
                        Console.WriteLine(b);
                    }
                }

            }
        }

        // show all Books Grouped by publisher and sorted by Author's last name
        public static void GrpByPubSortByAuthLName()
        {
            using (var db = new AppDbContext())
            {
                var books = db.Books.Include(a =>  a.Author);
                var bookSrt = books.OrderBy(a => a.Author.LastName);
                var booksGrp = bookSrt.GroupBy(p => p.Publisher);

                Console.Clear();
                Console.WriteLine("------Books Grouped by publisher and Sorted by Author's Last name------");
                Console.WriteLine();

                foreach (var book in booksGrp)
                {
                    foreach (var b in bookSrt)
                    {
                        Console.WriteLine(b);
                    }
                }
            }
        }
    }
}