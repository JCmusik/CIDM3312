using System;
using Buffteks.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace Buffteks
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
            var Students = new List<Student>();
               var team = new Team
                {
                    Name ="Boss Squad",
                    Students = new List<Student>
                    {
                        new Student
                        {
                            FirstName = "John",
                            LastName = "Cunningham"
                        },
                        new Student
                        {
                            FirstName = "Mara",
                            LastName = "Kinoff"
                        }
                    }
                
                };
                context.Add(team);
                foreach (var s in team.Students)
                {
                    Students.Add(s);
                }

                foreach (var st in Students)
                {
                    context.Add(st);
                }
                context.SaveChanges();

                foreach (var t in context.Team)
                {
                    System.Console.WriteLine(t.Name);
                    foreach (var s in t.Students)
                    {
                        System.Console.WriteLine($"{s.FirstName} {s.LastName}");
                    }
                }
            }
        }
    }
}
