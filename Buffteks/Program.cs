using System;
using Buffteks.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Buffteks
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                var team = context.Team.AsNoTracking().Include(s => s.Students);
                
                

                foreach (var t in team)
                {
                    var student = new Student{FirstName = "John", LastName="Cunningham"};
                    var student2 = new Student{FirstName = "Mara", LastName="Kinoff"};
                    context.Add(student);
                    context.Add(student2);
                    context.SaveChanges();
                }

                foreach (var t in team)
                {
                    System.Console.WriteLine($"Team Name: {t.Name}");
                    System.Console.WriteLine($"{t.Students.FirstName}");
                }
            }
        }
    }
}
