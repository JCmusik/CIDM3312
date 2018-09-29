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
                        // add method
                        Console.WriteLine("Call read method");
                        break;
                    case "update" :
                        // add method
                        Console.WriteLine("Call update method");
                        break;
                    case "delete" :
                        // add method
                        Console.WriteLine("Call delete method");
                        break;
                    case "-help" :
                        Commands.HelpMe();
                        break;
                    default:
                        break;
                }
                    
            }
            

            // Read

            // Update

            // Delete
        }
    }
}
