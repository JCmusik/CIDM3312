using System;

namespace EFIA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Commands: c (create new), u (update record) l (list), w (change url), r (resetDb) and e (exit) - add -l to first two for logs");
            Console.Write(
                "Checking if database exists... ");
            Console.WriteLine(Commands.WipeCreateSeed(true) ? "created database and seeded it." : "it exists.");
            do
            {
                Console.Write("> ");
                var command = Console.ReadLine();
                switch (command)
                {
                    case "c":
                        Commands.CreateNewRecord();
                        break;
                    case "u":
                        Commands.UpdateRecord();
                        break;
                    case "l":
                        Commands.ListAll();
                        break;
                    case "w":
                        Commands.ChangeWebUrl();
                        break;
                    case "l -l":
                        Commands.ListAllWithLogs();
                        break;
                    case "u -l":
                        Commands.ChangeWebUrlWithLogs();
                        break;
                    case "r":
                        Commands.WipeCreateSeed(false);
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
