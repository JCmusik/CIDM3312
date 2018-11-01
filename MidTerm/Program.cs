using System;
using DataAccess;

namespace MidTerm
{
    class Program
    {
        static void Main(string[] args)
        {
            SeedDatabase.Seed();

            do
            {
                Console.WriteLine("\nChoose an option: ");
                Console.WriteLine("s (show all books)\na (books by APress)\nshort (shortest author first name)\nadam (book auth first name Adam)\n1000 (pages greater than 1000)\nsrtLname (sort by Author last name)\ntitleDesc (sort by title descending)\ngrpByPub (group by pub)\ngrpSrt (group by pub, sort by auth last name)\nclr (clear console)\ne (to exit)");
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
                    case "adam":
                        Commands.FindFirstBookAuthorNamedAdam();
                        break;
                    case "1000":
                        // first book whose page count is greater than 1000
                        Commands.PagesGreaterThan1000();
                        break;
                    case "srtLname":
                        // show all Books sorted by Author's last name
                        Commands.SortByAuthLastName();
                        break;
                    case "titleDesc":
                        // show all Books sorted by book title descending
                        Commands.SortByTitleDescending();
                        break;
                    case "grpByPub":
                        // show all Books Grouped by publisher
                        Commands.BooksGroupedByPublisher();
                        break;
                    case "grpSrt":
                        // show all Books Grouped by publisher and sorted by Author's last name
                        Commands.GrpByPubSortByAuthLName();
                        break;
                    case "clr":
                        Console.Clear();
                        break;
                    case "e":
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("---Option unknown---\n");
                        break;
                }

            } while (true);
        }
    }
}
