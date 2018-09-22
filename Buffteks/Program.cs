using System;
using Buffteks.Models;

namespace Buffteks
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new AppDbContext())
            {
               foreach (var s in context.Student)
               {
                   System.Console.WriteLine(s);
               }
            }
        }
    }
}
