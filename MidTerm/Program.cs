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
            Console.WriteLine("s (show all books) a (books by APress) short (shortest author first name) clr (clear console)");

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
                    case "a":
                        //show all records of Books Published by "APress"
                        Commands.BooksByAPress();
                        break;
                    case "short":
                        //show all records of Books whose author's first name is the shortest
                        Commands.ShortestFirstName();
                        break;
                    case "clr":
                        Console.Clear();
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
