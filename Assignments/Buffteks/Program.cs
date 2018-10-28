using System;
using DataAccess.Models;

namespace Buffteks
{
    public class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Commands.CheckForDatabase();
                do
                {
                    Console.WriteLine("Menu Options");
                    Console.WriteLine("c (create new student) r (read student) u (update student phone #) d (delete student) p (project details) s (search) srt (sort students) g (group) clr (clear console) e (exit)");
                    Console.Write("> ");
                    var option =  Console.ReadLine();

                    switch (option)
                    {
                        case "c":
                            Commands.AddStudents();
                            break;
                        case "r":
                            using (var context = new AppDbContext())
                            {
                                Commands.ReadStudentsFromDB(context);
                            }
                            break;
                        case "u":
                            Commands.Update();
                            break;
                        case "d":
                            Commands.DeleteStudent();
                            break;
                        case "p":
                            Commands.ReadProjectDetails();
                            break;
                        case "s":
                            Commands.Search();
                            break;
                        case "srt":
                            Commands.SortRecords();
                            break;
                        case "g":
                            Commands.RecordsGroupBy();
                            break;
                        case "e":
                            return;
                        case "clr":
                            Console.Clear();
                            break;
                        default:
                            System.Console.WriteLine("Command unknown\n");
                            break;
                    }
                    
                } while (true);
                
            }
                Commands.OneShotCommands(args);
        }
    }
}
