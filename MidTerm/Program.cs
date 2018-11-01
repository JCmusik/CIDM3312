using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;

namespace MidTerm
{
    class Program
    {
        static void Main(string[] args)
        {
            Seed.SeedDatabase();

            Console.WriteLine(
                "Commands: l (list), u (change url), r (resetDb) and e (exit) - add -l to first two for logs");
            do
            {
                Console.Write("> ");
                var command = Console.ReadLine();
                switch (command)
                {
                    case "l":
                        // display all records in Book table to console

                        break;
                    case "u":
                        //Commands.ChangeWebUrl();
                        break;
                    case "l -l":
                        //Commands.ListAllWithLogs();
                        break;
                    case "u -l":
                        //Commands.ChangeWebUrlWithLogs();
                        break;
                    case "r":
                        //Commands.WipeCreateSeed(false);
                        break;
                    case "e":
                        return;
                    default:
                        Console.WriteLine("Unknown command.");
                        break;
                }
            } while (true);



        }
    }
}
