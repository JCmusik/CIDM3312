using System;
using Buffteks.Models;

namespace Buffteks
{
    public class Program
    {
        static void Main(string[] args)
        {
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
