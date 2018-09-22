using System;
using Buffteks.Models;

namespace Buffteks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new record
            // System.Console.Write("What is your first name: ");
            // var fName = Console.ReadLine();

            // System.Console.Write("What is your last name: ");
            // var lName = Console.ReadLine();

            // System.Console.Write("What is your email: ");
            // var email = Console.ReadLine();

            // System.Console.WriteLine("What is your phone number: ");
            // var phoneNum = Console.ReadLine();

            // using (var context = new AppDbContext())
            // {
            //     context.Student.Add(new Student {FirstName = fName, LastName = lName, Email = email, PhoneNumber = phoneNum});
            //     context.SaveChanges();
            // }

            // Read from Database
            using(var context = new AppDbContext())
            {
               foreach (var s in context.Student)
               {
                   System.Console.WriteLine($"\n{s}");
               }
            }

            // Update new record

            // Delete new record
        }
    }
}
