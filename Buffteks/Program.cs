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
                Commands.CheckForDatabase();
            
            foreach (var item in args)
            {
                switch (item)
                {
                    case "create" : 
                        Commands.AddStudents();
                        break;
                    case "read" :
                        Commands.ReadStudentsFromDB();
                        break;
                    case "update" :
                        Commands.UpdateStudentPhoneNumber();
                        break;
                    case "delete" :
                        Commands.DeleteStudent();
                        break;
                    case "project" :
                        Commands.ReadProjectDetails();
                        break;
                    case "-help" :
                        Commands.HelpMe();
                        break;
                    default:
                        Console.Write("-----Command unknown------\n");
                        Commands.HelpMe();
                        break;
                }
                    
            }
            Console.WriteLine("\nUse dotnet run -help to see command options\n");
        }
    }
}
