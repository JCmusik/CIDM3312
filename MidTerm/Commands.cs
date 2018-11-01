using System;
using DataAccess;
using BookLibrary;

namespace MidTerm
{
    public static class Commands
    {
        public static void ShowAllBooks()
        {
            using (var db = new AppDbContext())
            {
                var books = db.Books;

                foreach (var book in books)
                {
                    Console.WriteLine(book);
                }
            }
        }
    }
}