using System;
using System.Linq;
using efcore.Models;

namespace efcore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new AppDbContext())
            {
               foreach (var p in ctx.Project)
               {
                   System.Console.WriteLine(p);
               }
               foreach (var s in ctx.Student)
               {
                   System.Console.WriteLine(s);
               }
            }
        }
    }
}
