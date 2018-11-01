using System;
using DataAccess;

namespace MidTerm
{
    class Program
    {
        static void Main(string[] args)
        {
            SeedDatabase.Seed();
            Console.WriteLine("\nChoose an option: ");
            Console.WriteLine("s (show all books)");

            do
            {
                Console.Write("> ");
                var response = Console.ReadLine();

                switch (response)
                {
                    case "s":
                        // Display all books to console
                        Commands.ShowAllBooks();
                        break;
                    case "e":
                        return;
                    default:
                        Console.WriteLine("---Option unknown---");
                        break;
                }

            } while (true);
        }
    }
}
