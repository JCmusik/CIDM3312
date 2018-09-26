using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;

namespace EFIA
{
    public static class Commands
    {
        public static void ListAll()
        {
            using (var db = new AppDbContext())              //#A
            {
                foreach (var book in db.Books.AsNoTracking() //#B
                    .Include(a => a.Author))                 //#C
                {
                    var webUrl = book.Author.WebUrl ?? "- no web url given -";
                    Console.WriteLine($"ID: {book.BookId} {book.Title} by {book.Author.Name}");
                    Console.WriteLine($"Description: {book.Description}");
                    Console.WriteLine("     Published on " +
                        $"{book.PublishedOn:dd-MM-yyyy}. {webUrl}");
                }
            }
        }


        /// <summary>
        /// Prompts user for pertinent infomation to create a new book, stores it to the db, and lists all book in db.
        /// </summary>
        /// <remarks> For adding records to db <see cref="https://docs.microsoft.com/en-us/ef/core/saving/basic#adding-data">
        public static void CreateNewRecord()
        {
            // Ask for book Title
            Console.Write("Enter Book Title: ");
            var title = Console.ReadLine();
            // Ask for book description
            Console.Write("Enter Book Description: ");
            var desc = Console.ReadLine();
            // Ask forDate published on
            Console.Write("Enter Book Date of Publication (dd-MMM-yyyy): ");
            var pubDate = DateTime.Parse(Console.ReadLine());
            //Ask for Book Author
            Console.Write("Enter Book Author: ");
            var author = Console.ReadLine();


            using (var db = new AppDbContext())
            {
                var book = new Book { Title = title, Description = desc, PublishedOn = pubDate, Author = new Author{Name = author}};

                db.Books.Add(book);

                db.SaveChanges();
                Console.WriteLine(".. SavedChanges called.");
                ListAll();
                Program.DisplayMenuOptions();
            }
        }

        /// <summary>
        /// Update exisiting record
        /// </summary>
        /// <remarks>For updating new records in db see <see cref="https://docs.microsoft.com/en-us/ef/core/saving/basic#updating-data"></remarks>
        public static void UpdateRecord()
        {
            // Display list of books to user
            Console.WriteLine("Current List of books:\n");
            ListAll();

            // Prompt user to specifiy which book
            Console.Write("\nEnter the Id of the book you would like to update: ");
            var bookToUpdate = Int32.Parse(Console.ReadLine());

            System.Console.Write("Choose option for the field you would like to update. 1) Title 2) Description 3) Date published on 4) Author 5) Web url?) ");
            var fieldToUpdate = Int32.Parse(Console.ReadLine());

            using (var db = new AppDbContext())
            {
                var book = db.Books.Include(a => a.Author).Single(b => b.BookId == bookToUpdate);
                switch (fieldToUpdate)
                {
                    case 1:
                        Console.Write("Enter new title: ");
                        var newTitle = Console.ReadLine();
                        book.Title = newTitle;
                        break;
                    case 2:
                        Console.Write("Enter new description: ");
                        var newDesc = Console.ReadLine();
                        book.Description = newDesc;
                        break;
                    case 3:
                        Console.Write("Enter new published on date (DD-MM-YYYY): ");
                        var newPubDate = DateTime.Parse(Console.ReadLine());
                        book.PublishedOn = newPubDate;
                        break;
                    case 4:
                        Console.Write("Enter new Author: ");
                        var newAuthor = Console.ReadLine();
                        book.Author.Name = newAuthor;
                        break;
                    case 5:
                        Console.Write("Enter new web url: ");
                        var newWebUrl = Console.ReadLine();
                        book.Author.WebUrl = newWebUrl;
                        break;
                    default:
                        break;
                }
                db.SaveChanges();
                System.Console.WriteLine("...Changes saved....\n");
                Console.WriteLine($"{book.Title} by {book.Author.Name}");
                Console.WriteLine($"Description: {book.Description}");
                Console.WriteLine($"     published on {book.PublishedOn:dd-MM-YYYY}. {book.Author.WebUrl}");
            }
        }

        /**************************************************************
        #A We create the application's DbContext through which all database accesses are done
        #B This reads all the books. The AsNoTracking() says this is a read-only access
        #C The include causes the Author information to be ‘eagerly’ loaded with each book. See chapter 2 for more on this
        * *************************************************************/

        public static void ChangeWebUrl()
        {
            Console.Write("New Quantum Networking WebUrl > ");
            var newWebUrl = Console.ReadLine();                   //#A

            using (var db = new AppDbContext())
            {
                var book = db.Books
                    .Include(a => a.Author)                        //#B
                    .Single(b => b.Title == "Quantum Networking"); //#C

                book.Author.WebUrl = newWebUrl;                    //#D
                db.SaveChanges();                                  //#E
                Console.WriteLine("... SavedChanges called.");
            }

            ListAll();                                             //#F
        }
        /**************************************************************
        #A We read in from the console the new url
        #B We make sure the author information is 'eager' loaded with the book
        #C We select only the book with the title "Quantum Networking"
        #D To update the database we simply change the data that was read in
        #E The SaveChanges() tells EF Core to check for any changes to the data that has been read in and write out those changes to the database
        #F Finally we list all the book information

         * ************************************************************/

        public static void ListAllWithLogs()
        {
            var logs = new List<string>();
            using (var db = new AppDbContext())
            {
                var serviceProvider = db.GetInfrastructure();
                var loggerFactory = (ILoggerFactory)serviceProvider.GetService(typeof(ILoggerFactory));
                loggerFactory.AddProvider(new MyLoggerProvider(logs));

                foreach (var book in
                    db.Books.AsNoTracking()
                    .Include(a => a.Author))
                {
                    var webUrl = book.Author.WebUrl == null
                        ? "- no web url given -"
                        : book.Author.WebUrl;
                    Console.WriteLine(
                        $"{book.Title} by {book.Author.Name}");
                    Console.WriteLine("     " +
                        $"Published on {book.PublishedOn:dd-MMM-yyyy}" +
                        $". {webUrl}");
                }
            }
            Console.WriteLine("---------- LOGS ------------------");
            foreach (var log in logs)
            {
                Console.WriteLine(log);
            }
        }

        public static void ChangeWebUrlWithLogs()
        {
            var logs = new List<string>();
            Console.Write("New Quantum Networking WebUrl > ");
            var newWebUrl = Console.ReadLine();

            using (var db = new AppDbContext())
            {
                var serviceProvider = db.GetInfrastructure();
                var loggerFactory = (ILoggerFactory)serviceProvider.GetService(typeof(ILoggerFactory));
                loggerFactory.AddProvider(new MyLoggerProvider(logs));

                var book = db.Books
                    .Include(a => a.Author)
                    .Single(b => b.Title == "Quantum Networking");
                book.Author.WebUrl = newWebUrl;
                db.SaveChanges();
                Console.Write("... SavedChanges called.");
            }
            Console.WriteLine("---------- LOGS ------------------");
            foreach (var log in logs)
            {
                Console.WriteLine(log);
            }
        }

        /// <summary>
        /// This will wipe and create a new database - which takes some time
        /// </summary>
        /// <param name="onlyIfNoDatabase">If true it will not do anything if the database exists</param>
        /// <returns>returns true if database database was created</returns>
        public static bool WipeCreateSeed(bool onlyIfNoDatabase)
        {
            using (var db = new AppDbContext())
            {
                if (onlyIfNoDatabase && (db.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists())
                    return false;

                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                if (!db.Books.Any())
                {
                    WriteTestData(db);
                    Console.WriteLine("Seeded database");
                }
            }
            return true;
        }

        public static void WriteTestData(this AppDbContext db)
        {
            var martinFowler = new Author
            {
                Name = "Martin Fowler",
                WebUrl = "http://martinfowler.com/"
            };

            var books = new List<Book>
            {
                new Book
                {
                    Title = "Refactoring",
                    Description = "Improving the design of existing code",
                    PublishedOn = new DateTime(1999, 7, 8),
                    Author = martinFowler
                },
                new Book
                {
                    Title = "Patterns of Enterprise Application Architecture",
                    Description = "Written in direct response to the stiff challenges",
                    PublishedOn = new DateTime(2002, 11, 15),
                    Author = martinFowler
                },
                new Book
                {
                    Title = "Domain-Driven Design",
                    Description = "Linking business needs to software design",
                    PublishedOn = new DateTime(2003, 8, 30),
                    Author = new Author { Name = "Eric Evans", WebUrl = "http://domainlanguage.com/"}
                },
                new Book
                {
                    Title = "Quantum Networking",
                    Description = "Entangled quantum networking provides faster-than-light data communications",
                    PublishedOn = new DateTime(2057, 1, 1),
                    Author = new Author { Name = "Future Person"}
                }
            };

            db.Books.AddRange(books);
            db.SaveChanges();
        }
    }
}