using System;
using LINQPractice.Models;

namespace LINQPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check for database existence
            // if not found seed the database
            Command.SeedDatabase();

            
        }
    }
}
