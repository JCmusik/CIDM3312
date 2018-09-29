﻿using System;
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
                        // TODO: add method
                        Commands.ReadStudentsFromDB();
                        break;
                    case "update" :
                        // TODO: add method
                        Console.WriteLine("Call update method");
                        break;
                    case "delete" :
                        // TODO: add method
                        Console.WriteLine("Call delete method");
                        break;
                    case "-help" :
                        Commands.HelpMe();
                        break;
                    default:
                        break;
                }
                    
            }
        }
    }
}
