using System;
using System.Collections.Generic;
using Buffteks.Models;

namespace Buffteks
{
    public class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Commands.CheckForDatabase();
                string[] input = {"create","read", "update", "delete", "project"}; 
                do
                {
                    Console.WriteLine("Menu Options");
                    Console.WriteLine("c (create new student) r (read student) u (update student phone #) d (delete student) p (project details) clr (clear console) e (exit)");
                    Console.Write("> ");
                    var option =  Console.ReadLine();

                    switch (option)
                    {
                        case "c":
                        Commands.AddStudents();
                        break;
                        case "r":
                        Commands.ReadStudentsFromDB();
                        break;
                        case "u":
                        Commands.UpdateStudentPhoneNumber();
                        break;
                        case "d":
                        Commands.DeleteStudent();
                        break;
                        case "p":
                        Commands.ReadProjectDetails();
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
            else
            {
                Commands.OneShotCommands(args);
            }
        }
    }
}
