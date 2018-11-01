using System;
using System.Collections.Generic;
using System.Linq;
using BookLibrary;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public static class Seed
    {
        public static void SeedDatabase()
        {
            using (var db = new SqliteDbContext())
            {
                var bookTable = db.Books.Include(a => a.Author);

                db.Database.EnsureCreated();

                if (!bookTable.Any())
                {
                    var adamFreeman =
                        new Author
                        {
                            Name = "Adam Freeman",
                        };

                    var haishiBai =
                        new Author
                        {
                            Name = "Haishi Bai"
                        };

                    var books = new List<Book>
                {
                    new Book
                    {
                        Title = "Pro ASP.NET Core MVC 2 7th ed. Edition",
                        Publisher = "Apress",
                        PublishDate = new DateTime(2017, 10, 25),
                        Pages = 1017,
                        Author = adamFreeman
                    },
                    new Book
                    {
                        Title = "Pro Angular 6 3rd Edition",
                        Publisher = "Apress",
                        PublishDate = new DateTime(2017, 10, 18),
                        Pages = 776,
                        Author = adamFreeman
                    },
                    new Book
                    {
                        Title = "Programming Microsoft Azure Service Fabric (Developer Reference) 2nd Edition",
                        Publisher = "Microsoft Press",
                        PublishDate = new DateTime(2018, 5, 25),
                        Pages = 528,
                        Author = haishiBai
                    }
                };

                    db.AddRange(books);
                    db.SaveChanges();
                    Console.WriteLine("\nBooks and Authors added to database\n");

                }
                else
                {
                    Console.WriteLine("\nDatabase exists\n");
                }


            }
        }
    }
}