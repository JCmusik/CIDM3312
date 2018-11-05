using System;
using System.Collections.Generic;
using System.Linq;
using BookLibrary;

namespace DataAccess
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();

                var adamFreeman = new Author
                {
                    FirstName = "Adam",
                    LastName = "Freeman"
                };

                var haishiBai = new Author
                {
                    FirstName = "Haishi",
                    LastName = "Bai"
                };

                var books = new List<Book>
                {
                    new Book
                    {
                        Title = "Pro ASP.NET Core MVC 2 7th ed. Edition",
                        Publisher = "Apress",
                        PublishDate = new DateTime(2017/10/25),
                        Pages = 1017,
                        Author = adamFreeman
                    },
                    new Book
                    {
                        Title = "Pro Angular 6 3rd Edition",
                        Publisher = "Apress",
                        PublishDate = new DateTime(2018/10/10),
                        Pages = 776,
                        Author = adamFreeman
                    },
                    new Book
                    {
                        Title = "Programming Microsoft Azure Service Fabric (Developer Reference) 2nd Edition",
                        Publisher = "Microsoft Press",
                        PublishDate = new DateTime(2018/05/25),
                        Pages = 528,
                        Author = haishiBai
                    }
                };

                if (!db.Books.Any())
                {
                    db.AddRange(books);
                    db.SaveChanges();
                    Console.WriteLine("Books and Authors added");
                }
                else
                {
                    Console.WriteLine("Database exists....");
                }
            }
        }
    }
}